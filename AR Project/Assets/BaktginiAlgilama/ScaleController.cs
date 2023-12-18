using UnityEngine;

public class ScaleController : MonoBehaviour
{
    public GameObject targetObject;
    public float scaleFactor = 0.5f; 
    public float minScale = 1f; 
    public float maxScale = 10f; 

    private void Start()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("gezegenler");
        }
    }

    private void Update()
    {
        if (targetObject == null)
        {
            targetObject = GameObject.FindGameObjectWithTag("gezegenler");
        }
    }
    public void IncreaseScale()
    {
        Vector3 newScale = targetObject.transform.localScale + Vector3.one * scaleFactor;

        newScale = ClampScale(newScale);

        targetObject.transform.localScale = newScale;
    }

    public void DecreaseScale()
    {
        Vector3 newScale = targetObject.transform.localScale - Vector3.one * scaleFactor;

        newScale = ClampScale(newScale);

        targetObject.transform.localScale = newScale;
    }

    private Vector3 ClampScale(Vector3 scale)
    {
        scale.x = Mathf.Clamp(scale.x, minScale, maxScale);
        scale.y = Mathf.Clamp(scale.y, minScale, maxScale);
        scale.z = Mathf.Clamp(scale.z, minScale, maxScale);

        return scale;
    }
}
