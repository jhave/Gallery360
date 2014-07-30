using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {
	
	public bool isLookDown;
	public bool isLookUp;
	private Vector3 v3To0;
	private Vector3 v3To90;
	public Vector3 v3Current;
	
	// Use this for initialization
	void Start () {

		isLookUp = false;
		isLookDown = false;
		
		v3To0 = new Vector3(0,0,0);
		v3To90 = new Vector3(90,0,0);
		v3Current = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (isLookUp)
			lookUp ();
		if (isLookDown)
			lookDown ();
		//transform.eulerAngles = v3Current;
		//Debug.Log (transform.localEulerAngles.x);
	}
	
	public void lookDown() {
		if (transform.localEulerAngles.z < 90) {
			transform.Rotate (0, 0, 48 * Time.deltaTime);
		} else {
			isLookDown = false;
			//transform.eulerAngles = new Vector3(90, 0, 0);
		}



//		if (v3Current.x < 89) {
//////			this.transform.localRotation = new Quaternion();
////			//				//new Vector3(this.transform.localRotation.x - 5, this.transform.localRotation.y, this.transform.localRotation.z);
//			v3Current = Vector3.Lerp(v3Current, v3To90, Time.deltaTime * 1.0f);
////
//		} else {
//////			//this.transform.localRotation = new Vector3(this.transform.localRotation.x, 90, this.transform.localRotation.z);
//			isLookDown = false;
//		}
	}
	
	public void lookUp() {

		if (transform.localEulerAngles.z > 0 && transform.localEulerAngles.z < 180) {
			transform.Rotate (0, 0, -48 * Time.deltaTime);
		} else {
			isLookUp = false;
			//transform.eulerAngles = new Vector3(0, 0, 0);
		}


//		if (v3Current.x > 1) {
//			////			this.transform.localRotation = new Quaternion();
//			//			//				//new Vector3(this.transform.localRotation.x - 5, this.transform.localRotation.y, this.transform.localRotation.z);
//			v3Current = Vector3.Lerp(v3Current, v3To0, Time.deltaTime * 1.0f);
//			//
//		} else {
//			////			//this.transform.localRotation = new Vector3(this.transform.localRotation.x, 90, this.transform.localRotation.z);
//			isLookUp = false;
//		}
	}
}
