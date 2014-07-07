/* VRAttachToNode
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRAttachToNode  : MonoBehaviour {
    public string VRParentNode = "HandNode";
    public bool ResetTransformation = true;
    bool attached = false;

    private bool m_Searched = false;

    // Use this for initialization
    void Start () {
    
    }

    // Update is called once per frame
    void Update () {
        if (!attached)
        {
            GameObject node = GameObject.Find(VRParentNode);

            if( VRParentNode.Length == 0 )
            {
                MiddleVRTools.Log(0, "[X] AttachToNode: Please specify a valid VRParentNode name.");
            }

            if (node != null)
            {
                Vector3 oldPos = transform.localPosition;
                Quaternion oldRot = transform.localRotation;

                transform.parent = node.transform;

                if( ResetTransformation )
                {
                    transform.localPosition = new Vector3(0, 0, 0);
                    transform.localRotation = new Quaternion(0, 0, 0, 1);
                }
                else
                {
                    transform.localPosition = oldPos;
                    transform.localRotation = oldRot;
                }

                MiddleVRTools.Log( 2, "[+] AttachToNode: " + this.name + " attached to : " + node.name );
                attached = true;
            }
            else
            {
                if (m_Searched == false)
                {
                    MiddleVRTools.Log(0, "[X] AttachToNode: Failed to find Game object '" + VRParentNode + "'");
                    m_Searched = true;
                }
            }
        }
    }
}
