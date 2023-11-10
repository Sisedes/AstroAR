using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeneme : MonoBehaviour
{
    public GameObject[] panels;
    public void earthpanel() 
    {
        closeAllPanels();
        panels[0].SetActive(false);

    }
    public void moon()
    {
        closeAllPanels();
        panels[2].SetActive(false);
    }
    public void ceres()
    {
        closeAllPanels();
        panels[3].SetActive(false);
    }
    public void mars()
    {
        closeAllPanels();
        panels[1].SetActive(false);
    }
    public void sun()
    {
        closeAllPanels();
        panels[9].SetActive(false);
    }
    public void jupiter()
    {
        closeAllPanels();
        panels[4].SetActive(false);
    }
    public void mercury()
    {
        closeAllPanels();
        panels[5].SetActive(false);
    }
    public void neptune()
    {
        closeAllPanels();
        panels[6].SetActive(false);
    }
    public void pluto()
    {
        closeAllPanels();
        panels[7].SetActive(false);
    }
    public void saturn()
    {
        closeAllPanels();
        panels[8].SetActive(false);
    }
    public void uranus()
    {
        closeAllPanels();
        panels[10].SetActive(false);
    }
    public void venus()
    {
        closeAllPanels();
        panels[11].SetActive(false);
    }

    void closeAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }
}
