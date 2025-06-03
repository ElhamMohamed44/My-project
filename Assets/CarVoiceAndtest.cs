using UnityEngine;
using UnityEngine.UI;

public class CarVoiceAndText : MonoBehaviour
{
    public AudioSource voiceOver;
    public GameObject descriptionText; // Assign the Text GameObject here

    public void PlayVoiceOver()
    {
        if (!voiceOver.isPlaying)
        {
            voiceOver.Play();
            descriptionText.SetActive(true); // Show the text
            Invoke("HideText", 5f); // Hide after 5 seconds
        }
    }

    void HideText()
    {
        descriptionText.SetActive(false);
    }
}