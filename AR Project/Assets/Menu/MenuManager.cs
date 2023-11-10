using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Sahne1()
    {
        SceneManager.LoadScene(1);
    }
    public void Sahne2()
    {
        SceneManager.LoadScene(2);
    }
    public void Sahne3()
    {
        SceneManager.LoadScene(3);
    }

    public void Kapat()
    {
        Application.Quit();
    }

    public void quizKapat()
    {
        SceneManager.LoadScene(0);  
    }
}
