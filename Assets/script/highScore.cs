using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class highScore : MonoBehaviour {

	public static int score = 0;
	public static int scoreMultiplayer = 1;
	public static bool canCount = false;
	public int currentNewHighscore = 0;

	public GameObject combo;

	public GameObject highscoreText;

	void Awake()
	{
		currentNewHighscore = GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore;
		highscoreText.GetComponent<Text> ().text = currentNewHighscore.ToString();
		score = 0;
	}

	void FixedUpdate()
	{
		if (canCount) {
			if (score >= GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore) {
				currentNewHighscore = score;
				highscoreText.GetComponent<Text> ().text = currentNewHighscore.ToString ();
			}
			score += scoreMultiplayer;
			this.gameObject.GetComponent<Text> ().text = score.ToString ();
			combo.GetComponent<Text> ().text = scoreMultiplayer.ToString ();
		}
	}
}