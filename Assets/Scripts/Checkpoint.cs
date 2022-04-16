using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public FinishController finishController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Car"))
        {
            Vector3 direction = other.transform.position - transform.position;
            if (Vector3.Dot (transform.forward, direction) < 0) {
                finishController.Count++;
                GetComponent<Collider>().enabled = false;
            }
        }
    }
}
