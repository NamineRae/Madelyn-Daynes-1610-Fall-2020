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

    // Update is called once per frame
    void Update()
    {
        
    }

    //destroy key and set state to enable destruction of door
    private void OnCollisionEnter()
    {
        Destroy.GameObject(key);
        haveKey = true;
    }

    //destroy door if you have the key
    private void OnCollisionStay(Collision other)
    {
        if (haveKey = true)
        {
            Destroy.GameObject(keyDoor);
            haveKey = false;
        }
    }

}
