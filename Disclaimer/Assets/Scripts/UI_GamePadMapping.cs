using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;
using System.IO;

public class UI_GamePadMapping : MonoBehaviour {
	
	public float WeaponDisplacement= -2;
	
	public static float Axis0Value = 0;
	public static float Axis1Value = 0;
	public float Axis2Value = 0;
	public float Axis3Value = 0;
	public float Axis4Value = 0;
	public float Axis5Value = 0;
	public float Axis6Value = 0;
	public float Axis7Value = 0;
	public bool ButtonA_Pressed = false;
	public bool ButtonB_Pressed = false;
	public bool ButtonX_Pressed = false;
	public bool ButtonY_Pressed = false;
	public bool Button4_Pressed = false;
	public bool Button5_Pressed = false;
	public bool Button6_Pressed = false;
	public bool Button7_Pressed = false;
	
	public bool IsJoystickConnected = false;

	public bool ButtonA_ToggleRelease = false;
	public bool ButtonB_ToggleRelease = false;
	public bool ButtonX_ToggleRelease = false;
	public bool ButtonY_ToggleRelease = false;
	public bool Button4_ToggleRelease = false;
	public bool Button5_ToggleRelease = false;
	public bool Button6_ToggleRelease = false;
	public bool Button7_ToggleRelease = false;
	public bool Button8_ToggleRelease = false;
	public bool Button9_ToggleRelease = false;
	public bool Axis2_ToggleRelease = false;

	private vrJoystick joy = null;
	
	private VRWandInteraction VRWandInteractionScript = null;
	
	private GameObject WandRay=null;
	private GameObject WandCube=null;
	private GameObject CenterNode = null;
	
	private GameObject Weapon=null;
	
	
	// Use this for initialization
	void Start () {
//		WandRay = GameObject.Find("WandRay");
//		WandCube = GameObject.Find("WandCube");
//		if (WandRay.renderer!=null) {
//			WandRay.renderer.enabled=false;
//			WandCube.renderer.enabled=false;
//		}
	}
	
	// Update is called once per frame
	void Update () {
		if (MiddleVR.VRDeviceMgr != null) { // cluster client won't get the joystick if it's at Start()
            joy     = MiddleVR.VRDeviceMgr.GetJoystickByIndex(0);
			if (joy != null) 
				IsJoystickConnected = true;
        }		
		
		if (IsJoystickConnected) {
			Axis0Value = joy.GetAxisValue(0);
			Axis1Value = joy.GetAxisValue(1);
			Axis2Value = joy.GetAxisValue(2);
			Axis3Value = joy.GetAxisValue(3);
			Axis4Value = joy.GetAxisValue(4);
			Axis5Value = joy.GetAxisValue(5);
			Axis6Value = joy.GetAxisValue(6);
			Axis7Value = joy.GetAxisValue(7);
			ButtonA_Pressed = joy.IsButtonPressed(0);
			ButtonB_Pressed = joy.IsButtonPressed(1);
			ButtonX_Pressed = joy.IsButtonPressed(2);
			ButtonY_Pressed = joy.IsButtonPressed(3);
			Button4_Pressed = joy.IsButtonPressed(4);
			Button5_Pressed = joy.IsButtonPressed(5);
			Button6_Pressed = joy.IsButtonPressed(6);
			Button7_Pressed = joy.IsButtonPressed(7);
			
			ButtonA_ToggleRelease = joy.IsButtonToggled(0);	
			ButtonB_ToggleRelease = joy.IsButtonToggled(1);	
			ButtonX_ToggleRelease = joy.IsButtonToggled(2);				
			ButtonY_ToggleRelease = joy.IsButtonToggled(3);	
			Button4_ToggleRelease = joy.IsButtonToggled(4);	
			Button5_ToggleRelease = joy.IsButtonToggled(5);	
			Button6_ToggleRelease = joy.IsButtonToggled(6);	
			Button7_ToggleRelease = joy.IsButtonToggled(7);	
			Button8_ToggleRelease = joy.IsButtonToggled(8);	
			Button9_ToggleRelease = joy.IsButtonToggled(9);	
			
			//********** Toggling WandRay Visiblity BEGIN ********//		
//			if (Button5_ToggleRelease) {
//				WandRay = GameObject.Find("WandRay");
//				WandCube = GameObject.Find("WandCube");
//				if (WandRay.renderer!=null) {
//					WandRay.renderer.enabled=!WandRay.renderer.enabled;
//					WandCube.renderer.enabled=!WandCube.renderer.enabled;
//				}
//			}			
			//********** Toggling WandRay Visiblity END ********//
		}		
		
//		if (Weapon == null) {
//			Weapon = GameObject.Find("main_weapon001");
//		}
//		else {
////			Weapon.transform.localPosition = 
////				new Vector3(WeaponDisplacement,Weapon.transform.localPosition.y, Weapon.transform.localPosition.z);
//		}
		
		
		
	}		
}
