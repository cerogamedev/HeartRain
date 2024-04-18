using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoSingleton<InputHandler>
{
    public InputManage playerInput;

    public bool GoLeft;
    public bool GoRight;
    private void Awake()
    {
        playerInput = new InputManage();
        playerInput.BasicMovement.Enable();
    }

    void Update()
    {
        GoLeft = playerInput.BasicMovement.GoLeft.WasPressedThisFrame();
        GoRight = playerInput.BasicMovement.GoRight.WasPressedThisFrame();
    }
}
