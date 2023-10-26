using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBehaviour:MonoBehaviour
{
    [SerializeField] Transform SectionInfo;
    Vector3 desiredScale = Vector3.zero;
    const float speed = 6f;
    void Start()
    {
        
    }

    void Update()
    {
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale,desiredScale, Time.deltaTime*speed);
    }

    public void OpenInfo()
    {
        desiredScale=Vector3.one;
    }
    public void CloseInfo()
    {
        desiredScale=Vector3.zero;
    }
}
