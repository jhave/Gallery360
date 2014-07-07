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
		//transform.Rotate (0, 180, 0);
	}
}
