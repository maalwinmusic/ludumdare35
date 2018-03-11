using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOverScript : MonoBehaviour {

	public GameObject gameOverText;
	public GameObject backgroundmusic;
	public GameObject highscoreSound;

	private bool hasPlayedHighScore;

	private bool isGameOver;

	void Update()
	{
		if (isGameOver) {
			if (Input.GetKeyDown (KeyCode.Escape)) {
				SceneManager.LoadScene (1);
			} else if (Input.anyKeyDown) {
				SceneManager.LoadScene (2);
			}
		}
		if (highScore.score > GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore && !hasPlayedHighScore) {
			highscoreSound.GetComponent<AudioSource> ().Play ();
			hasPlayedHighScore = !hasPlayedHighScore;
		}
	}

	//this is run when game is over
	public void GameOver()
	{
		//set last high score to current score
		ddol.lastHighScore = highScore.score;
		highScore.canCount = false;
		cubeSwitch.play = false;
		gameOverText.SetActive (true);
		backgroundmusic.GetComponent<AudioSource> ().Stop ();
		this.gameObject.GetComponent<AudioSource> ().Play ();
		if (highScore.score > GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore) {
			GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore = highScore.score;
			highscoreSound.GetComponent<AudioSource> ().Play ();
		}
		/*
		if (highScore.score > PlayerPrefs.GetInt ("highscore", 0)) {
			PlayerPrefs.SetInt ("highscore", highScore.score);
			highscoreSound.GetComponent<AudioSource> ().Play ();
		}
		*/
		isGameOver = true;
	}
}