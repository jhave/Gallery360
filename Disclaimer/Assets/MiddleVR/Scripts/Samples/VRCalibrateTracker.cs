/* VRCalibrateTracker
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;

public class VRCalibrateTracker : MonoBehaviour {
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
                tracker.SetNeutralOrientation(tracker.GetOrientation());
            }
        }
	}
}
