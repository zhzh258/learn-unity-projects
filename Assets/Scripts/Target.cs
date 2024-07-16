using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRb;
    private float minMomentum = 12;
    private float maxMomentum = 16;
    private float maxTorque = 10;
    private float xSpawnRange = 4;
    private float ySpawnPos = -6;

    public GameManager gameManagerScript;
    public int pointValue = 5;

    public ParticleSystem explosionParticle;

    
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        gameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Add a random force
        targetRb.AddForce(Vector3.up * Random.Range(minMomentum, maxMomentum), ForceMode.Impulse);
        // Add a random torque
        targetRb.AddTorque(
            Random.Range(-maxTorque, maxTorque),
            Random.Range(-maxTorque, maxTorque),
            Random.Range(-maxTorque, maxTorque),
            ForceMode.Impulse
        );
        // Set a random position
        transform.position = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), ySpawnPos);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // When mouse down on collider
    private void OnMouseDown()
    {
        print("OnMouseDown");
        Destroy(gameObject);
        // Shows an explosion effect
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
        // Update score
        gameManagerScript.AddScore(pointValue);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
