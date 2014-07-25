using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	private bool isEnter_AngryWords;
	private bool isLightOn_AngryWords;
	
	public Light point02;

	
	// Use this for initialization
	void Start () {
		isEnter_AngryWords = false; //If collide the wall of angrywords
		isLightOn_AngryWords = false;

	}
	
	// Update is called once per frame
	void Update () {
		if (isLightOn_AngryWords) {
			if (point02.intensity < 4) {
				point02.intensity += 0.05f;
			} else {
				isLightOn_AngryWords = false;
			}
		}
	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.name == "Ground02") {
			if (!isEnter_AngryWords) {
				isLightOn_AngryWords = true;
				isEnter_AngryWords = true;
			}
		}
	}
}
