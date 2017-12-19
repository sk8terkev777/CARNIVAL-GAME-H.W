using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thrustAmount2 : MonoBehaviour {


	Rigidbody rb;
	public float thrustAmt2; 
	public AudioSource testSound;
	public AudioClip Theme;
	public GameObject Pin1;
	public GameObject Mii;
	public Vector3 startingPostion;
	public GameObject DestroyMe;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.AddForce (Vector3.forward * thrustAmt2);
			testSound.PlayOneShot (Theme, 0.7f);
		}

		if(Input.GetKey (KeyCode.DownArrow)){
			rb.AddForce (Vector3.back * thrustAmt2);

		}


		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (Vector3.left * thrustAmt2);
		}


		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (Vector3.right * thrustAmt2);
		}

	
		
	}
}
