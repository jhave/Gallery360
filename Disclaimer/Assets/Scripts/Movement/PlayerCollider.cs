using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	private bool isEnter_AngryWords;
	private bool isLightOn_AngryWords;
	
	private bool isEnter_Level4;
	private bool isEnter_Level5;
	
	public Light point02;

	public LevelControl levelControl;
	
	// Use this for initialization
	void Start () {
		isEnter_AngryWords = false; //If collide the wall of angrywords
		isLightOn_AngryWords = false;

		isEnter_Level4 = false;
		isEnter_Level5 = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isLightOn_AngryWords) {
			if (point02.intensity < 4) {
				point02.intensity += 0.05f;
			} else {
				levelControl.setLevel(3);
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

		if (col.gameObject.name == "Plane_loop_360_1") {
			if (!isEnter_Level4) {
				levelControl.setLevel(4);
				isEnter_Level4 = true;
			}
		}

		if (col.gameObject.name == "Plane_loop_360_2") {
			if (!isEnter_Level5) {
				levelControl.setLevel(5);
				isEnter_Level5 = true;
			}
		}
	}
}
