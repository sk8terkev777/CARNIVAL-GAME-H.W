using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeaction : MonoBehaviour {

	public float startTime = 5f;
	public float interval =2f;

	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > -startTime) {
			Debug.Log ("it works");
		}
	}
}
