/* VRCameraCB
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using MiddleVR_Unity3D;

public class VRCameraCB : MonoBehaviour {
	[DllImport ("MiddleVR_UnityRendering")]
	private static extern void InitRenderPlugin();
	
	void Start()
	{
        MiddleVR.VRLog(5, "[>] RenderPlugin: Initializing");
        InitRenderPlugin();
        MiddleVR.VRLog(5, "[<] RenderPlugin: Initialized");
	}

    void OnPreRender()
    {
        MiddleVRTools.OnPreRender(gameObject);
    }

    void OnGUI()
    {
        MiddleVRTools.OnGUI(gameObject);
    }

    void OnPostRender()
	{
        MiddleVRTools.OnPostRender(gameObject);
	}
}
