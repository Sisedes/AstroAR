using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickObject : MonoBehaviour
{
    public GameObject cube;

    [Header("MessageBox")]
    [SerializeField] GameObject[] allSectionGO;
    [SerializeField] Transform SectionInfo;
    Vector3 desiredScale = Vector3.zero;
    const float speed = 6f;

    public Transform[] allSectionInfos;

    private bool isInfoOpen = false;
    private void Start()
    {
        foreach (var hehe in allSectionInfos)
        {
            hehe.localScale = Vector3.Lerp(hehe.localScale, Vector3.zero, Time.deltaTime * speed);
        }
    }
    
    void Update()
    {
        if (cube == null)
        {
            cube = GameObject.FindGameObjectWithTag("Planet");
        }
        if (SectionInfo == null)
        {
            SectionInfo = GameObject.FindGameObjectWithTag("sectionInfo").transform;
            allSectionGO = GameObject.FindGameObjectsWithTag("sectionInfo");
            for(int i=0; i < allSectionGO.Length; i++)
            {
                allSectionInfos[i] = allSectionGO[i].transform;
            }
        }

        //MessageBox shits
        SectionInfo.localScale = Vector3.Lerp(SectionInfo.localScale, desiredScale, Time.deltaTime * speed);

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
                    SectionInfo = hehe.transform.GetChild(0);
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
        desiredScale = Vector3.one;
    }
     void CloseInfo()
    {
        desiredScale = Vector3.zero;
    }

}
