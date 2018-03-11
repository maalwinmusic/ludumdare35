using UnityEngine;
using System.Collections;

public class cameraColor : MonoBehaviour {
	
	public Color a;
	public Color b;
	private float t = 0;
	public float duration = 5;

	private bool flip;

	void Update () {
		if (flip) {
			this.gameObject.GetComponent<Camera> ().backgroundColor = Color.Lerp (a, b, t);
		} else {
			this.gameObject.GetComponent<Camera> ().backgroundColor = Color.Lerp (b, a, t);
		}
		if (t < 1) {
			t += Time.deltaTime / duration;
		} else {
			t = 0;
			flip = !flip;
		}
	}
}