using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zUpperBound = 30;
    private float zLowerBound = -5;
    private float xBound = 30;
    private float yLowerBound = -10;
    private float yUpperBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z > zUpperBound || Mathf.Abs(this.transform.position.x) > xBound)
        {
            Destroy(this.gameObject);
        } else if (this.transform.position.y < yLowerBound || this.transform.position.y > yUpperBound)
        {
            Destroy(this.gameObject);
        } else if (this.transform.position.z < zLowerBound)
        {
            Destroy(this.gameObject);
            print("GAME OVER");
        }
    }
}
