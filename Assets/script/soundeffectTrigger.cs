using UnityEngine;
using System.Collections;

public class soundeffectTrigger : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		this.gameObject.GetComponent<AudioSource> ().Play ();
	}
}