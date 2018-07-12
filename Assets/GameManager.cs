using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour {
    public Question[] question;
    private static List<Question> unansweredQuestions;
    private Question currentQuestions;
    void Start()
    {
     /*   if(unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions == question.ToList<Question>();
        }
        GetRandomQuestion();*/
    }
    void GetRandomQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestions = unansweredQuestions[randomQuestionIndex];
        unansweredQuestions.RemoveAt(randomQuestionIndex);
    }
}
