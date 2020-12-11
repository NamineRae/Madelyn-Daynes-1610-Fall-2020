using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject); // destroy particle when clicked on
        //whoops this was the destroy after two seconds script
    }

    private void OnMouseDown()
    {
        
    }
}
