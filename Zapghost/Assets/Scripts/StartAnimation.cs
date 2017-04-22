using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour {

	Defender df;

	void Awake() {
		df = GetComponent<Defender> ();
	}

	// Update is called once per frame
	void Update () {
		if (df.placed) {
			GetComponent<Animation> ().Play();
		}
	}
}
