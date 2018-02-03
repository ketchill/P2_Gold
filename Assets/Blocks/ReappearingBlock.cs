using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReappearingBlock : MonoBehaviour {
	public float maxTime = 1.0f;

	private bool away = false;
	private float time = 1.0f;

	void OnBecameVisible() {
		Debug.Log ("Visible");
		time = maxTime;
		away = false;
	}

	void OnBecameInvisible() {
		Debug.Log ("InVisible");
		StartCoroutine (ResetAfterTime ());
	}

	IEnumerator ResetAfterTime() {
		away = true;
		while (away) {
			time -= Time.deltaTime;
			if (time <= 0f) {
				GetComponent<ToggleActive> ().ToggleActives (false);
			}
			yield return null;
		}
	}


}
