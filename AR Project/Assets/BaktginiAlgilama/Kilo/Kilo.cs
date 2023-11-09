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
       kiloOutput.text = ((Convert.ToInt32(kiloInput.text)/9.81f) * katsay�).ToString()+" KG";
    }

}
