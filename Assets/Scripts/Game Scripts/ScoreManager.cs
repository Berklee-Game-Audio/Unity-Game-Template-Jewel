using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	//public int scoreMaster;
	internal TextMesh scoreText;

	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}


	// Use this for initialization
	void Start () {
		scoreText = GameObject.Find("Score Text Permanent").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetScore(int score){
		scoreText.text = score.ToString();

	}

	public void GameOver(){
		GameObject go = GameObject.Find ("Score Text Permanent");
		go.transform.position = new Vector3(0.8f, 0.1f, -4.49f);

	}

	public void GamePlay(){
		GameObject go = GameObject.Find ("Score Text Permanent");
		go.transform.position = new Vector3(2.59f, -5.12f, -4.49f);

	}
}
