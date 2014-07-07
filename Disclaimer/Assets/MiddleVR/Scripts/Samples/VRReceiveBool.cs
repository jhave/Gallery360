/* VRReceiveBool
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRShareBool script
 * Receive the bool value shared through a vrButtons
 * Must be executed after VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRReceiveBool : MonoBehaviour {
	
    private VRShareBool	m_ShareBoolScript	= null;
    private vrButtons 	m_BoolButton 		= null;
	
	// Use this for initialization
	public void Start () {
		// If server, stop. Only clients receives
		if(MiddleVR.VRClusterMgr.IsServer())
		{
			this.GetComponent<VRReceiveBool>().enabled = false;
			return;
		}
		
        m_ShareBoolScript = (VRShareBool)GetComponent("VRShareBool");
	}
	
	// Update is called once per frame
	public void Update () {
		
        if ( m_ShareBoolScript != null )
        {
            if (m_BoolButton == null && MiddleVR.VRDeviceMgr != null)
            {
                m_BoolButton = MiddleVR.VRDeviceMgr.GetButtons(m_ShareBoolScript.ShareName);
                MiddleVRTools.Log("[+] Acquired shared bool button " + m_BoolButton.GetName());
			}	
			else if( m_BoolButton != null )
			{
				// Boolean to watch =	m_BoolButton.IsPressed(0);
			}
		}
	}
}
