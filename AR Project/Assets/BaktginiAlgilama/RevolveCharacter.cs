using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolveCharacter : MonoBehaviour
{
    Vector3 rotate;
    void Start()
    {
        rotate = transform.rotation.eulerAngles;
    }



    private bool rotateRight = false;
    private bool rotateLeft = false;

    public void OnRightButtonDown()
    {
        rotateRight = true;
    }

    public void OnRightButtonUp()
    {
        rotateRight = false;
    }

    public void OnLeftButtonDown()
    {
        rotateLeft = true;
    }

    public void OnLeftButtonUp()
    {
        rotateLeft = false;
    }

    private void Update()
    {
        if (rotateRight)
        {
            transform.Rotate(Vector3.up * 50 * Time.deltaTime);
        }
        else if (rotateLeft)
        {
            transform.Rotate(Vector3.down * 50 * Time.deltaTime);
        }
    }
    public void closePanel()
    {
        transform.rotation = Quaternion.Euler(rotate);
    }
}
