using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickDisappearingBlock : MonoBehaviour {
	void OnBecameInvisible() {
		Debug.Log ("InVisible");
		gameObject.SetActive (true);
	}
}
