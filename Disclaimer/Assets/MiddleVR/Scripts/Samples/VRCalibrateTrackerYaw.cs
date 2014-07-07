/* VRCalibrateTrackerYaw
 * MiddleVR
 * (c) i'm in VR
 */
using UnityEngine;
using System.Collections;

public class VRCalibrateTrackerYaw : MonoBehaviour {
    public string Tracker = "VRPNTracker0.Tracker0";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        vrTracker tracker = null;
        vrKeyboard keyb = null;

        if (MiddleVR.VRDeviceMgr != null)
        {
            tracker = MiddleVR.VRDeviceMgr.GetTracker(Tracker);
            keyb = MiddleVR.VRDeviceMgr.GetKeyboard();
        }

        if (keyb != null && keyb.IsKeyToggled(MiddleVR.VRK_SPACE))
        {
            if( tracker != null )
            {
                float yaw   = tracker.GetYaw();

                vrQuat neutralOr = new vrQuat(0,0,0,1);
                neutralOr.SetEuler(-yaw, 0, 0);
                vrQuat nq = neutralOr.GetInverse();

                tracker.SetNeutralOrientation(nq);
            }
        }
	}
}
