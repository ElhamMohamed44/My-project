using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MarkerTracker : MonoBehaviour
{
    public ARTrackedImageManager trackedImageManager;
    public GameObject[] carPrefabs;

    private Dictionary<string, GameObject> spawnedCars = new Dictionary<string, GameObject>();

    private void OnEnable()
    {
        trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    private void OnDisable()
    {
        trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
            SpawnOrUpdate(trackedImage);

        foreach (var trackedImage in args.updated)
            SpawnOrUpdate(trackedImage);
    }

    private void SpawnOrUpdate(ARTrackedImage trackedImage)
    {
        string name = trackedImage.referenceImage.name;

        if (!spawnedCars.ContainsKey(name))
        {
            foreach (var prefab in carPrefabs)
            {
                if (prefab.name == name)
                {
                    GameObject obj = Instantiate(prefab, trackedImage.transform.position, trackedImage.transform.rotation);
                    obj.transform.parent = trackedImage.transform;
                    spawnedCars[name] = obj;
                }
            }
        }
        else
        {
            GameObject obj = spawnedCars[name];
            obj.transform.position = trackedImage.transform.position;
            obj.transform.rotation = trackedImage.transform.rotation;
            obj.SetActive(trackedImage.trackingState == TrackingState.Tracking);
        }
    }
}
