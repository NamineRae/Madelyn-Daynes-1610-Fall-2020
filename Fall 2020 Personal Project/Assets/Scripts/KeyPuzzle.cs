using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyPuzzle : MonoBehaviour
{
    public IntData keyData;

    public GameObject keyDoor;

    public bool haveKey;

    public UnityEvent keyEvent;
    // Start is called before the first frame update
    void Start()
    {
        //key = GameObject.Find("Key");
        //keyDoor = GameObject.Find("Key Door");
    }
    
  
    private void OnTriggerEnter(Collider other)
    {
        keyEvent.Invoke(); 
        //destroy key and set state to enable destruction of door
        /*if (other.gameObject.CompareTag("Key"))
        {
            Destroy(gameObject); 
            haveKey = true;
        } 
       
        //destroy door if you have the key
        if (haveKey = true)
        {
            Destroy(keyDoor);
        }*/
    }

    //destroy door if you have the key
   /* void Update()
    {
        if (other.gameObject.CompareTag("Key Door") && haveKey = true)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (collider.tag == "Key Door" && haveKey = true)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (haveKey = true)
        {
            Destroy.GameObject(keyDoor);
            haveKey = false;
        }
    }*/
}
