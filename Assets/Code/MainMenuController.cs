using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{

    public int sceneIndex;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
