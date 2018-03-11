using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ddol : MonoBehaviour {

	public int currentHighScore;
	public static int lastHighScore;

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
		currentHighScore = PlayerPrefs.GetInt ("highscore", 0);
		SceneManager.LoadScene (1);
	}
}