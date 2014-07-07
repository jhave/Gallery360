/* VRReceiveFloat
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRShareFloat script
 * Receive the float value shared through a vrAxis
 * Must be executed after VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRReceiveFloat : MonoBehaviour {
	
    private VRShareFloat	m_ShareFloatScript 	= null;
    private vrAxis	 		m_FloatAxis 		= null;

	// Use this for initialization
	public void Start () {
		// If server, stop. Only clients receives
		if(MiddleVR.VRClusterMgr.IsServer())
		{
			this.GetComponent<VRReceiveFloat>().enabled = false;
			return;
		}
		
        m_ShareFloatScript = (VRShareFloat)GetComponent("VRShareFloat");
	}
	
	// Update is called once per frame
	public void Update () {
		
        if ( m_ShareFloatScript != null )
        {
            if (m_FloatAxis == null && MiddleVR.VRDeviceMgr != null)
            {
                m_FloatAxis = MiddleVR.VRDeviceMgr.GetAxis(m_ShareFloatScript.ShareName);
                MiddleVRTools.Log("[+] Acquired shared float axis " + m_FloatAxis.GetName());
            }
			else if( m_FloatAxis != null )
			{
				// Float to watch = m_FloatAxis.GetValue(0);
			}
		}
	}
}
