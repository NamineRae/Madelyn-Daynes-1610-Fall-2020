using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 30;
    public float verticalInput;
    public float horizontalInput;
    void Update()
    {
        //get user's input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        //move player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //Make player turn
        transform.Rotate(Vector3.left, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
