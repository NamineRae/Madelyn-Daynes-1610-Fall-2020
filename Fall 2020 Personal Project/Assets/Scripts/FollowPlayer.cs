﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(00, 18, -8);
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        //get camera to follow player
        transform.position = player.transform.position + offset;
        //make camera rotate with player
        transform.rotation = player.transform.rotation;
    }
}
