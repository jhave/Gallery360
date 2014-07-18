using UnityEngine;
using System.Collections;

public class RotateWithWand : MonoBehaviour {

	public GameObject VRWand;
	public GameObject Player; // which is the root of CAVE


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localEulerAngles.y = VRWand.transform.eulerAngles.y - Player.transform.eulerAngles.y + 180;
		//transform.localEulerAngles = new Vector3 (transform.localEulerAngles.x, VRWand.transform.eulerAngles.y - Player.transform.eulerAngles.y + 180, transform.localEulerAngles.z);
		//transform.Rotate (0, 180, 0);

		//transform.localEulerAngles = new Vector3 (VRWand.transform.eulerAngles.x - Player.transform.eulerAngles.x + 180, transform.localEulerAngles.y, transform.localEulerAngles.z);
		//transform.Rotate (180, 0, 0);
	}
}
