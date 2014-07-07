/* VRFollowNode
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRFollowNode : MonoBehaviour {
    public string VRNodeName = "HeadNode";
    private vrNode3D m_Node = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (m_Node == null && MiddleVR.VRDisplayMgr != null)
        {
            m_Node = MiddleVR.VRDisplayMgr.GetNode(VRNodeName);
        }

        if (m_Node != null)
        {
            transform.localPosition = MiddleVRTools.ToUnity(m_Node.GetPositionWorld());
            transform.localRotation = MiddleVRTools.ToUnity(m_Node.GetOrientationWorld());
        }
	}
}
