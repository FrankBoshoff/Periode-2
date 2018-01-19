using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public Rigidbody r;
    public Vector3 v;
    private int jumpAmount;
    public int allowedJumpAmount = 1;

    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        jumpAmount = allowedJumpAmount;
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && jumpAmount >= 1)
        {
            r.velocity = v;
            jumpAmount -= 1;
        }
    }
}