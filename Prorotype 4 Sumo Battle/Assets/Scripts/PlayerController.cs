using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject focalPoint;

    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        //powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5, 0);

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("PowerUp"))
        {
            //hasPowerUp = true;
            Debug.Log("");
            StartCoroutine(PowerUpCountDown());
           // powerUpIndicator.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Rigidbody
        }
    }

    IEnumerator PowerUpCountDown()
    {
        yield return new WaitForSeconds(7);
        //hasPowerUp = false;
        //powerUpIndicator.gameObject.SetActive(false);
    }
}

