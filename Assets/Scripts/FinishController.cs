using TMPro;
using UnityEngine;

public class FinishController : MonoBehaviour
{
    public GameObject gameOverPanel;
    private TextMeshProUGUI _gameCondition;
    private int _lapCounter;
    private int _maxLapCount;

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
            _lapCounter++;

        CheckLapCounter();
    }
    
    private void CheckLapCounter()
    {
        if (_lapCounter == _maxLapCount + 1) 
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
