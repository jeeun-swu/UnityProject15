using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    public float speed = 5;
    Vector3 dir;


    void Update()
    {
        // 1. 방향을 구한다.
        Vector3 dir = Vector3.down;
        // 2. 이동하고 싶다. 공식 P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        // 너죽고
        Destroy(other.gameObject);
        // 나죽자
        Destroy(gameObject);
    }
}
