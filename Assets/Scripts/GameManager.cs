using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets = new();
    private float spawnRate = 1.0f;
    private int score;
    public TextMeshProUGUI scoreText;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        AddScore(0); // init the score text
        StartCoroutine(SpawnTargets());
    }

    private IEnumerator SpawnTargets()
    {
        while (true)
        {
            // Waits for 1.0f second
            yield return new WaitForSeconds(spawnRate);
            // Get a random index
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void AddScore(int dScore)
    {
        score += dScore;
        scoreText.text = $"Score: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
