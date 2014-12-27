﻿using UnityEngine;
using System.Collections;

public class disparoScript : MonoBehaviour {


	
	public GameObject bala;
	public Transform puntoDeDisparo;
	
	
	void Update () {
		if (Input.GetKeyDown ("space")) {
		if (bala != null) {
			var clone = Instantiate(bala, puntoDeDisparo.position,
			                        Quaternion.identity) as GameObject;
			clone.transform.localScale = transform.localScale;
		} else {
			Debug.Log ("Sin balas") ;
		}
	}
}
}