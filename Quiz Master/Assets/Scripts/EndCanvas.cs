using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EndCanvas : MonoBehaviour
{

    ScoreKeeper scoreKeeper;
    [SerializeField] TextMeshProUGUI endText;
    

   
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        DisplayScore();
    }

     public void DisplayScore()
    {
        endText.text = "Congratulions! \n Your score: " + scoreKeeper.CalculateScore() + "%";


    }

  
}
