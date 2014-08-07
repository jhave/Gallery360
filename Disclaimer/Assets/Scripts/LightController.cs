using UnityEngine;
using System.Collections;

public class LightController : MonoBehaviour {

	private bool isFadeIn;
	private bool isFadeOut;

	private float outLight;

	// Use this for initialization
	void Start () {
		isFadeIn = false;
		isFadeOut = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isFadeIn) 
			fadeIn ();
		if (isFadeOut)
			fadeOut ();
	}

	public void fade(string inout, float target) {
		this.outLight = target;
		switch (inout) {
		case "in":
			isFadeIn = true;
			//Debug.Log("Set to fade in");
			break;
		case "out":
			isFadeOut = true;
			//Debug.Log("Set to fade out");
			break;
		}
	}

	public void fadeIn() {
		if (this.light.intensity < outLight) {
			this.light.intensity += 0.05f;
		} else {
			isFadeIn = false;
		}
	}

	public void fadeOut() {
		if (this.light.intensity > outLight) {
			this.light.intensity -= 0.05f;
		} else {
			isFadeIn = false;
		}
	}
}
