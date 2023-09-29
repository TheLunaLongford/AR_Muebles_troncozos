using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class floor_placement : MonoBehaviour
{
    public ARRaycastManager ray_cast_manager;
    public GameObject object_to_place;

    private void Update()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == UnityEngine.TouchPhase.Began)
        {
            Debug.Log("Detecte un toque");
            // Ray cast hacia el piso mediante la camara
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            List<ARRaycastHit> hits = new List<ARRaycastHit>();

            // Detectar el plano
            if(ray_cast_manager.Raycast(ray, hits, TrackableType.Planes))
            {
                Debug.Log("Detecte un plano");
                // Obtener el plano detectado
                Pose hit_pose = hits[0].pose;

                // Colocar el Game Object (mueble)
                Instantiate(object_to_place, hit_pose.position, hit_pose.rotation);
            }
        }
    }
}
