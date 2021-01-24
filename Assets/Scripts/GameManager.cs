using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets = null;
    public TextMeshProUGUI scoreText = null;
    public TextMeshProUGUI gameOverText = null;
    public GameObject background = null;
    public bool isGameOver = false;

    private float spawnRate = 1.0f; // every second
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator SpawnTargets()
    {
        // spawn until
        while (!isGameOver)
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
        isGameOver = true;
        FadeOutBackgorund();
    }

    public void StartGame()
    {
        // start spawning
        StartCoroutine(SpawnTargets());
        // display init score
        UpdateScore(0);
    }

    /// <summary>
    /// Restart the current Game Scene
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void FadeOutBackgorund()
    {
        background.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0);
    }
}
