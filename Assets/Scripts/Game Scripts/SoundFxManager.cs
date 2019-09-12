using UnityEngine;
using System.Collections;

public class SoundFxManager : MonoBehaviour 
{
    internal static SoundFxManager instance;

    public AudioSource wrongTapSound;
    public AudioSource objectPickSound;
    public AudioSource whopSound;
    public AudioSource tickSound;
    public AudioSource electricZapSound;
    public AudioSource wrongMoveSound;
    public AudioSource columnFallSound;

    public AudioSource []objectFall;

    void Awake()
    {
        instance = this;
    }

    bool playFallingSound = false;

    void Start()
    {
        InvokeRepeating("CheckForFallingSound", .1f, .5f);
		Debug.Log("The loaded level name is: " + Application.loadedLevelName);
		//AkSoundEngine.PostEvent ("mx_start_game", GameObject.Find ("WwiseGlobal"));
    }

    void CheckForFallingSound()
    {
        if (playFallingSound)
        {
            objectFall[Random.Range(0, 3)].Play();
        }
    }

    internal void PlayLevelAdvanceSound()
    {
       
    }

    internal void PlayFallingSound()
    {
        playFallingSound = true;
		AkSoundEngine.PostEvent ("sfx_tile_drop", GameObject.Find ("WwiseGlobal"));
    }

    internal void StopFallingSound()
    {
        playFallingSound = false;
    }

    internal void PlayLevelClearSound()
    {
       
    }

    internal void PlayLevelFailSound()
    {
       
    }
   
}
