/* VRActor
 * MiddleVR
 * (c) i'm in VR
 */
using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRActor : MonoBehaviour {
    public bool Grabable = true;

    // Use this for initialization
    void Start () {
        if (gameObject.rigidbody == null)
        {
            Rigidbody body;
            body = gameObject.AddComponent("Rigidbody") as Rigidbody;
            body.isKinematic = true;
        }

        if(gameObject.collider == null)
        {
            gameObject.AddComponent("BoxCollider");
        }

        if (gameObject.collider == null)
        {
            MiddleVRTools.Log("[X] Actor object " + gameObject.name + " has no collider !! Put one or it won't act. " + gameObject.name );
        }
    }
    
    // Update is called once per frame
    void Update () {
    
    }
}
