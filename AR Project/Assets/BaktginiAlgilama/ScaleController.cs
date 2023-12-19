using System;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ScaleController : MonoBehaviour
{
    private bool buyuk = false;
    private bool kucuk = false;

    public GameObject targetObject;
    public float scaleFactor = 10f; 
    public float minScale = 1f; 
    public float maxScale = 1000f;


    private void Start()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("hehe");
        }
    }

    private void Update()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("hehe");
        }

        if (buyuk)
        {
            Vector3 newScale = targetObject.transform.localScale - Vector3.one * scaleFactor * Time.deltaTime;

            newScale = ClampScale(newScale);
            targetObject.transform.localScale = newScale;
        }
        else if (kucuk)
        {
            Vector3 newScale = targetObject.transform.localScale + Vector3.one * scaleFactor * Time.deltaTime;

            newScale = ClampScale(newScale);
            targetObject.transform.localScale = newScale;
        }
        
    }

    

    private Vector3 ClampScale(Vector3 scale)
    {
        scale.x = Mathf.Clamp(scale.x, minScale, maxScale);
        scale.y = Mathf.Clamp(scale.y, minScale, maxScale);
        scale.z = Mathf.Clamp(scale.z, minScale, maxScale);

        return scale;
    }

    public void ZoomInUp()
    {
        buyuk = true;
    }
    public void ZoomInDown()
    {
        buyuk = false;
    }
    public void ZoomOutUp()
    {
        kucuk = true;
    }
    public void ZoomOutDown()
    {
        kucuk = false;

    }
}
