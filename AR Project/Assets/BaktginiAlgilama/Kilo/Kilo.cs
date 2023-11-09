using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Kilo : MonoBehaviour
{
    public TMP_InputField kiloInput;
    public TextMeshProUGUI kiloOutput;
    public float katsayý;

    private void Update()
    {
       kiloOutput.text = ((Convert.ToInt32(kiloInput.text)/9.81f) * katsayý).ToString()+" KG";
    }

}
