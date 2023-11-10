using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public int correctanswerIndex;
    public int wronganswerCount;
    public GameObject correctPanel, wrongpanel;
    // Start is called before the first frame update
    public Question[] questions;
    public TextMeshProUGUI questionText;
    public TextMeshProUGUI[] buttonTexts;

    int currentQuestion = 0;
    public int currentLevel;
    public Button nextButton;

    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;

    public Button buttonRenk;

     Color colorRed;
     Color colorGreen;
    public Color colorBlue;

  
    public TextMeshProUGUI aciklamaText;

    public GameObject panelObject;
    public GameObject panelBitti;

    public Button testBitir;

    void Start()
    {
       
        testBitir.interactable = false;
        Color colorRed=Color.red;
     Color colorGreen=Color.green;
     Color colorBlue= buttonRenk.image.color;

        panelBitti.SetActive(false);


        nextButton.interactable = false;
        panelObject.SetActive(false);
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
   

    void SetQuestion()
    {
        Color renk1 = new Color();
        renk1.r = 0.745f;
        renk1.g = 0.855f;
        renk1.b = 0.906f;
        renk1.a = 1f;

        
        buttonB.image.color = renk1;

        buttonA.image.color = renk1;

        buttonC.image.color = renk1;

        buttonD.image.color = renk1;


        int questionIndex = currentQuestion%questions.Length;
        questionText.text = questions[currentLevel].questionText;
        aciklamaText.text = questions[currentLevel].bilgiText;
        for (int i = 0; i < buttonTexts.Length; i++)
        {
            buttonTexts[i].text = questions[currentLevel].answers[i];
        }
        correctanswerIndex = questions[currentLevel].correctAnswerIndex;
        currentLevel++;
        nextButton.interactable = false;    
    }

    public void AnswerButton(int answerIndex)
    {
        if(answerIndex== correctanswerIndex) {
       // correctPanel.gameObject.SetActive(true);
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            PlayerPrefs.Save();
             nextButton.interactable = true;
            
            if(answerIndex==1)
            {
                buttonB.image.color= Color.green;
            }if(answerIndex == 0)
            {
                buttonA.image.color= Color.green;
            }if(answerIndex == 2)
            {
                buttonC.image.color= Color.green;
            }if(answerIndex == 3)
            {
                buttonD.image.color= Color.green;
            }
            
        }
        else
        {
            if (correctanswerIndex == 1)
            {
                buttonB.image.color = Color.green;
            }
            if (correctanswerIndex == 0)
            {
                buttonA.image.color = Color.green;
            }
            if (correctanswerIndex == 2)
            {
                buttonC.image.color = Color.green;
            }
            if (correctanswerIndex == 3)
            {
                buttonD.image.color = Color.green;
            }
            ////
            if (answerIndex == 1)
            {
                buttonB.image.color = Color.red;
            }
            if (answerIndex == 0)
            {
                buttonA.image.color = Color.red;
            }
            if (answerIndex == 2)
            {
                buttonC.image.color = Color.red;
            }
            if (answerIndex == 3)
            {
                buttonD.image.color = Color.red;
            }
            wrongpanel.gameObject.SetActive(true);
          
            
        }
        if (currentLevel != 30)
        {
            nextButton.interactable = true;
        }
        else
        {
            testBitir.interactable = true;
            nextButton.interactable = false;
            currentLevel = 0;
            PlayerPrefs.SetInt("currentLevel", currentLevel);
            PlayerPrefs.Save();
        }
        panelObject.SetActive(true);
    }
    public void PanelButton(bool isTrue)
    {
        if(isTrue)
        {
           // correctPanel.gameObject.SetActive(false);
            SetQuestion();
            panelObject.SetActive(false);
            if (currentLevel==30) {
                nextButton.interactable = false;
               // testBitir.gameObject.SetActive(true);
                

            }
        }
        else
        {
           // wrongpanel.gameObject.SetActive(false);
        }
    }

    public void PanelKapat()
    {
        wrongpanel.SetActive(false);

    }
    public void QuizBitir()
    {
        panelObject.SetActive(false);
        panelBitti.SetActive(true);

    } 
   


}
