using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    int p1Score = 0, p2Score = 0;

    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text = p1Score.ToString() + " - " + p2Score.ToString();
    }

    public void P1Scored(){ p1Score++; }
    public void P2Scored() { p2Score++; }
}