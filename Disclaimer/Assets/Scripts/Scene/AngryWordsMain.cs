
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngryWordsMain : MonoBehaviour {
	
	public GameObject player;
	public Camera player_view;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
//		if (Input.GetMouseButtonDown (1) || UI_GamePadMapping.ButtonB_Pressed) {
//			//Debug.Log ("Pressed right click.");
//			Application.LoadLevel("Disclaimer");
//		}
	}

	void FixedUpdate() {
		//[Fail]?: Add gravity to player
		player.rigidbody.AddForce (Physics.gravity * player.rigidbody.mass);

		//Real Time attach player_view to Player instead of parent-child
		//To prevent roatation of the camera when the Player is falling
		player_view.transform.position = new Vector3 (player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z);

	}
}
