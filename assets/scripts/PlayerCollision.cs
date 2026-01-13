using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public ScoreScript scoreScript;
    public GameController gameController;
    public AudioSource AudioSource;
    public AudioSource gameover;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision obstacles)
    {
        if(obstacles.gameObject.tag=="Untagged")
        {
            gameover.Play();
            gameController.GameOver();
            playerScript.enabled = false;
            // Additional game over logic can be added here
        }
    }
    private void OnTriggerEnter(Collider obstacles)
    {
        if (obstacles.gameObject.tag == "collectable")
        {
            AudioSource.Play();
            scoreScript.AddScore(1);
            Destroy(obstacles.gameObject);
            // Additional game over logic can be added here
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "New tag")
        {
            gameover.Play();
            gameController.GameOver();
            playerScript.enabled = false;
        }
    }
  
}
