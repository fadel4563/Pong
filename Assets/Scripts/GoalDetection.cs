using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoalDetection : MonoBehaviour
{

    [SerializeField] ScoreScript scoreScript;
    [SerializeField] GameManager gm;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            //PotoDroit
            if (gameObject.CompareTag("BorderR"))
            {
                print("Player 1 Score GOAAAAAAAAAAAAAL");
                scoreScript.P1Scored();
                Destroy(collision.gameObject);
                gm.SpawnObject();
            }
            else
            {
                print("Player 2 Score GOAAAAAAAAAAAAAL");
                scoreScript.P2Scored();
                Destroy(collision.gameObject);
                gm.SpawnObject();
            }
        }
    }
}
