using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public float horizontalInput;
    public float xRange = 12.0f;
    public float yRange = 12.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // a/d
        this.horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * this.speed);

        // space
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        float xInRange = Mathf.Min(this.xRange, Mathf.Max(-this.xRange, this.transform.position.x));
        float yInRange = Mathf.Min(this.yRange, Mathf.Max(-this.yRange, this.transform.position.y));
        this.transform.position = new Vector3(xInRange, yInRange, this.transform.position.z);
    }
}
