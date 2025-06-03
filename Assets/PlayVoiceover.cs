using UnityEngine;

public class PlayVoiceover : MonoBehaviour
{
    public AudioSource voiceClip;

    public void PlayAudio()
    {
        if (voiceClip && !voiceClip.isPlaying)
        {
            voiceClip.Play();
        }
    }
}
