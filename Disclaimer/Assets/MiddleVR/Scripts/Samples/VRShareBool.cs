/* VRShareBool
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRReceiveBool script
 * Share the bool value through a vrButtons
 * Must be executed before VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRShareBool : MonoBehaviour {
	
    private vrButtons m_BoolButton = null;
	
    [HideInInspector]
    public string ShareName = "SharedBoolButton";

	// Use this for initialization
	public void Start () {		
	}
	
	// Update is called once per frame
	public void Update () {
		
        if( m_BoolButton == null && MiddleVR.VRDeviceMgr != null )
        {
            m_BoolButton = MiddleVR.VRDeviceMgr.CreateButtons(ShareName);
			m_BoolButton.SetButtonsNb(1);
            MiddleVRTools.Log("[+] Created shared bool button " + ShareName );
            MiddleVR.VRClusterMgr.AddSynchronizedObject(m_BoolButton, 0);
        }
        else if( MiddleVR.VRClusterMgr.IsServer() && m_BoolButton != null )
        {
			// m_BoolButton.SetPressedState(0, Boolean to watch );
		}		
	}
}
