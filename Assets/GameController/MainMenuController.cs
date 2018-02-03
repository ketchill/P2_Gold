using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha0)) {
			SceneManager.LoadScene ("TestingPlace");

		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {

		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {

		}
	}
}
