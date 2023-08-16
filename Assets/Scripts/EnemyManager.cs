using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    // �ʿ� �Ӽ�: Ư�� �ð�, ���� �ð�, �� GameObject
    // Ư���ð�
    float createTime;

    //����ð�
    float currentTime = 0;

    //�� ���ӿ�����Ʈ
    public GameObject enemy;

    // ������ �ð��� �ּ� �ִ밪
    public float minTime = 3;
    public float maxTime = 5;

    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        // ����1. ���� �ð��� �帥��.
        //currentTime = currentTime + Time.deltaTime;
        currentTime += Time.deltaTime;
        //print("currentTime: " + currentTime);

        // ����2. Ư���ð��� ������
        if (currentTime > createTime)
        {
            // ����3. ���� EnemyManager��ġ�� �����Ѵ�.
            GameObject enemyGO = Instantiate(enemy);
            enemyGO.transform.position = transform.position;

            // ����4. �ð��� �ʱ�ȭ ���ش�.
            currentTime = 0;
        }
    }
}
