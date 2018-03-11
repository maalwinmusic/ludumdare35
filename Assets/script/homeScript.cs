using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class homeScript : MonoBehaviour {

	public GameObject highscoreObject;

	public GameObject saveMessage;

	//this method runs once when this object is spawned in
	void Awake()
	{
		Cursor.visible = true;
		highscoreObject.GetComponent<Text> ().text = GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore.ToString ();
		Invoke ("SaveHighScore", 5); //run this funcion once, in 5 seconds
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			Play ();
		}
	}


	void SaveHighScore()
	{
		saveMessage.SetActive (true);
		Invoke ("DisableSaveMessage", 5);
		Save ();
	}

	void DisableSaveMessage()
	{
		saveMessage.SetActive (false);
	}

	public void Play()
	{
		SceneManager.LoadScene (2);
	}

	public void Quit()
	{
		Application.Quit ();
	}

	public void ResetScore()
	{
		GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore = 0;
		SceneManager.LoadScene (1);
	}

	void OnApplicationQuit()
	{
		Save ();
	}

	void Save()
	{
		PlayerPrefs.SetInt ("highscore", GameObject.Find ("ddol").GetComponent<ddol> ().currentHighScore);
	}
}