using UnityEngine;
using System.Collections;

public class startScore : MonoBehaviour {

	void OnTriggerEnter()
	{
		highScore.canCount = true;
	}
}