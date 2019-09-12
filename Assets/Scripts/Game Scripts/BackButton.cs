using UnityEngine;
using System.Collections;

public class BackButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	
	void OnMouseDown () 
    {
		GameObject go = GameObject.Find("Score Text Permanent");
		ScoreManager scoreManager = (ScoreManager) go.GetComponent(typeof(ScoreManager));
		scoreManager.GamePlay();
		AkSoundEngine.PostEvent ("mx_main_menu", GameObject.Find ("WwiseGlobal"));
		Application.LoadLevel(1);
	
	}
}
