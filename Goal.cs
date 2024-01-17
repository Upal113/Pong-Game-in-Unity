using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;
    //Detect Trigger
    private void OnTriggerEnter2D(Collider2D target)
    {
        // Check which player collided the Ball into Goal
        if (target.gameObject.CompareTag("Ball"))
        {
            // Update Players' Scores
            if(!isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored ......");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                Debug.Log("Player 1 Scored ......");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}
