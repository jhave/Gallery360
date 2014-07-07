/* VRShareTransform
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;

using MiddleVR_Unity3D;

public class VRShareTransform : MonoBehaviour {
    static private uint g_shareID = 1;

    private uint      m_ShareID = 0;
    private vrTracker m_tracker = null;

    [HideInInspector]
    public string ShareName;

	// Use this for initialization
	public void Start () {
        if (m_ShareID == 0)
        {
            m_ShareID = g_shareID++;
            MiddleVRTools.Log("[ ] " + this.name + " ShareID: " + m_ShareID);
        }
	}
	
	// Update is called once per frame
	public void Update () {
        if( m_tracker == null && MiddleVR.VRDeviceMgr != null )
        {
            ShareName = "S_" + m_ShareID.ToString();
            m_tracker = MiddleVR.VRDeviceMgr.CreateTracker(ShareName);
            MiddleVRTools.Log("[+] Created shared tracker " + ShareName );
            MiddleVR.VRClusterMgr.AddSynchronizedObject(m_tracker, 1);
        }

        if( MiddleVR.VRClusterMgr.IsServer() && m_tracker != null )
        {
            Vector3 p = transform.position;
            Quaternion q = transform.rotation;

            vrVec3 pos = new vrVec3(p.x, p.y, p.z);
            vrQuat or = new vrQuat(q.x, q.y, q.z, q.w);

            m_tracker.SetPosition(pos);
            m_tracker.SetOrientation(or);

            //MiddleVRTools.Log("Server pushing data : " + p.z );
        }
	}
}
