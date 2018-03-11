using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class cubeSwitch : MonoBehaviour {

	[SerializeField]
	private List<GameObject> cubes = new List<GameObject>();

	[SerializeField]
	private float maxDistanceDelta;

	public int cubeCount;

	public static bool play;

	public GameObject gameOverObject;

	private void Awake()
	{
		Cursor.visible = false;
		play = true;
		cubeCount = 9;
	}

	private void Update()
	{
		if (play) {
			if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1)) {
				cubes [0].gameObject.SetActive (!cubes [0].gameObject.activeSelf); //either eneable or disalbe, we don't know
				if (cubes [0].gameObject.activeSelf) { //is this cube now enable??
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2)) {
				cubes [1].gameObject.SetActive (!cubes [1].gameObject.activeSelf);
				if (cubes [1].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad3) || Input.GetKeyDown (KeyCode.Alpha3)) {
				cubes [2].gameObject.SetActive (!cubes [2].gameObject.activeSelf);
				if (cubes [2].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad4) || Input.GetKeyDown (KeyCode.Alpha4)) {
				cubes [3].gameObject.SetActive (!cubes [3].gameObject.activeSelf);
				if (cubes [3].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad5) || Input.GetKeyDown (KeyCode.Alpha5)) {
				cubes [4].gameObject.SetActive (!cubes [4].gameObject.activeSelf);
				if (cubes [4].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad6) || Input.GetKeyDown (KeyCode.Alpha6)) {
				cubes [5].gameObject.SetActive (!cubes [5].gameObject.activeSelf);
				if (cubes [5].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad7) || Input.GetKeyDown (KeyCode.Alpha7)) {
				cubes [6].gameObject.SetActive (!cubes [6].gameObject.activeSelf);
				if (cubes [6].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad8) || Input.GetKeyDown (KeyCode.Alpha8)) {
				cubes [7].gameObject.SetActive (!cubes [7].gameObject.activeSelf);
				if (cubes [7].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
			if (Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown (KeyCode.Alpha9)) {
				cubes [8].gameObject.SetActive (!cubes [8].gameObject.activeSelf);
				if (cubes [8].gameObject.activeSelf) {
					cubeCount++;
				} else {
					cubeCount--;
				}
			}
		}
	}

	void FixedUpdate()
	{
		if (play) {
			this.gameObject.transform.position = Vector3.MoveTowards (this.gameObject.transform.position, new Vector3 (0, 0, this.gameObject.transform.position.z + 1), maxDistanceDelta);
		}
	}
}