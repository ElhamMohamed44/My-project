using UnityEngine;

public class CarCustomizer : MonoBehaviour
{
    [Header("Body Color Settings")]
    public Renderer bodyRenderer;
    public Material[] bodyMaterials;
    private int currentBodyIndex = 0;

    [Header("Wheel Color Settings")]
    public Renderer[] wheelRenderers;
    public Material[] wheelMaterials;
    private int currentWheelIndex = 0;

    // 🔘 Call from UI Button to cycle body color
    public void ChangeBodyColor()
    {
        if (bodyMaterials.Length == 0 || bodyRenderer == null) return;

        currentBodyIndex = (currentBodyIndex + 1) % bodyMaterials.Length;
        bodyRenderer.material = bodyMaterials[currentBodyIndex];
    }

    // 🔘 Call from UI Button to cycle wheel color
    public void ChangeWheelColor()
    {
        if (wheelMaterials.Length == 0 || wheelRenderers.Length == 0) return;

        currentWheelIndex = (currentWheelIndex + 1) % wheelMaterials.Length;
        foreach (Renderer r in wheelRenderers)
        {
            r.material = wheelMaterials[currentWheelIndex];
        }
    }
}
