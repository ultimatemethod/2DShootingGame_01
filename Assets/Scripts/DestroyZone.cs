using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    // 충돌 직전
    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.tag == "Player")
        {
            return;
        }
        Destroy(other.gameObject);      
    }
}
