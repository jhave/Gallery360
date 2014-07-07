/* VRReceiveEvent
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRShareEvent script
 * Receive and transmit an event shared through a vrButtons
 * Must be executed after VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRReceiveEvent : MonoBehaviour {
	
    private VRShareEvent	m_ShareEventScript 	= null;
    private vrButtons 		m_EventButton 		= null;

	// Use this for initialization
	public void Start () {
        m_ShareEventScript = (VRShareEvent)GetComponent("VRShareEvent");
	}
	
	// Update is called once per frame
	public void Update () {
		
        if ( m_ShareEventScript != null )
        {
            if (m_EventButton == null && MiddleVR.VRDeviceMgr != null)
            {
                m_EventButton = MiddleVR.VRDeviceMgr.GetButtons(m_ShareEventScript.ShareName);
                MiddleVRTools.Log("[+] Acquired shared event button " + m_EventButton.GetName());
            }	
			else if( m_EventButton != null )
			{
				if( m_EventButton.IsPressed(0) )
				{
					// Every node receive the event VRCallbackName
					// this.SendMessage("FinalFunction");
					m_EventButton.SetPressedState(0,false);
				}
			}
		}
	}
}
