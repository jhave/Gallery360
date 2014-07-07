using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float tilt;
	
	void FixedUpdate ()
	{
		//control for PC/MAC
		float moveHorizontal;
		float moveVertical;

		//moveHorizontal = Input.GetAxis ("Horizontal");
		//moveVertical = Input.GetAxis ("Vertical");

		moveHorizontal = UI_GamePadMapping.Axis0Value;
		moveVertical = UI_GamePadMapping.Axis1Value;
		
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		transform.Translate (moveHorizontal, 0.0f, moveVertical);

		//need to add control for 360

	}
}