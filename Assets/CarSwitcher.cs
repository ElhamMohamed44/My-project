using UnityEngine;

public class CarSwitcher : MonoBehaviour
{
    public GameObject mercedes;
    public GameObject mclaren;

    public void ShowMercedes()
    {
        mercedes.SetActive(true);
        mclaren.SetActive(false);
    }

    public void ShowMcLaren()
    {
        mercedes.SetActive(false);
        mclaren.SetActive(true);
    }
}
