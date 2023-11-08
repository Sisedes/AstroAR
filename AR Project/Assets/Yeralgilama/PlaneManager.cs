using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class PlaneManager : MonoBehaviour
{
    [SerializeField] private ARPlaneManager aRPlaneManager;
    [SerializeField] private GameObject model3DPrefab;
    private List<ARPlane> planes = new List<ARPlane>();
    private GameObject model3DPlaced;
    ARRaycastManager m_RaycastManager;

    Vector3 fixedPosition;
    void Awake()
    {
        m_RaycastManager = GetComponent<ARRaycastManager>();

       
    }

    private void OnEnable()
    {
        aRPlaneManager.planesChanged += PlanesFound;
    }
    private void OnDisable()
    {
        aRPlaneManager.planesChanged += PlanesFound;
    }

    private void PlanesFound(ARPlanesChangedEventArgs planeData)
    {
        if (planeData.added != null && planeData.added.Count > 0)
        {

            planes.AddRange(planeData.added);
        }
        foreach(var plane in planes)
        {
            if (model3DPlaced == null )
            {
                if (TryGetTouchPosition(out Vector2 touchPosition))
                {
                    List<ARRaycastHit> hits = new List<ARRaycastHit>();
                    if (m_RaycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
                    {
                        // Dokunulan yere raycast baþarýlý oldu
                        ARRaycastHit hit = hits[0];
                        Pose hitPose = hit.pose;
                        Vector3 newPosition = hitPose.position + new Vector3(10f, 1f, 10f);
                        model3DPlaced = Instantiate(model3DPrefab, newPosition, hitPose.rotation);

                        float scaleFactor = 1.5f; // Örneðin modeli orijinal boyutunun 1.5 katý yapar
                        model3DPlaced.transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);

                        fixedPosition = newPosition;
                        // model3DPlaced'ý da güncelleyebilirsiniz
                        StopPlaneDetection();
                    }
                }
            }
            else
            {
                // Sabit konumu belirlediðiniz noktada olacak þekilde güncelleyin
                model3DPlaced.transform.position = fixedPosition;
            }

        }
    }

    public void StopPlaneDetection()
    {
        aRPlaneManager.requestedDetectionMode = PlaneDetectionMode.None;
        foreach (var plane in planes)
        {
            plane.gameObject.SetActive(false);
        }
    }

    bool TryGetTouchPosition(out Vector2 touchPosition)
    {
        if (Input.touchCount > 0)
        {
            touchPosition = Input.GetTouch(0).position;
            return true;
        }

        touchPosition = default;
        return false;
    }

}
