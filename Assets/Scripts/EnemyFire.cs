using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 목표: 특정 시간에 한번씩 총알을 만들고 플레이어를 향해 발사한다.
// 필요속성: 총알, 현재시간, 특정시간, 플레이어, 플레이어방향

public class EnemyFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gunPos;
    float currentTime;
    public float createTime = 1;
    GameObject player;
    Vector3 playerDir;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            currentTime += Time.deltaTime;

            if (currentTime > createTime)
            {
                //총알만들기
                GameObject bulletGO = Instantiate(bullet);
                bulletGO.transform.position = gunPos.transform.position;

                //플레이어위치로 발사
                playerDir = (player.transform.position - transform.position).normalized;
                bulletGO.GetComponent<Bullet>().dir = playerDir;

                //현재시간초기화
                currentTime = 0;
            }
        }
        
    }
}
