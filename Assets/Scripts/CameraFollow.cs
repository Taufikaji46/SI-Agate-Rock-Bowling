using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;        //Public variable to store a reference to the player game object
    public RockControl rock;
    public RockControl rock2;
    public RockControl rock3;
    private Vector3 offset;            //Private variable to store the offset distance between the player and camera
    private Vector3 startCamPosition;
    private Quaternion startCamRotation;
    public float camTime = 0.5f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField]
    private float z_offset = -47f;

    [SerializeField]
    private float xCamRotate = 20f;

    // Use this for initialization
    void Awake()
    {
        //ambil posisi awal camera
        startCamPosition = transform.position;
        startCamRotation = transform.rotation;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        if (transform.position.z < z_offset)
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            Vector3 desiredPosition = player.transform.position + offset;
            transform.rotation = Quaternion.Euler(xCamRotate, player.transform.rotation.y, startCamRotation.z);
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, camTime);
        }
                
        else if(rock.isResetting == true || rock2.isResetting == true || rock3.isResetting == true)
        {
            transform.position = startCamPosition;
            transform.rotation = startCamRotation;
        }

    }
}
