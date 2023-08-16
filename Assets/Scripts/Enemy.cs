using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.down;
    int randValue;
    GameObject player;

    int hp = 3;

    // Start is called before the first frame update
    void Start()
    {
        randValue = Random.Range(0, 10);
        player = GameObject.Find("Player"); // tag로 찾자
        
        // 랜덤 따라가기
        if (randValue < 5)
        {
            if (player != null)
            {
                dir = (player.transform.position - gameObject.transform.position).normalized;

            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    //Enemy 충돌처리 (Player, PlayerBullet)
    private void OnCollisionEnter(Collision otherObject)
    {
        hp--;
        if (otherObject.gameObject.tag == "Player")
        {            
            player.GetComponent<PlayerMove>().hp--;
            if (player.GetComponent<PlayerMove>().hp < 0)
            {
                Destroy(otherObject.gameObject);
            }
            Destroy(gameObject);
        }
        else if (hp < 0)
        {
            Destroy(otherObject.gameObject);
            Destroy(gameObject);
        }
    }

}
