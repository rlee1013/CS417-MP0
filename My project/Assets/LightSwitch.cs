using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Light roomLight;
    public InputActionProperty action;
    bool on = false;
    void Start()
    {
        action.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (action.action.WasPressedThisFrame())
        {
            on = !on;
            roomLight.color = on ? Color.red : Color.white;
        }
    }
}
