using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendScorer : MonoBehaviour
{
    int EnemyOneScoreValue = 1;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print(collision.gameObject.tag);
            Scorer scorer = FindObjectOfType<Scorer>();
            scorer.ScoreCalculator(EnemyOneScoreValue);
            //Destroy(collision.gameObject, 2.0f);
            //collision.gameObject.SetActive(false);
        }
        
    }
}
