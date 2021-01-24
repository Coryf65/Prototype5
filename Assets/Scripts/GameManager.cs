using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets = null;
    public TextMeshProUGUI scoreText = null;
    public TextMeshProUGUI gameOverText = null;
    
    private float spawnRate = 1.0f; // every second
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
        UpdateScore(0);       
    }

    IEnumerator SpawnTargets()
    {
        // spawn until
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);

            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }        
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;

        scoreText.text = $"Score: {score}";
    }

    /// <summary>
    ///  the Game is Over display GO screen and restart button
    /// </summary>
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
