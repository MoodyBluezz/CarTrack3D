using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverScore;
    public GameObject gameOverPanel;
    private float _currentScore = 0;
    
    private void Update()
    {
        if (!gameOverPanel.activeInHierarchy)
        {
            _currentScore += 1 * Time.deltaTime;
            scoreText.text = $"Score: {_currentScore:00:00}";

        }
        else
        {
            scoreText.enabled = false;
            gameOverScore.text = scoreText.text;
            PlayerPrefs.SetFloat("lastScore", _currentScore);
        }
    }
}
