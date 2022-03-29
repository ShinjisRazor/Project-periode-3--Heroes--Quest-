using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKREMovement : MonoBehaviour
{
    public Vector3 v3;
    public float speed;
    public Rigidbody rb;
    public Vector3 jumpPower;
    public int maxJump;
    public int jumpCount;
    // Start is called before the first frame update
    void Start()
    {
        speed += 10;
    }

    // Update is called once per frame
    void Update()
    {
        v3.x = Input.GetAxis("Horizontal");
        transform.Translate(v3 * Time.deltaTime * speed);


        if (Input.GetButtonDown("Jump"))
        {
            if (jumpCount < maxJump)
            {
                rb.velocity += jumpPower;
                jumpCount++;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpCount = 0;
    }
}
