using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 7f;

    CharacterController cc;

    float gravity = -20f;
    float yVelocity = 0;

    public float jumpPower = 1f;
    public bool isJumping = false;

    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        //방향키
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;

        dir = Camera.main.transform.TransformDirection(dir);

        transform.position += dir * moveSpeed * Time.deltaTime;

         //점프
        if (Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }
        if (isJumping && cc.collisionFlags == CollisionFlags.Below)
        {
            isJumping = false;
            yVelocity = 0;
        }
        if (Input.GetButtonDown("Jump") && isJumping)
        {
            yVelocity = jumpPower;
            isJumping = true;
        }
        //중력
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime);

       
    }
}
