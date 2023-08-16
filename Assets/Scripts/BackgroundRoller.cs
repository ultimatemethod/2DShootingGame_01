using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRoller : MonoBehaviour
{
    // �Ӽ�: ����ð�, �ӵ�
    float currentTime;
    public float speed = 1;
    public Material material;

    // Update is called once per frame
    void Update()
    {
        currentTime += speed * Time.deltaTime;
        material.mainTextureOffset = Vector3.up * currentTime;

    }
}
