using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;
    public Vector3 v3;
    public float distance;
    public float height;

    // Update is called once per frame
    void Update()
    {
        v3.x = player.position.x;
        v3.z = distance;
        v3.y = height;
        transform.position = v3;
    }
}
