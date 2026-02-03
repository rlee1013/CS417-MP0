using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    public InputActionProperty action;
    bool atVantage = false;
    public Vector3 vantagePos = new Vector3(0, 0, -100);
    private Vector3 homePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        homePos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (action.action.WasPressedThisFrame())
        {
            atVantage = !atVantage;
            transform.position = atVantage ? vantagePos : homePos;
        }
    }
}
