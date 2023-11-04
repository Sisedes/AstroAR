using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightFilter : MonoBehaviour
{
    public GameObject filter;
    public GameObject[] filterButtons;

    private void Start()
    {
        filter.gameObject.SetActive(false);
        filterButtons[1].SetActive(false);
    }

    public void FilterOn()
    {
        filter.gameObject.SetActive(true);

        filterButtons[0].SetActive(false);
        filterButtons[1].SetActive(true);

    }

    public void FilterOff()
    {
        filter.gameObject.SetActive(false);

        filterButtons[0].SetActive(true);
        filterButtons[1].SetActive(false);
    }
}
