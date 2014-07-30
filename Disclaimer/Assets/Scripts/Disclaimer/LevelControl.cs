using UnityEngine;
using System.Collections;

public class LevelControl : MonoBehaviour {
	
	public RandomText randomText;
	private int level;

	//public float timer = 5.0f;

	public GameObject cPlane;
	public GameObject cPlane2;
	public GameObject cPlane3;
	public GameObject cPlane4;
	public VRManagerScript vrmgrscript;
	//public PlayerRotation player_root;
	public GameObject player_root;
	public PlayerRotation player_view;
	
	public UI_GamePadMapping joystick;
	public PlayerMoveController playerMoveController;

	public LightController point00;
	public LightController point01;

	public GameObject cylinder01;
	public GameObject cylinder02;


	/* Level:
	 * 1 = Disclaimer
	 * 2 = Transision Cone
	 * 3 = AngryWords
	 * 4 = Dynamic Cylinder 360
	 * 5 = Kitchen
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
			//Auto setLevel(3) in Player.PlayerCollider when touched cPlane2
			break;
		case 3:
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_Pressed) {
				//Debug.Log ("Pressed right click.");
				cPlane2.SetActive(false);
				setLevel(4);
			}
			if (Input.GetMouseButtonDown (1) || joystick.ButtonB_Pressed) {
				float scaleX = cylinder02.renderer.materials[1].mainTextureScale.x * -1;
				float scaleY = cylinder02.renderer.materials[1].mainTextureScale.y;
				cylinder02.renderer.materials[1].SetTextureScale("_MainTex", new Vector2(scaleX, scaleY));
			}

			break;
		case 4:
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_Pressed) {
				//Debug.Log ("Pressed right click.");
				cPlane3.SetActive(false);
				cPlane4.SetActive(false);

				setLevel(5);
			}
			break;
		case 5:
			break;
		}
	}
	
	public void setLevel(int lv) {
		this.level = lv;
		switch (lv) {
		case 1: //Disclaimer
			playerMoveController.enabled = false;
			cylinder01.audio.Play ();
			point00.fade ("in", 4.0f);
			point01.fade ("in", 4.0f);
			break;
		case 2: //Cone
			player_view.isLookDown = true;
			randomText.isRandom = false;
			//point00.fade ("out", 0.0f);
			//point01.fade ("out", 0.0f);
			break;
		case 3: //Angry Words
			player_view.isLookUp = true;
			playerMoveController.enabled = true;
			break;
		case 4: //Dynamic Cylinder 360
			break;
		case 5: //Kitchen
			break;
		}
	}
	
}




