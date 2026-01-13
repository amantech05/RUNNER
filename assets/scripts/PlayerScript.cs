using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform transform;
    public Rigidbody rigidbody;
    public float speed = 10f;
    //public float speedIncreasePerPoint = 0.1f;
    public float forwardForce = 1000f;
    public float maxX = 4.45f;
    public float minX = -4.45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x, minX, maxX);
        transform.position = playerPosition;    

        
        /*  if (playerPosition.x > maxX)
          {
              transform.position = new Vector3(maxX, playerPosition.y, playerPosition.z);
          }
          if (playerPosition.x < minX)
          {
              transform.position = new Vector3(minX, playerPosition.y, playerPosition.z);
          }*/
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed*Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
    }
    private void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
    /*public void IncreaseSpeed()
    {
        speed += speedIncreaseAmount;
        forwardForce += 200f; // optional: increase forward speed too
        Debug.Log("Speed Increased! Current Speed: " + speed);
    }*/
}
