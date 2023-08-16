using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// ��ǥ: ����� �Է�(Space)�� �޾� �Ѿ��� ����� �ʹ�.
// ����1: �Է��� �ް� �ʹ�.
// ����2: �Ѿ��� ����� �ʹ�.

// ��ǥ2: �������� �Ծ��ٸ�, ��ų ������ �ö󰣴�.
// �Ӽ�: ��ų����
// �ܰ�1. �������� �Ծ��ٸ�
// �ܰ�2. ��ų������ 1 �ö󰣴�.
// �ܰ�3. �������� �ı��Ѵ�.
// �ܰ�4. ������ ����Ʈ�� �����Ѵ�.

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;
    public int skillLevel = 0;
    int degree = 15;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExecuteSkill();
        }
    }

    private void ExecuteSkill()
    {
        switch (skillLevel)
        {
            case 0:
                ExecuteSkill0();
                break;
            case 1:
                ExecuteSkill1();
                break;
            case 2:
                ExecuteSkill2();
                break;
            case 3:
                ExecuteSkill3();
                break;
        }
        void ExecuteSkill0()
        {
            //�Ѿ� 1��
            GameObject bulletGO = Instantiate(bullet);
            bulletGO.transform.position = gunPos.transform.position;
        }
        void ExecuteSkill1()
        {
            //�Ѿ� 2��
            GameObject bulletGO = Instantiate(bullet);
            GameObject bulletGO1 = Instantiate(bullet);
            bulletGO.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO1.transform.position = gunPos.transform.position + new Vector3(0.2f, 0, 0);
        }
        void ExecuteSkill2()
        {
            //3����
            GameObject bulletGO = Instantiate(bullet);
            bulletGO.transform.position = gunPos.transform.position;

            GameObject bulletGO2 = Instantiate(bullet);
            GameObject bulletGO3 = Instantiate(bullet);

            bulletGO2.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO2.transform.rotation = Quaternion.Euler(0, 0, degree);
            bulletGO2.GetComponent<Bullet>().dir = bulletGO2.transform.up;

            bulletGO3.transform.position = gunPos.transform.position + new Vector3(0.2f, 0, 0);
            bulletGO3.transform.rotation = Quaternion.Euler(0, 0, -degree);
            bulletGO3.GetComponent<Bullet>().dir = bulletGO3.transform.up;
        }
        void ExecuteSkill3()
        {
            for (int i = 0; i < 24; i++)
            {
                GameObject bulletGO = Instantiate(bullet);
                bulletGO.transform.position = gunPos.transform.position;
                bulletGO.transform.rotation = Quaternion.Euler(0, 0, degree * i);
                bulletGO.GetComponent<Bullet>().dir = bulletGO.transform.up;
            }

        }

    }

}
