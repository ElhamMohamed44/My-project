using UnityEngine;

public class CarCustomizer : MonoBehaviour
{
    public Renderer carBody;
    public Material[] bodyMaterials;
    private int currentBodyIndex = 0;

    public Renderer[] wheels;
    public Material[] wheelMaterials;
    private int currentWheelIndex = 0;

    public void ChangeBodyColor()
    {
        currentBodyIndex = (currentBodyIndex + 1) % bodyMaterials.Length;
        carBody.material = bodyMaterials[currentBodyIndex];
    }

    public void ChangeWheelColor()
    {
        currentWheelIndex = (currentWheelIndex + 1) % wheelMaterials.Length;
        foreach (Renderer wheel in wheels)
        {
            wheel.material = wheelMaterials[currentWheelIndex];
        }
    }
}
