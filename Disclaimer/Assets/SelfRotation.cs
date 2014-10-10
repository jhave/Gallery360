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

	public TextMesh loopw1t1;
	public TextMesh loopw2t1;
	public TextMesh loopw2t2;
	public TextMesh loopw3t1;
	public TextMesh loopw3t2;
	public TextMesh loopw3t3;
	public TextMesh loopw4t1;
	public TextMesh loopw4t2;
	public TextMesh loopw4t3;
	public TextMesh loopw4t4;
	public TextMesh loopw5t1;
	public TextMesh loopw5t2;
	public TextMesh loopw5t3;
	public TextMesh loopw5t4;
	public TextMesh loopw5t5;
	public TextMesh loopw6t1;
	public TextMesh loopw6t2;
	public TextMesh loopw6t3;
	public TextMesh loopw6t4;
	public TextMesh loopw6t5;
	public TextMesh loopw6t6;
	public TextMesh loopw7t1;
	public TextMesh loopw7t2;
	public TextMesh loopw7t3;
	public TextMesh loopw7t4;
	public TextMesh loopw7t5;
	public TextMesh loopw7t6;
	public TextMesh loopw7t7;

	// Use this for initialization
	void Start () {
		rotationspeed = 0;
		//rotationleft = 360;
		reload = true;
		count = 0;


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

				if (!isLeft)
					this.audio.Play();

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

	public void clearTextField() {
		loopw1t1.text = "";
		loopw2t1.text = "";
		loopw2t2.text = "";
		loopw3t1.text = "";
		loopw3t2.text = "";
		loopw3t3.text = "";
		loopw4t1.text = "";
		loopw4t2.text = "";
		loopw4t3.text = "";
		loopw4t4.text = "";
		loopw5t1.text = "";
		loopw5t2.text = "";
		loopw5t3.text = "";
		loopw5t4.text = "";
		loopw5t5.text = "";
		loopw6t1.text = "";
		loopw6t2.text = "";
		loopw6t3.text = "";
		loopw6t4.text = "";
		loopw6t5.text = "";
		loopw6t6.text = "";
		loopw7t1.text = "";
		loopw7t2.text = "";
		loopw7t3.text = "";
		loopw7t4.text = "";
		loopw7t5.text = "";
		loopw7t6.text = "";
		loopw7t7.text = "";
	}

	public void addTextField() {
		string tempName = this.gameObject.name;
		string tempCode = tempName.Substring (tempName.Length - 2, 2);

		loopw1t1.text = (tempCode == "cn") ? "一壹" : "one";
		loopw2t1.text = (tempCode == "cn") ? "二貳" : "two-sec";
		loopw2t2.text = loopw2t1.text;
		loopw3t1.text = (tempCode == "cn") ? "三參" : "three-third";
		loopw3t2.text = loopw3t1.text;
		loopw3t3.text = loopw3t1.text;
		loopw4t1.text = (tempCode == "cn") ? "四肆" : "four-fourth";
		loopw4t2.text = loopw4t1.text;
		loopw4t3.text = loopw4t1.text;
		loopw4t4.text = loopw4t1.text;
		loopw5t1.text = (tempCode == "cn") ? "五伍" : "five-fifth";
		loopw5t2.text = loopw5t1.text;
		loopw5t3.text = loopw5t1.text;
		loopw5t4.text = loopw5t1.text;
		loopw5t5.text = loopw5t1.text;
		loopw6t1.text = (tempCode == "cn") ? "六陸" : "six-sixth";
		loopw6t2.text = loopw6t1.text;
		loopw6t3.text = loopw6t1.text;
		loopw6t4.text = loopw6t1.text;
		loopw6t5.text = loopw6t1.text;
		loopw6t6.text = loopw6t1.text;
		loopw7t1.text = (tempCode == "cn") ? "七柒" : "seven-seventh";
		loopw7t2.text = loopw7t1.text;
		loopw7t3.text = loopw7t1.text;
		loopw7t4.text = loopw7t1.text;
		loopw7t5.text = loopw7t1.text;
		loopw7t6.text = loopw7t1.text;
		loopw7t7.text = loopw7t1.text;
	}
}
