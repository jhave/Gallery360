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
	public GameObject cPlane5;
	public GameObject cPlane6;

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

	public SelfRotation level4Controller;
	public SelfRotation level4Controller_cn;
	public SinglePopUpRow level5Controller;

	public bool level5Enabled;

	/* Level:
	 * 1 = Disclaimer
	 * 2 = Transision Cone
	 * 3 = AngryWords
	 * 4 = Dynamic Cylinder 360 (Rotation from one row to seven row)
	 * 5 = Dynamic Cylinder 360 (Pop from one row to 20 row, then fill up the colomn)
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
			
			if (Input.GetMouseButtonDown (1) || joystick.ButtonB_ToggleRelease) {
				//Debug.Log ("Pressed right click.");
				Application.LoadLevel("AngryWords");
			}
			
			//Middle Button
			//remove plane (remove platform)
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_ToggleRelease) {
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
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_ToggleRelease) {
				//Debug.Log ("Pressed right click.");
				cPlane2.SetActive(false);
				//setLevel(4);
			}
			if (Input.GetMouseButtonDown (1) || joystick.ButtonB_Pressed) {
				float scaleX = cylinder02.renderer.materials[1].mainTextureScale.x * -1;
				float scaleY = cylinder02.renderer.materials[1].mainTextureScale.y;
				cylinder02.renderer.materials[1].SetTextureScale("_MainTex", new Vector2(scaleX, scaleY));
			}

			break;
		case 4:
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_ToggleRelease) {
				//Debug.Log ("Pressed right click.");
				cPlane3.SetActive(false);
				cPlane4.collider.enabled = false;
				//cPlane4.SetActive(false);

				//setLevel(5);
			}
			break;
		case 5:
			if (Input.GetMouseButtonDown (2) || joystick.ButtonA_ToggleRelease) {
				//Debug.Log ("Pressed right click.");
				cPlane5.SetActive(false);
				cPlane6.collider.enabled = false;
				//cPlane6.SetActive(false);
				
				//setLevel(6);
			}
			break;
		}
	}
	
	public void setLevel(int lv) {
		this.level = lv;
		Debug.Log ("level " + level);
		switch (lv) {
		case 1: //Disclaimer
			playerMoveController.enabled = false;
			//cylinder01.audio.Play ();
			point00.fade ("in", 4.0f);
			point01.fade ("in", 4.0f);
			break;
		case 2: //Cone
			//player_view.isLookDown = true;
			randomText.isRandom = false;
			//point00.fade ("out", 0.0f);
			//point01.fade ("out", 0.0f);
			break;
		case 3: //Angry Words
		/* Player Hit the ground of AngryWords will set to level 3
		 * The script is in PlayerCollider.cs
		 */
			/*********** Add statement to clear text in Level 1 **************/

			//player_view.isLookUp = true;
			playerMoveController.enabled = true;
			break;
		case 4: //Dynamic Cylinder 360
			level4Controller.isActive = true;
			level4Controller_cn.isActive = true;
			break;
		case 5: //Dynamic Cylinder 360
			level4Controller.isActive = false;
			level4Controller_cn.isActive = false;
			/*********** Add statement to clear text in Level 4 **************/

			if (!level5Enabled) {
				level5Enabled = true;
				level5Controller.isInLevel = true;
			}
			break;
		case 6: //Red Two Way Tunnel
			break;
		}
	}
	
}




