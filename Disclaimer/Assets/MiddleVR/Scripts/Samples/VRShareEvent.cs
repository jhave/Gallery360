/* VRShareEvent
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRReceiveEvent script
 * Share an event through a vrButtons
 * Must be executed before VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRShareEvent : MonoBehaviour {
	
    private vrButtons m_EventButton = null;
	
    [HideInInspector]
    public string ShareName = "SharedEventButton";

	// Use this for initialization
	public void Start () {
	}
	
	// Update is called once per frame
	public void Update () {
        if( m_EventButton == null && MiddleVR.VRDeviceMgr != null )
        {
            m_EventButton = MiddleVR.VRDeviceMgr.CreateButtons(ShareName);
			m_EventButton.SetButtonsNb(1);
            MiddleVRTools.Log("[+] Created shared event button " + ShareName );
            MiddleVR.VRClusterMgr.AddSynchronizedObject(m_EventButton, 0);
        }
	}
	
	// Event received through a SendMessage("SendSharedVREvent")
	public void SendSharedVREvent()
	{
		if( MiddleVR.VRClusterMgr.IsServer() && m_EventButton != null )
		{
			m_EventButton.SetPressedState(0,true);
		}
	}
}
