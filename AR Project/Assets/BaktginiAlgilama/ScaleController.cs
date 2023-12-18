using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ScaleController : MonoBehaviour
{
    public GameObject arCameraManager;
    float fov = 60f;
    float maxFOV = 100f; 
    float minFOV = 0; 
    float sensitivity = 10f;

    private bool buyuk = false;
    private bool kucuk = false;

    private void Start()
    {
    }

    private void Update()
    {
        fov = arCameraManager.GetComponent<Camera>().fieldOfView;

        if (buyuk)
        {
            fov += sensitivity * Time.deltaTime;
            fov = Mathf.Clamp(fov, minFOV, maxFOV);
            arCameraManager.GetComponent<Camera>().fieldOfView = fov;
        }
        else if (kucuk)
        {
            fov -= sensitivity * Time.deltaTime;
            fov = Mathf.Clamp(fov, minFOV, maxFOV);
            arCameraManager.GetComponent<Camera>().fieldOfView = fov;
        }
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
