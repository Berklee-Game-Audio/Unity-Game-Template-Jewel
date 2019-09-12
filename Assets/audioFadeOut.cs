using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;

public class audioFadeOut : MonoBehaviour {

	public string sceneName = "";
	public bool fadingStarted = false;
	public AudioSource audio;


	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}


	// Use this for initialization
	void Start () 
	{
		audio = GetComponent<AudioSource>();
		sceneName = Application.loadedLevelName;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(sceneName != Application.loadedLevelName && !fadingStarted){
			Debug.Log ("Audio FadeOut() Part 1");
			fadingStarted = true;
			StartCoroutine(FadeOut());
		}
	}
		

	public IEnumerator FadeOut () 
	{
		Debug.Log ("Audio FadeOut() Part 2");
		float startVolume = audio.volume;

		while (audio.volume > 0) {
			audio.volume -= startVolume * Time.deltaTime / 3.0f;

			yield return null;
		}

		audio.Stop ();
		//audioSource.volume = startVolume;
		Destroy(this.gameObject);
	}
}
