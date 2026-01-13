using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float offset = -7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CamPosition = transform.position; 
        CamPosition.z = playerTransform.position.z + offset;
        transform.position = CamPosition;
    }
}
