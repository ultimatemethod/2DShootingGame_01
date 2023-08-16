using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// 목표: 사용자 입력(Space)를 받아 총알을 만들고 싶다.
// 순서1: 입력을 받고 싶다.
// 순서2: 총알을 만들고 싶다.

// 목표2: 아이템을 먹었다면, 스킬 레벨이 올라간다.
// 속성: 스킬레벨
// 단계1. 아이템을 먹었다면
// 단계2. 스킬레벨이 1 올라간다.
// 단계3. 아이템을 파괴한다.
// 단계4. 아이템 이펙트를 생성한다.

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
            //총알 1개
            GameObject bulletGO = Instantiate(bullet);
            bulletGO.transform.position = gunPos.transform.position;
        }
        void ExecuteSkill1()
        {
            //총알 2개
            GameObject bulletGO = Instantiate(bullet);
            GameObject bulletGO1 = Instantiate(bullet);
            bulletGO.transform.position = gunPos.transform.position + new Vector3(-0.2f, 0, 0);
            bulletGO1.transform.position = gunPos.transform.position + new Vector3(0.2f, 0, 0);
        }
        void ExecuteSkill2()
        {
            //3방향
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
