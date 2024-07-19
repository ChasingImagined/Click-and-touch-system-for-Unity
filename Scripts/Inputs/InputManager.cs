using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    InputMouse inputMouse;
    InputTouch InputTouch;
    private void Awake()
    {
        inputMouse = new InputMouse();
        InputTouch = new InputTouch();
    }
    private void Update()
    {
        inputMouse.RunInput();
        InputTouch.RunInput();
    }
}
