using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void LoadMarkerlessScene() => SceneManager.LoadScene("MarkerlessAR");
    public void LoadMarkerBasedScene() => SceneManager.LoadScene("MarkerBasedAR");
}
