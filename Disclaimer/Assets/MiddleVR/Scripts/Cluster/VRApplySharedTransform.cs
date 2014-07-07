/* VRApplySharedTransform
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRApplySharedTransform : MonoBehaviour {
    
    private VRShareTransform m_STScript = null;
    private vrTracker        m_tracker  = null;


	// Use this for initialization
	public void Start () {
        m_STScript = (VRShareTransform)GetComponent("VRShareTransform");
	}
	
	// Update is called once per frame
	public void Update () {
        if (MiddleVR.VRClusterMgr.IsClient() && m_STScript != null )
        {
            if (m_tracker == null && MiddleVR.VRDeviceMgr != null)
            {
                m_tracker = MiddleVR.VRDeviceMgr.GetTracker(m_STScript.ShareName);
                MiddleVRTools.Log("[+] Acquired shared tracker " + m_tracker.GetName());
            }

            if( m_tracker != null)
            {
                // Get rid of anything that could move the object
                //Destroy(rigidbody);

                vrVec3 pos = m_tracker.GetPosition();
                vrQuat or = m_tracker.GetOrientation();

                Vector3 p = new Vector3(pos.x(), pos.y(), pos.z());
                Quaternion q = new Quaternion((float)or.x(), (float)or.y(), (float)or.z(), (float)or.w());

                transform.position = p;
                transform.rotation = q;

                //MiddleVRTools.Log("Client applying data : " + p.z );
            }
        }
	}
}
