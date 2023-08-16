using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ��ǥ: Ư�� �ð��� �ѹ��� �Ѿ��� ����� �÷��̾ ���� �߻��Ѵ�.
// �ʿ�Ӽ�: �Ѿ�, ����ð�, Ư���ð�, �÷��̾�, �÷��̾����

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
                //�Ѿ˸����
                GameObject bulletGO = Instantiate(bullet);
                bulletGO.transform.position = gunPos.transform.position;

                //�÷��̾���ġ�� �߻�
                playerDir = (player.transform.position - transform.position).normalized;
                bulletGO.GetComponent<Bullet>().dir = playerDir;

                //����ð��ʱ�ȭ
                currentTime = 0;
            }
        }
        
    }
}
