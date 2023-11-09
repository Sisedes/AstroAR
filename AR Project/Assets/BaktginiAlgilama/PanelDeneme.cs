using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeneme : MonoBehaviour
{
    public GameObject[] panels;
    public void earthpanel() 
    {
        panels[0].SetActive(false);

    }
    public void moon()
    {
        panels[2].SetActive(false);
    }
    public void ceres()
    {
        panels[3].SetActive(false);
    }
    public void mars()
    {
        panels[1].SetActive(false);
    }
    public void sun()
    {
        panels[9].SetActive(false);
    }
    public void jupiter()
    {
        panels[4].SetActive(false);
    }
    public void mercury()
    {
        panels[5].SetActive(false);
    }
    public void neptune()
    {
        panels[6].SetActive(false);
    }
    public void pluto()
    {
        panels[7].SetActive(false);
    }
    public void saturn()
    {
        panels[8].SetActive(false);
    }
    public void uranus()
    {
        panels[10].SetActive(false);
    }
    public void venus()
    {
        panels[11].SetActive(false);
    }
}
