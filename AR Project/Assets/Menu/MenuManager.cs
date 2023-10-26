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
}
