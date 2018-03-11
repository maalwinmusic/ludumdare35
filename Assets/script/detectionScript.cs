using UnityEngine;
using System.Collections;

public class detectionScript : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "obstacle") {
			GameObject.Find ("gameOver").GetComponent<gameOverScript> ().GameOver ();
		}
	}
}