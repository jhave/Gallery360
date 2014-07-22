using UnityEngine;
using System.Collections;

public class CylinderTextLoop : MonoBehaviour {

	public TextMesh text_360;
	public Camera camera_360;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		float th = 2f * camera_360.orthographicSize;
//		float tw = th * camera_360.aspect;
//		Debug.Log (tw);
//			//text_360.GetComponent<MeshRenderer>().bounds.size.z/2;
//		float tx = camera_360.transform.localPosition.x;
//		float ty = camera_360.transform.localPosition.y;
//		float tz = camera_360.transform.localPosition.z;
//
//		text_360.transform.localPosition = new Vector3 (tx, ty, tz);// + tw);
	}
}
