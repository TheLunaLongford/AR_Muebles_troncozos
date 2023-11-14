using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class plane_detection : MonoBehaviour
{
    public ARPlaneManager planeManager;

    private void Start()
    {
        if (planeManager == null) planeManager = FindAnyObjectByType<ARPlaneManager>();
        if (planeManager != null) planeManager.planesChanged += onPlanesChanged;
    }

    void onPlanesChanged(ARPlanesChangedEventArgs eventArgs)
    {
        foreach (var plane in eventArgs.added)
        {
            TogglePlaneVis(plane, true);
        }

        foreach (var plane in eventArgs.updated)
        {
            TogglePlaneVis(plane, true);
        }

        foreach (var plane in eventArgs.removed)
        {
            TogglePlaneVis(plane, false);
        }
    }

    void TogglePlaneVis(ARPlane plane, bool shouldShow)
    {
        plane.gameObject.SetActive(shouldShow);
    }


}