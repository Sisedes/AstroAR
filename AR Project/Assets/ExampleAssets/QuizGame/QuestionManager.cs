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
    public int currentLevel;

    void Start()
    {
        if (PlayerPrefs.HasKey("currentLevel"))
        {
            currentLevel = PlayerPrefs.GetInt("currentLevel");
        }
        else
        {
            // Kayýtlý bir deðer yoksa varsayýlan deðeri kullanabilirsiniz.
            currentLevel= 0;
        }
        SetQuestion();
        
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetQuestion()
    {
        int questionIndex = currentQuestion%questions.Length;
        questionText.text = questions[currentLevel].questionText;
        for(int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = questions[currentLevel].answers[i];
        }
        correctanswerIndex = questions[currentLevel].correctAnswerIndex;
        currentLevel++;
       
    }

    public void AnswerButton(int answerIndex)
    {
        if(answerIndex== correctanswerIndex) {
        correctPanel.gameObject.SetActive(true);
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            PlayerPrefs.Save();
        }
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
