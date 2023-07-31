using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   public bool isAnsweringQuestion = false;
   public bool loadNextQuestion;
   public float fillFraction;
   float timerValue;
   [SerializeField] float timeToCompleteQuestion = 30f;
   [SerializeField] float timeToShowCurrentAnwer = 10f;

     public void CancelTimer()
     {
        timerValue = 0;
     }

    
    void Update()
    {
        UpdateTimer();
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        { 
            if (timerValue >0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }

           else 
          {
            timerValue = timeToShowCurrentAnwer;
            isAnsweringQuestion = false;
            
          }
        } else
        {
             if (timerValue >0)
             {
                fillFraction = timerValue / timeToShowCurrentAnwer;
             }
            else 
            {
                timerValue = timeToCompleteQuestion;
                isAnsweringQuestion = true;
                loadNextQuestion = true;

            }
        }

        

        //Debug.Log(isAnsweringQuestion + ":" + timerValue + "=" + fillFraction);
    }
}
