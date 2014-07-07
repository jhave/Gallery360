/* VRShareFloat
 * MiddleVR
 * (c) i'm in VR
 * 
 * To use combined with a VRReceiveFloat script
 * Share the float value through a vrAxis
 * Must be executed before VRManager script 
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRShareFloat : MonoBehaviour {
	
    private vrAxis m_FloatAxis = null;
	
    [HideInInspector]
    public string ShareName = "SharedFloatAxis";

	// Use this for initialization
	public void Start () {
	}
	
	// Update is called once per frame
	public void Update () {
		
        if( m_FloatAxis == null && MiddleVR.VRDeviceMgr != null )
        {
            m_FloatAxis = MiddleVR.VRDeviceMgr.CreateAxis(ShareName);
			m_FloatAxis.SetAxisNb(1);
            MiddleVRTools.Log("[+] Created shared float axis " + ShareName );
            MiddleVR.VRClusterMgr.AddSynchronizedObject(m_FloatAxis, 0);
        }
		else if( MiddleVR.VRClusterMgr.IsServer() && m_FloatAxis != null )
        {
			// m_FloatAxis.SetValue(0, Float to watch );
		}	
	}
}
