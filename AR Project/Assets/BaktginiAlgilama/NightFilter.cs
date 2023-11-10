using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightFilter : MonoBehaviour
{
    public GameObject[] filterButtons;
    public GameObject filter;
    public Camera arCam;

    private void Start()
    {
        filterButtons[1].SetActive(false);
        filter.SetActive(false);
    }

    public void FilterOn()
    {

        filterButtons[0].SetActive(false);
        filterButtons[1].SetActive(true);
        filter.SetActive(true);
    }

    public void FilterOff()
    {

        filterButtons[0].SetActive(true);
        filterButtons[1].SetActive(false);
        filter.SetActive(false);
    }
}
