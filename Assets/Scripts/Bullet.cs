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

    //Bullet �浹ó��(Player�� ����)
    //Enemy �浹ó���� enemy script���� ó��
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
                    // �ε��� ��븦 �ı��Ѵ�.
                    Destroy(otherObject.gameObject);

                    // ��ǥ10: �÷��̾� �ı��� �ְ� ������ BestScoreUI�� ������ ������Ʈ���� �����Ѵ�.
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
