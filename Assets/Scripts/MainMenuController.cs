using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    
    private void Start()
    {
        playButton.onClick.AddListener(() => SceneManager.LoadScene(sceneBuildIndex: 1));
    }
}
