/* VRClusterObject
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRClusterObject : MonoBehaviour {
    public bool IncludeChildren = true;

    void AddClusterScripts(GameObject iObject, bool iChildren)
    {
        //MiddleVRTools.Log("AddCluster to " + iObject);
        //print("AddCluster to " + iObject);
        {
            if (iObject.GetComponent<VRShareTransform>() == null)
            {
                VRShareTransform script = iObject.AddComponent<VRShareTransform>() as VRShareTransform;
                script.Start();
            }

            if (iObject.GetComponent<VRApplySharedTransform>() == null)
            {
                VRApplySharedTransform script = iObject.AddComponent<VRApplySharedTransform>() as VRApplySharedTransform;
                script.Start();
            }
        }

        if( iChildren == true )
        {
            foreach (Transform child in iObject.transform)
            {
                GameObject childObject = child.gameObject;

                //print("Child : " + childObject);
                AddClusterScripts(childObject, true);
            }
        }
    }

	// Use this for initialization
	void Start () {
        AddClusterScripts(gameObject, IncludeChildren);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
