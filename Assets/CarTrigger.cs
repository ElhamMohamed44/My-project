using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    public GameObject carToShow;
    public GameObject carToHide;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera")) // XR camera
        {
            carToShow.SetActive(true);
            carToHide.SetActive(false);
        }
    }
}
