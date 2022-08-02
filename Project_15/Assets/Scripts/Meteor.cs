using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{

    public float speed = 5;
    Vector3 dir;


    void Update()
    {
        // 1. ������ ���Ѵ�.
        Vector3 dir = Vector3.down;
        // 2. �̵��ϰ� �ʹ�. ���� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other)
    {
        // ���װ�
        Destroy(other.gameObject);
        // ������
        Destroy(gameObject);
    }
}
