using UnityEngine;

public class CarSwitcher : MonoBehaviour
{
    public GameObject[] cars;

    public void SelectCar(int index)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(i == index);
        }
    }
}
