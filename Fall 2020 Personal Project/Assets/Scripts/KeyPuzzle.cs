using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPuzzle : MonoBehaviour
{
    public GameObject key;

    public GameObject keyDoor;

    public bool haveKey;
  
    // Start is called before the first frame update
    void Start()
    {
        //key = GameObject.Find("Key");
        //keyDoor = GameObject.Find("Key Door");
    }
    
  
    private void OnCollisionEnter(Collision other)
    {
        //destroy key and set state to enable destruction of door
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(gameObject); 
            haveKey = true;
        } 
       
        //destroy door if you have the key
        if (haveKey = true)
        {
            Destroy(keyDoor);
        }
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
