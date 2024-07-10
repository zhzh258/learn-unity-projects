using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform wheelFL; // Front left wheel
    public Transform wheelFR; // Front right wheel
    public Transform wheelRL; // Rear left wheel
    public Transform wheelRR; // Rear right wheel


    public float speed = 20f;
    public float turnRate = 20f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * this.speed * forwardInput);
        float turnSpeed = this.forwardInput switch
        {
            > 0 => turnRate,
            < 0 => -turnRate,
            0 => 0,
            _ => 0
        };
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * this.horizontalInput);

        switch (this.horizontalInput)
        {
            case < 0:
                // set the 2 front wheels to 30 deg left relative to the car
                wheelFL.localRotation = Quaternion.Euler(0, -30f, 0);
                wheelFR.localRotation = Quaternion.Euler(0, -30f, 0);
                break;
            case > 0:
                // set the 2 front wheels to 20 deg right direction relative to the car
                wheelFL.localRotation = Quaternion.Euler(0, 30f, 0);
                wheelFR.localRotation = Quaternion.Euler(0, 30f, 0);
                break;
            default:
                // reset the 2 front wheels immediately
                wheelFL.localRotation = Quaternion.Euler(0, 0, 0);
                wheelFR.localRotation = Quaternion.Euler(0, 0, 0);
                break;
        }
    }
}
