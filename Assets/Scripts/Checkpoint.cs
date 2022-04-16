using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public FinishController finishController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Car"))
        {
            finishController.Count++;
            GetComponent<Collider>().enabled = false;
        }
    }
}
