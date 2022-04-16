using System;
using UnityEngine;

public class WrongDirection : MonoBehaviour
{
   public FinishController finishController;
   [SerializeField] private Transform carTransform;
   private readonly Vector3 _carTarget = new Vector3(-6.66f, 1.14f, 17.24f);
   private Collider _collider;

   private void Start()
   {
      _collider = GetComponent<Collider>();
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.name.Equals("Car"))
      {
         carTransform.position = _carTarget;
      }
   }

   private void Update()
   {
      if (finishController.Count == 3)
         _collider.enabled = false;
   }
}
