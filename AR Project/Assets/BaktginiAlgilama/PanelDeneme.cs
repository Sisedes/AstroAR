using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeneme : MonoBehaviour
{
    public GameObject[] panels;
    public void earthpanel() 
    {
        panels[0].SetActive(true);

    }
    public void closeEarthpane()
    {
        panels[0].SetActive(false);

    }
}
