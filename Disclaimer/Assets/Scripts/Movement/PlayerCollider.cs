using UnityEngine;
using System.Collections;

public class PlayerCollider : MonoBehaviour {

	private bool isEnter_AngryWords;
	private bool isLightOn_AngryWords;
	
	private bool isEnter_Level4;
	private bool isEnter_Level5;
	
	public Light point02;

	public LevelControl levelControl;
	
	public GameObject spoint01;

	//Object for collision Dectrction
	public GameObject lv01_trigger;
	public GameObject lv03_floor;
	public GameObject lv04_floor;
	public GameObject lv05_floor;


	
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
		if (col.gameObject == lv03_floor) {
			if (!isEnter_AngryWords) {
				isLightOn_AngryWords = true;
				isEnter_AngryWords = true;
			}
		}

		if (col.gameObject == lv04_floor) {
			if (!isEnter_Level4) {
				levelControl.setLevel(4);
				isEnter_Level4 = true;
			}
		}

		if (col.gameObject == lv05_floor) {
			if (!isEnter_Level5) {
				levelControl.setLevel(5);
				isEnter_Level5 = true;
			}
		}

		if (col.gameObject == lv01_trigger) { //Teleport
			this.transform.position = new Vector3(spoint01.transform.position.x, spoint01.transform.position.y, spoint01.transform.position.z);
		}

	}
}
