using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoadScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        var score = PlayerPrefs.GetFloat("lastScore");
        scoreText.text = $"Your last score is: {score:00:00}";
    }
}
