using UnityEngine;
using System.Collections;

public class LevelButton : MonoBehaviour {

    public int levelNo;

	void Start () 
    {
        transform.Find("Text").GetComponent<TextMesh>().text = name;
		//AkSoundEngine.PostEvent ("level_0" + levelNo, GameObject.Find ("WwiseGlobal"));
	
	}

    void OnMouseDown()
    {
		//AkSoundEngine.SetRTPCValue ("percentage_of_time_left", (timeRemaining / initialTimeRemaining) * 100.0f, GameObject.Find ("WwiseGlobal"));
		AkSoundEngine.PostEvent ("level_0" + levelNo, GameObject.Find ("WwiseGlobal"));
		Debug.Log ("AkSoundEngine.PostEvent: level_0" + levelNo);
		Application.LoadLevel(int.Parse(name)+1);
    }
}
