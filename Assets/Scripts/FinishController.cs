using TMPro;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public GameObject gameOverPanel;
    private TextMeshProUGUI _gameCondition;
    private int _lapCounter;
    private int _maxLapCount;
    public int Count { get; set; } = 0;

    private void Start()
    {
        _gameCondition = gameOverPanel.GetComponentInChildren<TextMeshProUGUI>();
        Init();
    }
    
    private void Init()
    {
        _lapCounter = 0;
        _maxLapCount = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Car"))
        {
            if (Count == 3)
                _lapCounter++;
        }
        CheckLapCounter();
    }
    
    private void CheckLapCounter()
    {
        if (_lapCounter == _maxLapCount) 
            GameOver();
    }
    
    private void GameOver()
    {
        CarController.IsGameFinished = true;
        _gameCondition.text = "YOU WIN!!!";
        gameOverPanel.SetActive(true);
        Init();
    }
}
