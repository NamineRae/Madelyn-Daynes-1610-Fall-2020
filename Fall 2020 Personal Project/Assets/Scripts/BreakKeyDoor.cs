using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BreakKeyDoor : MonoBehaviour
{
    public IntData keyNumber;
    public UnityEvent breakDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (keyNumber.value == 1)
        {
            breakDoor.Invoke();
        }
    }
}
