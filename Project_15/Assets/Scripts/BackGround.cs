using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    //�����͸���
    public Material bgMaterial;
    //��ũ�Ѽӵ�
    public float scrollSpeed = 0.2f;

    void Start()
    {
        
    }

    void Update()
    {
        // 1. ��� �ִ� ���� ��� �ϰ� �ʹ�.
        void Update()
        {
            //2. ������ �ʿ��ϴ�.
            Vector2 direction = Vector2.up;
            //3. ��ũ���� �ϰ� �ʹ�. P = P0 + vt
            bgMaterial.mainTextureOffset += direction * scrollSpeed * Time.deltaTime;
        }
    }
}
