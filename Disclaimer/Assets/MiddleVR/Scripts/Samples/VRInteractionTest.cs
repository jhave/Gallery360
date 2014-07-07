/* VRInteractionTest
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRInteractionTest : MonoBehaviour {
	void Start () {}
	
	void Update () {
        TestWand();
        TestKeyboardMouse();
        TestDevices();
        TestDisplay();
    }

    void TestWand()
    {
        if (MiddleVR.VRDeviceMgr != null)
        {
            // Getting wand horizontal axis
            float x = MiddleVR.VRDeviceMgr.GetWandHorizontalAxisValue();
            // Getting wand vertical axis
            float y = MiddleVR.VRDeviceMgr.GetWandVerticalAxisValue();

            // Getting state of primary wand button
            bool b0 = MiddleVR.VRDeviceMgr.IsWandButtonPressed(0);

            // Getting toggled state of primary wand button
            // bool t0 = MiddleVR.VRDeviceMgr.IsWandButtonToggled(0);

            if (b0 == true)
            {
                // If primary button is pressed, display wand horizontal axis value
                MiddleVRTools.Log("WandButton 0 pressed! HAxis value: " + x + ", VAxis value: " + y );
            }
        }
    }

    void TestKeyboardMouse()
    {
        if (MiddleVR.VRDeviceMgr != null)
        {
            // Testing mouse button
            if (MiddleVR.VRDeviceMgr.IsMouseButtonPressed(0))
            {
                MiddleVRTools.Log("Mouse Button pressed!");
                MiddleVRTools.Log("VRMouseX : " + MiddleVR.VRDeviceMgr.GetMouseAxisValue(0));
            }

            // Testing keyboard key
            if (MiddleVR.VRDeviceMgr.IsKeyPressed(MiddleVR.VRK_SPACE))
            {
                MiddleVRTools.Log("Space!");
            }
        }
    }

    void TestDevices()
    {
        vrTracker tracker = null;
        vrJoystick    joy = null;
        vrAxis       axis = null;
        vrButtons buttons = null;

        // Getting a reference to different device types
        if (MiddleVR.VRDeviceMgr != null) {
            tracker = MiddleVR.VRDeviceMgr.GetTracker("VRPNTracker0.Tracker0");
            joy     = MiddleVR.VRDeviceMgr.GetJoystickByIndex(0);
            axis    = MiddleVR.VRDeviceMgr.GetAxis("VRPNAxis0.Axis");
            buttons = MiddleVR.VRDeviceMgr.GetButtons("VRPNButtons0.Buttons");
        }

        // Getting tracker data
        if( tracker != null )
        {
              MiddleVRTools.Log("TrackerX : " + tracker.GetPosition().x() );
        }

        // Testing joystick button
        if (joy != null && joy.IsButtonPressed(0)) {
            MiddleVRTools.Log("Joystick!");
        }

        // Testing axis value
        if( axis != null && axis.GetValue(0) > 0 )
        {
            MiddleVRTools.Log("Axis Value: " + axis.GetValue(0));
        }

        // Testing button state
        if (buttons != null)
        {
            if (buttons.IsToggled(0))
            {
                MiddleVRTools.Log("Button 0 pressed !");
            }

            if (buttons.IsToggled(0, false))
            {
                MiddleVRTools.Log("Button 0 released !");
            }
        }
    }

    void TestDisplay()
    {
        // 3D nodes
        vrNode3D      node  = null;
        vrCamera     camera = null;
        vrCameraStereo scam = null;
        vrScreen     screen = null;
        vrViewport       vp = null;

        if (MiddleVR.VRDisplayMgr != null)
        {
            node   = MiddleVR.VRDisplayMgr.GetNode("HeadNode");
            if (node != null) { MiddleVRTools.Log("Found HeadNode"); }

            camera = MiddleVR.VRDisplayMgr.GetCamera("Camera0");
            if (camera != null) { MiddleVRTools.Log("Found Camera0"); }

            scam   = MiddleVR.VRDisplayMgr.GetCameraStereo("CameraStereo0");
            if (scam != null) { MiddleVRTools.Log("Found CameraStereo0"); }

            screen = MiddleVR.VRDisplayMgr.GetScreen("Screen0");
            if (screen != null) { MiddleVRTools.Log("Found Screen0"); }

            vp     = MiddleVR.VRDisplayMgr.GetViewport("Viewport0");
            if (vp != null) { MiddleVRTools.Log("Found Viewport0"); }
        }

    }
}
