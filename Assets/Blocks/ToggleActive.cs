using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleActive : MonoBehaviour {

	private Color prevColor;

	void Start() {
		prevColor = GetComponent<MeshRenderer> ().material.color;
	}

	public void ToggleActives(bool Active) {
		if (!Active) {
			GetComponent<MeshRenderer> ().material.color = new Color (1f, 1f, 1f, 0f);
		} else {
			GetComponent<MeshRenderer> ().material.color = prevColor;

		}
		GetComponent<BoxCollider> ().enabled = Active;
	}
}
