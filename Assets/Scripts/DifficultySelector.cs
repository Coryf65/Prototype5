using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{
    public int difficulty = 0;
    
    private Button button = null;
    private GameManager gameManager = null;

    private void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty); // added an Event Listener waiting for a CLick
    }

    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
