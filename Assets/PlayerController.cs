using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControl _playerControl;

    // Start is called before the first frame update
    void Start()
    {
        _playerControl = new PlayerControl();
        _playerControl.Enable();

        _playerControl.Char.Fire.started += FireStart;
        _playerControl.Char.Fire.performed += FirePerform;
        _playerControl.Char.Fire.canceled += FireCancel;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = _playerControl.Char.Move.ReadValue<Vector2>();
        //Debug.Log(move);

        if (_playerControl.Char.Jump.triggered)
        {
            Debug.Log("Jump");
        }
    }

    private void FireStart(InputAction.CallbackContext context)
    {
        Debug.Log("FireStart");
    }

    private void FirePerform(InputAction.CallbackContext context)
    {
        Debug.Log("FirePerform");
    }

    private void FireCancel(InputAction.CallbackContext context)
    {
        Debug.Log("FireCancel");
    }
}
