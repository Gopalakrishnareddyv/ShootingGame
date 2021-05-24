using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //print("i got hit");
        if (collision.gameObject.name=="Enemy")
        {
            print("i hit the enemy");
        }
    }
}