using UnityEngine;
using System.Collections;

public class obstacleScript : MonoBehaviour {

	[SerializeField]
	private int obstacleCount;

	[SerializeField]
	private archive archive;

	private static int inARow = 0;

	void OnTriggerEnter(Collider other) {
		if (cubeSwitch.play) {
			if (other.gameObject.tag == "shape-pad") {
				highScore.score += (100 * other.gameObject.GetComponent<cubeSwitch> ().cubeCount);
				highScore.score -= (100 * (obstacleCount - other.gameObject.GetComponent<cubeSwitch> ().cubeCount));
				if (highScore.score < 0) {
					highScore.score = 0;
				}
				if (other.gameObject.GetComponent<cubeSwitch> ().cubeCount == obstacleCount) {
					//i had full pot
					highScore.score += 1000;
					inARow++;
					if (inARow == 10) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 10000;
						//play audio "EPIC"
					}
					if (inARow == 20) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 50000;
						//play audio "EPIC"
					}
					if (inARow == 30) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 100000;
						//play audio "EPIC"
					}
					if (inARow == 40) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 50) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 60) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 70) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 80) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 90) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
					if (inARow == 100) {
						highScore.scoreMultiplayer += 1;
						GameObject.Find ("lvlup").GetComponent<AudioSource> ().Play ();
						//highScore.score += 1000000;
						//play audio "EPIC"
					}
				} else {
					inARow = 0;
					highScore.scoreMultiplayer = 1;
				}
				int random = Random.Range (0, archive.obstacle.Count);
				Instantiate (archive.obstacle [random], new Vector3 (0, 0, this.gameObject.transform.position.z + 32), Quaternion.identity);
				Destroy (this.gameObject, 3f);

				/*
				if (other.gameObject.GetComponent<cubeSwitch> ().cubeCount == obstacleCount) {
					int random = Random.Range (0, archive.obstacle.Count);
					Instantiate (archive.obstacle [random], new Vector3 (0, 0, this.gameObject.transform.position.z + 32), Quaternion.identity);
					Destroy (this.gameObject, 3f);
				} else {
					GameObject.Find ("gameOver").GetComponent<gameOverScript> ().GameOver ();
				}
				*/
			}
		}
	}
}