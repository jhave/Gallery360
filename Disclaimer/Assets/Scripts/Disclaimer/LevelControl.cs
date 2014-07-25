using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {
	
	public RandomText randomText;
	private int level;
	
	public GameObject cPlane;
	public VRManagerScript vrmgrscript;
	public GameObject player_root;
	public GameObject player_view;
	
	public UI_GamePadMapping joystick;
	public PlayerMoveController playerMoveController;
	public Light point00;
	public Light point01;

	private bool initOn;
	
	/* Level:
	 * 1 = Disclaimer
	 * 2 = Cone
	 * 3 = 
	 */
	
	// Use this for initialization
	void Start () {
		setLevel (1);
		//Fade Object or Text ONLY
		//StartCoroutine(Fade.use.Alpha(point01, 0.0f, 4.0f, 3.0f));
	}
	
	// Update is called once per frame
	void Update () {
		levelController ();
		if (!initOn) {
			if (point01.intensity < 4) {
				point01.intensity += 0.05f;
			}

			if (point00.intensity < 4) {
				point00.intensity += 0.05f;
			}

			if (point00.intensity >= 4 && point01.intensity >= 4) {
				initOn = false;
			}
		}
	}
	
	void levelController() {
		switch (level) {
		case 1:
			if (Input.GetMouseButtonDown (0) || joystick.ButtonX_ToggleRelease || joystick.ButtonY_Pressed) {
				//Debug.Log ("Pressed left click.");
				randomText.random();
			}
			
			if (Input.GetMouseButtonDown (1) || joystick.ButtonB_Pressed) {
				//Debug.Log ("Pressed right click.");
				Application.LoadLevel("AngryWords");
			}
			
			//Middle Button
			//remove plane (remove platform)
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_Pressed) {
				//Debug.Log ("Pressed right click.");
				cPlane.SetActive(false);
				setLevel(2);
				//vrmgrscript.RootNode = player_root;
				//vrmgrscript.TemplateCamera = player_view;
			}
			break;
		case 2:


			break;
		}
	}
	
	public void setLevel(int lv) {
		this.level = lv;
		switch (lv) {
		case 1: //Disclaimer
			initOn = false;
			playerMoveController.enabled = false;
			break;
		case 2: //Cone
			break;
		case 3: //Angry Words
			playerMoveController.enabled = true;
			break;
		}
	}
	
}




