using UnityEngine;
using System.Collections;

public class SelfRotation : MonoBehaviour {

	public float rotationleft;
	public float rotationspeed;
	private bool reload;
	private int count;

	public GameObject loopw1;
	public GameObject loopw2;
	public GameObject loopw3;
	public GameObject loopw4;
	public GameObject loopw5;
	public GameObject loopw6;
	public GameObject loopw7;

	public bool isLeft;
	public bool isActive;



	// Use this for initialization
	void Start () {
		rotationspeed = 0;
		//rotationleft = 360;
		reload = true;
		count = 0;

		isActive = false;

		loopw1.SetActive (false);
		loopw2.SetActive (false);
		loopw3.SetActive (false);
		loopw4.SetActive (false);
		loopw5.SetActive (false);
		loopw6.SetActive (false);
		loopw7.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		//Quaternion newRotation = Quaternion.AngleAxis(90, Vector3.up);
		//transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, .05f); 

		if (isActive) {
			//Continously Rotate
			//transform.Rotate (0, Time.deltaTime * 400, 0); //Time.deltaTime * 400 //1s
			if (reload) {
				rotationspeed += 3;
				rotationleft = 360;
				if (count < 7)
					count ++;
				else
					count = 1;
				//Debug.Log("count: " + count);
				reload = false;
				switch (count) {
				case 1:
					loopw1.SetActive (true);
					loopw2.SetActive (false);
					loopw3.SetActive (false);
					loopw4.SetActive (false);
					loopw5.SetActive (false);
					loopw6.SetActive (false);
					loopw7.SetActive (false);
					rotationspeed = 3;
					break;
				case 2:
					loopw1.SetActive (false);
					loopw2.SetActive (true);
					loopw3.SetActive (false);
					loopw4.SetActive (false);
					loopw5.SetActive (false);
					loopw6.SetActive (false);
					loopw7.SetActive (false);
					break;
				case 3:
					loopw1.SetActive (false);
					loopw2.SetActive (false);
					loopw3.SetActive (true);
					loopw4.SetActive (false);
					loopw5.SetActive (false);
					loopw6.SetActive (false);
					loopw7.SetActive (false);
					break;
				case 4:
					loopw1.SetActive (false);
					loopw2.SetActive (false);
					loopw3.SetActive (false);
					loopw4.SetActive (true);
					loopw5.SetActive (false);
					loopw6.SetActive (false);
					loopw7.SetActive (false);
					break;
				case 5:
					loopw1.SetActive (false);
					loopw2.SetActive (false);
					loopw3.SetActive (false);
					loopw4.SetActive (false);
					loopw5.SetActive (true);
					loopw6.SetActive (false);
					loopw7.SetActive (false);
					break;
				case 6:
					loopw1.SetActive (false);
					loopw2.SetActive (false);
					loopw3.SetActive (false);
					loopw4.SetActive (false);
					loopw5.SetActive (false);
					loopw6.SetActive (true);
					loopw7.SetActive (false);
					break;
				case 7:
					loopw1.SetActive (false);
					loopw2.SetActive (false);
					loopw3.SetActive (false);
					loopw4.SetActive (false);
					loopw5.SetActive (false);
					loopw6.SetActive (false);
					loopw7.SetActive (true);
					break;
				}
			} else {
				selfRot ();
			}
		}
	}

	void selfRot() {
		float rotation = rotationspeed * 0.015f * 10;//Time.deltaTime * 10;
		//Debug.Log ("tdt: " + Time.deltaTime);
		
		if (rotationleft > 0) {
			rotationleft -= rotation;
		} else {
			rotationleft = 0;
			rotation = rotationleft;
			reload = true;
		}

		if (isLeft)
			transform.Rotate(0,rotation,0);
		else
			transform.Rotate(0,-rotation,0);

	}
}
