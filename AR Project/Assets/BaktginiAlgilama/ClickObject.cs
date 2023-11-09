using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour
{
    public GameObject cube;

    const float speed = 6f;
    public GameObject aa;

    private bool isInfoOpen = false;
    
    void Update()
    {
        if (cube == null)
        {
            cube = GameObject.FindGameObjectWithTag("Planet");
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hehe;

                if (Physics.Raycast(ray, out hehe, 100))
                {
                    cube = hehe.transform.gameObject;
                    Debug.Log(hehe.transform.gameObject.name);
                }

                if (cube == GetClickedObject(out RaycastHit hit))
                {
                    if (!isInfoOpen)
                    {
                        OpenInfo();
                        isInfoOpen = true;
                    }
                    else
                    {
                        isInfoOpen = false;
                    }

                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                if(!isInfoOpen)
                CloseInfo();
            }
        }

    }



    GameObject GetClickedObject(out RaycastHit hit)

    {

        GameObject target = null;

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))

        {

            if (!isPointerOverUIObject()) { target = hit.collider.gameObject; }

        }

        return target;

    }

    private bool isPointerOverUIObject()

    {

        PointerEventData ped = new PointerEventData(EventSystem.current);

        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        List<RaycastResult> results = new List<RaycastResult>();

        EventSystem.current.RaycastAll(ped, results);

        return results.Count > 0;

    }

     void OpenInfo()
    {
        aa.SetActive(true);
    }
     void CloseInfo()
    {
    }

}
