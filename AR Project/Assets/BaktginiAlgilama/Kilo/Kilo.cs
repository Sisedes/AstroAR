using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kilo : MonoBehaviour
{
    public TMP_InputField kiloInput;
    public TextMeshProUGUI kiloOutput;
    public float katsay�;

    private void Update()
    {
        if(!string.IsNullOrEmpty(kiloInput.text))
        {
            float x= ((Convert.ToInt32(kiloInput.text) / 9.81f) * katsay�);
            x = Mathf.Round(x);
            kiloOutput.text = x.ToString();
        }
    }

}
