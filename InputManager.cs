using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class InputManager : MonoBehaviour
{
    public Action OnReportEvent;
    public void OnReport(InputValue value)
    {
        if (value.isPressed)
        {
            Debug.Log("Report");
            OnReportEvent?.Invoke();
        }
    }

    public Action OnDebugEvent;
    public void OnDebug(InputValue value)
    {
        Debug.Log("Debug");
        if (value.isPressed)
        {
            Debug.Log("Debug Pressed");
            OnDebugEvent?.Invoke();
        }
    }
}
