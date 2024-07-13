using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xMin || transform.position.x > xMax)
        {
            Destroy(gameObject);
        } else if (transform.position.z < zMin || transform.position.z > zMax)
        {
            Destroy(gameObject);
        }
    }
}
