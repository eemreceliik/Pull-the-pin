using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{

    private bool _mouseDown;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_mouseDown)
        {
            SetPosition();
        }
    }

    private void SetPosition()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        var currentPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        _rigidbody.velocity = new Vector3(currentPosition.x, currentPosition.y, 0)*2;

    }
    private void OnMouseDown()
    {
        _mouseDown = true;
    }

    private void OnMouseUp()
    {
        _mouseDown = false;
    }
}

