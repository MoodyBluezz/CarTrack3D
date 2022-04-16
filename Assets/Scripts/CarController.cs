using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carForce = 10;
    [SerializeField] private GameObject gameOverPanel;

    private Rigidbody _carRigidbody;

    private readonly LayerMask _layerMask = 6;

    private readonly Vector3 _rotationRight = new Vector3(0, 0, 1);
    private readonly Vector3 _rotationLeft = new Vector3(0, 0, -1);
    private readonly Vector3 _forward = new Vector3(-1, 0, 0);
    private readonly Vector3 _backward = new Vector3(1, 0, 0);
    private TextMeshProUGUI _gameCondition;

    public static bool IsGameFinished = false;

    private void Start()
    {
        IsGameFinished = false;
        _carRigidbody = GetComponent<Rigidbody>();
        _gameCondition = gameOverPanel.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void FixedUpdate()
    {
        CarControl();
        TrajectoryCheck();
    }

    private void CarControl()
    {
        if (IsGameFinished) return;
        if (Input.GetKey("w"))
            _carRigidbody.AddForce(_forward * carForce);
        
        if (Input.GetKey("s"))
            _carRigidbody.AddForce(_backward * carForce);

        if (Input.GetKey("d"))
            _carRigidbody.AddForce(_rotationRight * carForce);

        if (Input.GetKey("a"))
            _carRigidbody.AddForce(_rotationLeft * carForce);
    }

    private void TrajectoryCheck()
    {
        RaycastHit hit;
        if (!Physics.Raycast(transform.position, Vector3.down, out hit)) return;
        if (!hit.collider.gameObject.layer.Equals(_layerMask) || IsGameFinished) return;
        IsGameFinished = true;
        _gameCondition.text = "YOU LOSE!!!";
        gameOverPanel.SetActive(true);
    }
}
