using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelector : MonoBehaviour
{
    private Button button = null;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty); // added an Event Listener waiting for a CLick
    }

    void SetDifficulty()
    {

    }
}
