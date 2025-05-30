using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MarkerlessCarSpawner : MonoBehaviour
{
    public GameObject carPrefab;

    private GameObject spawnedCar;
    private ARRaycastManager raycastManager;
    private static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount == 0 || spawnedCar != null)
            return;

        Touch touch = Input.GetTouch(0);
        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose pose = hits[0].pose;
            spawnedCar = Instantiate(carPrefab, pose.position, pose.rotation);
        }
    }
}
