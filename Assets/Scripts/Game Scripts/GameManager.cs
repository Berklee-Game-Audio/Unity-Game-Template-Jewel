using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{    
    public static GameManager instance;
    public GameObject[] playingObjectPrefabs;
    public GameObject[] horizontalPrefabs;
    public GameObject[] verticalPrefabs;
    public GameObject universalPlayingObjectPrefab;
    public GameObject []jellyPrefab;
	//public ScoreManager scoreManager;

    internal int numberOfColumns;
    internal int numberOfRows;
    public float gapBetweenObjects = .7f;
    public float swappingTime = .8f;
    public float objectFallingDuration = .5f;
    internal float initialObjectFallingDuration;
    internal bool isBusy = false;
    public int totalNoOfJellies = 0;

    public iTween.EaseType objectfallingEase;

    internal TextMesh scoreText;
    internal TextMesh jellyText;
	internal TextMesh timerText;
    int score;
	public float timeRemaining = 120.0f;
	float initialTimeRemaining;

    internal static int numberOfItemsPoppedInaRow = 0;
    

    void Awake()
    {
        instance = this;
    }

	void Start () 
    {
        scoreText = GameObject.Find("Score Text").GetComponent<TextMesh>();
        jellyText = GameObject.Find("Jelly Text").GetComponent<TextMesh>();
		timerText = GameObject.Find("Timer Text").GetComponent<TextMesh>();

        initialObjectFallingDuration = objectFallingDuration;
        numberOfColumns = LevelStructure.instance.numberOfColumns;
        numberOfRows = LevelStructure.instance.numberOfRows;
        numberOfItemsPoppedInaRow = 0;
        scoreText.text = "Score : " + score.ToString();
        jellyText.text = "Jelly : " + totalNoOfJellies.ToString();
		timerText.text = "Time Remaining : " + timeRemaining;

		initialTimeRemaining = timeRemaining;
	
	}

	void Update(){
		
		timeRemaining = timeRemaining - Time.deltaTime;
		timerText.text = "Time Remaining : " + (int)timeRemaining;

		AkSoundEngine.SetRTPCValue ("percentage_of_time_left", (timeRemaining / initialTimeRemaining) * 100.0f, GameObject.Find ("WwiseGlobal"));

		if (timeRemaining < 0.5) {
			GameObject go = GameObject.Find("Score Text Permanent");
			ScoreManager scoreManager = (ScoreManager) go.GetComponent(typeof(ScoreManager));
			scoreManager.GameOver();
			AkSoundEngine.PostEvent ("mx_game_end", GameObject.Find ("WwiseGlobal"));
			Application.LoadLevel(11);
		}

	}

    internal void AddScore()
    {
        int temp = 10 * numberOfItemsPoppedInaRow * (numberOfItemsPoppedInaRow / 5 + 1);
      //  print(temp);
        score += temp;
        scoreText.text = "Score : " + score.ToString();


		GameObject go = GameObject.Find("Score Text Permanent");
		ScoreManager scoreManager = (ScoreManager) go.GetComponent(typeof(ScoreManager));
		scoreManager.SetScore (score);
    }



   
}
