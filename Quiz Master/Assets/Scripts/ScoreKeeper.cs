using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int correctAnswers = 0;
    int questionSeen = 0;


    public int GetCorrectAnswers()
    {
        return correctAnswers;
    }

    public void IncreamentCorrectAnswer()
    {
        correctAnswers++;
    }

    public int GetQuestionSeen()
    {
        return questionSeen;
    }

    public void IncreamentQuestionSeen()
    {
        questionSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correctAnswers / (float)questionSeen * 100);
    }
}
