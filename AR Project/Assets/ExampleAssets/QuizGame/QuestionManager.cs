using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public int correctanswerIndex;
    public GameObject correctPanel, wrongpanel;
    // Start is called before the first frame update
    public Question[] questions;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI[] buttonTexts;

    int currentQuestion = 0;

    void Start()
    {
        SetQuestion();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetQuestion()
    {
        int questionIndex = currentQuestion%questions.Length;
        questionText.text = questions[questionIndex].questionText;
        for(int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = questions[questionIndex].answers[i];
        }
        correctanswerIndex = questions[questionIndex].correctAnswerIndex;
        currentQuestion++;
    }

    public void AnswerButton(int answerIndex)
    {
        if(answerIndex== correctanswerIndex) {
        correctPanel.gameObject.SetActive(true);}
        else
        {
            wrongpanel.gameObject.SetActive(true);
        }
    }
    public void PanelButton(bool isTrue)
    {
        if(isTrue)
        {
            correctPanel.gameObject.SetActive(false);
            SetQuestion();
        }
        else
        {
            wrongpanel.gameObject.SetActive(false);
        }
    }
}
