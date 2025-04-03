using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject newsWindow;

    public void LoadScene(string sceneName)
    {
        //It's worth looking at the documentation to see the different ways you load a scene
        //Don't forget to drag and drop your scenes into File > Build Settings
        //https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //https://docs.unity3d.com/ScriptReference/Application.Quit.html
        Application.Quit();
    }

    public void openWhatsNew()
    {
        newsWindow.SetActive(true);
    } 

    public void closeWhatsNew()
    {
        newsWindow.SetActive(false);
    }
}
