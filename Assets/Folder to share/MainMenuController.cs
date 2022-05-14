using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    
    [Header("place in canvas on your main menu scene")]
    [Header("")]
    
    public FMODUnity.EventReference clickSoundPlaceEventHere;
    private FMOD.Studio.EventInstance clickSoundInstance;
    public int sceneIndexToLoad;

    private void Start()
    {
        clickSoundInstance = FMODUnity.RuntimeManager.CreateInstance(clickSoundPlaceEventHere);
    }
    
    
    
    public void StartGame()
    {
        clickSoundInstance.start();
        SceneManager.LoadSceneAsync(sceneIndexToLoad);
    }

    public void ExitGame()
    {   
        clickSoundInstance.start();
        Application.Quit();
    }
}
