using UnityEngine;

public class ground : MonoBehaviour
{
    public AudioSource groundAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   /* void Start()
    {
        groundAudio.Pause();
    }*/

    // Update is called once per frame
   public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            groundAudio.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            groundAudio.Pause();
        }
    }




}
