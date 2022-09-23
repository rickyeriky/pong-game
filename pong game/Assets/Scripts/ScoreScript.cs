using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public int player1Score = 0;
    public int player2Score = 0;
    public Text p1Text;
    public Text p2text;

    public void AddP1Score()
    {
        player1Score++;
        p1Text.text = player1Score.ToString();
    }
    public void AddP2Score()
    {
        player2Score++;
        p2text.text = player2Score.ToString();
    }
}