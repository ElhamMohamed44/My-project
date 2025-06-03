using UnityEngine;

public class BodyColorChanger : MonoBehaviour
{
    public Renderer bodyRenderer;         // Assign the car body mesh here
    public Material newBodyMaterial;      // Assign the new color material here

    public void ChangeBodyColor()
    {
        if (bodyRenderer != null && newBodyMaterial != null)
        {
            bodyRenderer.material = newBodyMaterial;
        }
    }
}
