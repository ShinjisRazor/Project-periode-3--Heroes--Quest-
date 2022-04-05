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
    public Animator animator;
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

        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("attack2");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpCount = 0;
    }
}
