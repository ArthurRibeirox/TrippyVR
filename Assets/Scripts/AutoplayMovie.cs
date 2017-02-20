using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoplayMovie : MonoBehaviour {

	void Awake () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
	}
}
