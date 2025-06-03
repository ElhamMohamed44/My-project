using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnPlane : MonoBehaviour
{
    [Header("Car Selection")]
    public GameObject[] carPrefabs;         // Assign your car prefabs here in the Inspector
    public int selectedCarIndex = 0;        // Which car to spawn (from UI button)

    private GameObject spawnedCar;          // Holds the currently placed car
    private ARRaycastManager raycastManager;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        // Only allow one car placement
        if (spawnedCar != null)
            return;

        // Wait for user tap
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;

            // Raycast to detected plane
            if (raycastManager.Raycast(touchPosition, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;

                // Spawn selected car
                spawnedCar = Instantiate(carPrefabs[selectedCarIndex], hitPose.position, hitPose.rotation);
            }
        }
    }

    // Called by UI Button to switch car before placement
    public void SelectCar(int index)
    {
        selectedCarIndex = index;
    }
}
