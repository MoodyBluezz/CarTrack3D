using TMPro;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public FinishController finishController;
    public TextMeshProUGUI text;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Car"))
        {
            finishController.Count++;
            text.text = $"Checkpoints {finishController.Count}/3";
            GetComponent<Collider>().enabled = false;
        }
    }
}
