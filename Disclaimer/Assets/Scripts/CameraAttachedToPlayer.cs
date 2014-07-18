using UnityEngine;
using System.Collections;

public class CameraAttachedToPlayer : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Real Time attach player_view to Player instead of parent-child
		//To prevent roatation of the camera when the Player is falling
		transform.position = new Vector3 (player.transform.localPosition.x, player.transform.localPosition.y, player.transform.localPosition.z);

	}
}
