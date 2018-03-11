using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lastScorer : MonoBehaviour {

	void Start()
	{
		//set text to display last highscore
		this.gameObject.GetComponent<Text> ().text = ddol.lastHighScore.ToString ();
	}

}
//stop looking through my code you stalker. I know I missspelled the name of this class, but I don't have time to care... I did have time however to write this.. #priorities