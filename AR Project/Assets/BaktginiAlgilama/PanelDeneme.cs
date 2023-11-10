using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeneme : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject nightpanel;

    private void Update()
    {
        if(nightpanel==null)
        nightpanel = GameObject.FindGameObjectWithTag("nightpanel");
    }
    public void earthpanel() 
    {
        closeAllPanels();
        panels[0].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void moon()
    {
        closeAllPanels();
        panels[2].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void ceres()
    {
        closeAllPanels();
        panels[3].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void mars()
    {
        closeAllPanels();
        panels[1].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void sun()
    {
        closeAllPanels();
        panels[9].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void jupiter()
    {
        closeAllPanels();
        panels[4].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void mercury()
    {
        closeAllPanels();
        panels[5].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void neptune()
    {
        closeAllPanels();
        panels[6].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void pluto()
    {
        closeAllPanels();
        panels[7].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void saturn()
    {
        closeAllPanels();
        panels[8].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void uranus()
    {
        closeAllPanels();
        panels[10].SetActive(false);
        nightpanel.SetActive(true);
    }
    public void venus()
    {
        closeAllPanels();
        panels[11].SetActive(false);
        nightpanel.SetActive(true);
    }

    void closeAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }
}
