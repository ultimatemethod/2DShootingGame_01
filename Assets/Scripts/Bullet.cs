using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1.0f;
    public Vector3 dir = Vector3.up;
    public GameObject bulletExplosion;

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * speed * Time.deltaTime;
    }

    //Bullet 충돌처리(Player에 대한)
    //Enemy 충돌처리는 enemy script에서 처리
    private void OnCollisionEnter(Collision otherObject)
    {        
        if (otherObject.gameObject.tag == "Player")
        {
            GameObject player = GameObject.Find("Player");
            if (player != null)
            {
                player.GetComponent<PlayerMove>().hp--;
                if (player.GetComponent<PlayerMove>().hp < 0)
                {
                    // 부딪힌 상대를 파괴한다.
                    Destroy(otherObject.gameObject);

                    // 목표10: 플레이어 파괴시 최고 점수를 BestScoreUI와 플팻폼 레지스트리에 저장한다.
                    //GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

                    //gameManager.bestScore = gameManager.attackScore + gameManager.destroyScore;
                    //gameManager.bestScoreTxt.text = gameManager.bestScore.ToString();

                    //PlayerPrefs.SetInt("Best Score", gameManager.bestScore);
                }
            }
        }
        Destroy(gameObject);
    }
}
