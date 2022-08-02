using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetoerManager : MonoBehaviour
{
    float currentTime;
    // �����ð�
    public float createTime = 1;
    // �� ����
    public GameObject meteorFactory;
    // �ּҽð�
    float minTime = 1;
    // �ִ�ð�
    float maxTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        // �¾ �� �� �����ð��� �����ϰ�
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        // 2. ���� ����ð��� �����ð��� �Ǹ�
        if (currentTime > createTime)
        {
            // 3. �� ���忡�� ���� �����ؼ�
            GameObject enemy = Instantiate(meteorFactory);
            // �� ��ġ�� ���� ���� �ʹ�.
            enemy.transform.position = transform.position;

            currentTime = 0;

            // ���� ������ �� �� �����ð��� �ٽ� �����ϰ� �ʹ�.
            createTime = UnityEngine.Random.Range(minTime, maxTime);

        }
    }
}
