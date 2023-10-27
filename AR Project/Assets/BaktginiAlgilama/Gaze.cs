using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour
{
   public List<InfoBehaviour> infos=new List<InfoBehaviour>();
    private void Start()
    {
        infos=FindObjectsOfType<InfoBehaviour>().ToList();
    }
    private void Update()
    {
        if(Physics.Raycast(transform.position,transform.forward,out RaycastHit hit))
        {
            GameObject hehe = hit.collider.gameObject;
            if(hehe.CompareTag("hasInfo"))
            {
                OpenInfo(hehe.GetComponent<InfoBehaviour>());
            }
        }
        else
        {
            CloseAll();
        }
    }

    void OpenInfo(InfoBehaviour desiredInfo)
    {
        foreach(InfoBehaviour info in infos)
        {
            if(info==desiredInfo)
                info.OpenInfo();
            else
                info.CloseInfo();
        }
    }

    void CloseAll()
    {
        foreach (InfoBehaviour info in infos)
        {
            info.CloseInfo();
        }
    }
}