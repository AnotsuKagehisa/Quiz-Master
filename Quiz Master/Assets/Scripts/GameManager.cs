using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Quiz quiz;
    EndCanvas endCanvas;

    void Awake()
    {
         quiz = FindObjectOfType<Quiz>();
        endCanvas = FindObjectOfType<EndCanvas>();
    }

    void Start()
    {
       

        quiz.gameObject.SetActive(true);
        endCanvas.gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (quiz.isComplete)
        {
            quiz.gameObject.SetActive(false);
            endCanvas.gameObject.SetActive(true);
            endCanvas.DisplayScore();
        }
    }

    public void  OnReplayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
