using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour {
	public GameObject winScreen;

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Player") {
			winScreen.SetActive (true);
		}
	}
}
