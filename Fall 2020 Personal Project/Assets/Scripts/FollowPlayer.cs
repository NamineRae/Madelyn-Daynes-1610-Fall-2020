using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        //get camera to follow player
        transform.position = Player().transform.position;
    }
}
