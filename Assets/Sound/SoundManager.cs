using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public FMODUnity.EventReference clickSoundPlaceEventHere;
    private FMOD.Studio.EventInstance clickSoundInstance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClickSound()
    {
        clickSoundInstance = FMODUnity.RuntimeManager.CreateInstance(clickSoundPlaceEventHere);
    }
}
