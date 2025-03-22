using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class FollowCamera : MonoBehaviour
{
    public GameObject targetFollow;
    public Vector3 Distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetFollow.transform.position - Distance;
    }
}
