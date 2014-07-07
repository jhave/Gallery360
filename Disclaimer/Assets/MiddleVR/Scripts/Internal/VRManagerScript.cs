/* VRManagerScript
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;
using System;

public class VRManagerScript : MonoBehaviour
{
    public enum ENavigationMode{
        None,
        Joystick,
        Elastic,
        GrabWorld
    }

    // Public readable parameters
    [HideInInspector]
    public float WandAxisHorizontal = 0.0f;

    [HideInInspector]
    public float WandAxisVertical = 0.0f;

    [HideInInspector]
    public bool WandButton0 = false;

    [HideInInspector]
    public bool WandButton1 = false;

    [HideInInspector]
    public bool WandButton2 = false;

    [HideInInspector]
    public bool WandButton3 = false;

    [HideInInspector]
    public bool WandButton4 = false;

    [HideInInspector]
    public bool WandButton5 = false;

    [HideInInspector]
    public double DeltaTime = 0.0f;

    // Exposed parameters:
    public string ConfigFile = "c:\\config.vrx";
    public GameObject RootNode = null;
    public GameObject TemplateCamera = null;

    public bool            ShowWand                 = true;
    public ENavigationMode NavigationMethod         = ENavigationMode.Joystick;
    public bool            ShowFPS                  = true;
    public bool            DisableExistingCameras   = true;
    public bool            GrabExistingNodes        = false;
    public bool            DebugNodes               = false;
    public bool            DebugScreens             = false;
    public bool            QuitOnEsc                = true;
    public bool            DontChangeWindowGeometry = false;
    public bool            SimpleCluster            = true;
    public bool            ForceQuality             = false;
    public int             ForceQualityIndex        = 3;
    public bool            ChangeWorldScale         = false;
    public float           WorldScale               = 1.0f;

    // Private members
    private vrKernel         kernel     = null;
    private vrDisplayManager displayMgr = null;

    private bool m_isInit        = false;
    private bool m_isGeometrySet = false;
    private bool m_displayLog    = false;

    private int  m_AntiAliasingLevel = 0;
    
    private bool m_NeedDelayedRenderingReset = false;
    private int  m_RenderingResetDelay       = 1;

    private GUIText    m_GUI  = null;
    private GameObject m_Wand = null;

    private bool[] mouseButtons = new bool[3];
    
    private bool m_AllowRenderTargetAA = false;

    private uint m_FirstFrameAfterReset = 0;

    // Public methods

    public void Log(string text)
    {
        MiddleVRTools.Log(text);
    }

    public bool IsKeyPressed(uint iKey)
    {
        if (MiddleVR.VRDeviceMgr != null && MiddleVR.VRDeviceMgr.IsKeyPressed(iKey))
        {
            return true;
        }

        return false;
    }

    public bool IsMouseButtonPressed(uint iButtonIndex)
    {
        if (MiddleVR.VRDeviceMgr != null && MiddleVR.VRDeviceMgr.IsMouseButtonPressed(iButtonIndex))
        {
            return true;
        }

        return false;
    }

    public float GetMouseAxisValue(uint iAxisIndex)
    {
        if (MiddleVR.VRDeviceMgr != null)
        {
            return MiddleVR.VRDeviceMgr.GetMouseAxisValue(iAxisIndex);
        }

        return 0.0f;
    }
    

    // Private methods

    void InitializeVR()
    {
        mouseButtons[0] = mouseButtons[1] = mouseButtons[2] = false;

        if (m_displayLog)
        {
            GameObject gui = new GameObject();
            m_GUI = gui.AddComponent("GUIText") as GUIText;
            gui.transform.localPosition = new UnityEngine.Vector3(0.5f, 0.0f, 0.0f);
            m_GUI.pixelOffset = new UnityEngine.Vector2(15, 0);
            m_GUI.anchor = TextAnchor.LowerCenter;
        }

        MiddleVRTools.IsEditor = Application.isEditor;

        if( MiddleVR.VRKernel != null )
        {
            MiddleVRTools.Log(3,"[ ] VRKernel already alive, reset Unity Manager.");
            MiddleVRTools.VRReset();
            m_isInit = true;
            // Not needed because this is the first execution of this script instance
            // m_isGeometrySet = false; 
            m_FirstFrameAfterReset = MiddleVR.VRKernel.GetFrame();
        }
        else
        {
            m_isInit = MiddleVRTools.VRInitialize(ConfigFile);
        }

        // Get AA from vrx configuration file
        m_AntiAliasingLevel = (int)MiddleVR.VRDisplayMgr.GetAntiAliasing();

        DumpOptions();

        kernel = MiddleVR.VRKernel;
        displayMgr = MiddleVR.VRDisplayMgr;

        if (!m_isInit)
        {
            GameObject gui = new GameObject();
            m_GUI = gui.AddComponent("GUIText") as GUIText;
            gui.transform.localPosition = new UnityEngine.Vector3(0.2f, 0.0f, 0.0f);
            m_GUI.pixelOffset = new UnityEngine.Vector2(0, 0);
            m_GUI.anchor = TextAnchor.LowerLeft;

            string txt = kernel.GetLogString(true);
            print(txt);
            m_GUI.text = txt;

            return;
        }

        if (SimpleCluster)
        {
            SetupSimpleCluster();
        }

        if (ChangeWorldScale)
        {
            displayMgr.SetChangeWorldScale(true);
            displayMgr.SetWorldScale(WorldScale);
        }

        if (DisableExistingCameras)
        {
            Camera[] cameras = GameObject.FindObjectsOfType(typeof(Camera)) as Camera[];

            foreach (Camera cam in cameras)
            {
                if (cam.targetTexture == null)
                {
                    cam.enabled = false;
                }
            }
        }

        MiddleVRTools.CreateNodes(RootNode, DebugNodes, DebugScreens, GrabExistingNodes,TemplateCamera);
        MiddleVRTools.CreateViewportsAndCameras(DontChangeWindowGeometry, m_AllowRenderTargetAA);

        //AttachCameraCB();

        MiddleVRTools.Log(4, "[<] End of VR initialization script");
    }

    void AttachCameraCB()
    {
        Camera[] cameras = GameObject.FindObjectsOfType(typeof(Camera)) as Camera[];
    
        foreach (Camera cam in cameras)
        {
            if (cam.targetTexture != null)
            {
                cam.gameObject.AddComponent<VRCameraCB>();
            }
        }
    }

    void Start () {
        MiddleVRTools.Log(4,"[>] VR Manager Start.");

#if !UNITY_3_4 && !UNITY_3_5 && !UNITY_4_0 && !UNITY_4_0_1 && !UNITY_4_1
        m_AllowRenderTargetAA = true;
#endif

        InitializeVR();

        // Reset Manager's position so text display is correct.
        transform.position = new UnityEngine.Vector3(0, 0, 0);
        transform.rotation = new Quaternion();
        transform.localScale = new UnityEngine.Vector3(1, 1, 1);

        m_Wand = GameObject.Find("VRWand");

        if (ShowFPS) {
            guiText.enabled = true;
        } else {
            guiText.enabled = false;
        }

        if(ShowWand) {
            ShowWandGeometry(true);
        } else {
            ShowWandGeometry(false);
        }

        // Initialize navigation interaction technique
        switch( NavigationMethod )
        {
            case ENavigationMode.None:
                // None
                break;

            case ENavigationMode.Joystick:
                m_Wand.GetComponent<VRInteractionNavigationWandJoystick>().enabled = true;
                break;

            case ENavigationMode.Elastic:
                m_Wand.GetComponent<VRInteractionNavigationElastic>().enabled = true;
                break;

            case ENavigationMode.GrabWorld:
                m_Wand.GetComponent<VRInteractionNavigationGrabWorld>().enabled = true;
                break;

            default:
                break;
        }

        if (ForceQuality)
        {
#if UNITY_3_4
            QualitySettings.currentLevel = (QualityLevel)ForceQualityIndex;
#else
            QualitySettings.SetQualityLevel(ForceQualityIndex);
#endif
            bool useOpenGLQuadbuffer = MiddleVR.VRDisplayMgr.GetActiveViewport(0).GetStereo() && (MiddleVR.VRDisplayMgr.GetActiveViewport(0).GetStereoMode()==0); //VRStereoMode_QuadBuffer = 0
            if( !Application.isEditor && ( useOpenGLQuadbuffer || MiddleVR.VRClusterMgr.GetForceOpenGLConversion() ) )
            {
                m_NeedDelayedRenderingReset = true;
                m_RenderingResetDelay = 1;
            }
        }

        // Manage VSync after the quality settings 
        MiddleVRTools.ManageVSync();

        // Set AA from vrx configuration file
        QualitySettings.antiAliasing = m_AntiAliasingLevel;

        MiddleVRTools.Log(4, "[<] End of VR Manager Start.");
    }

    public void ShowWandGeometry(bool iState)
    {
        if( m_Wand != null )
        {
            foreach (Transform child in m_Wand.transform)
            {
                if (child.renderer != null)
                {
                    child.renderer.enabled = iState;
                }
            }
        }
    }

    void UpdateInput()
    {
        vrDeviceManager dmgr = MiddleVR.VRDeviceMgr;

        if (dmgr != null)
        {
            vrButtons wandButtons = dmgr.GetWandButtons();

            if (wandButtons != null)
            {
                WandButton0 = wandButtons.IsPressed(dmgr.GetWandButton0());
                WandButton1 = wandButtons.IsPressed(dmgr.GetWandButton1());
                WandButton2 = wandButtons.IsPressed(dmgr.GetWandButton2());
                WandButton3 = wandButtons.IsPressed(dmgr.GetWandButton3());
                WandButton4 = wandButtons.IsPressed(dmgr.GetWandButton4());
                WandButton5 = wandButtons.IsPressed(dmgr.GetWandButton5());
            }

            WandAxisHorizontal = dmgr.GetWandHorizontalAxisValue();
            WandAxisVertical   = dmgr.GetWandVerticalAxisValue();
        }
    }

    // Update is called once per frame
    void Update () {
        //MiddleVRTools.Log("VRManagerUpdate");

        if (m_isInit)
        {
            MiddleVRTools.Log(4, "[>] Unity Update - Start");

            if (kernel.GetFrame() >= m_FirstFrameAfterReset+1 && !m_isGeometrySet && !Application.isEditor)
            {
                if (!DontChangeWindowGeometry)
                {
                    displayMgr.SetUnityWindowGeometry();
                }
                m_isGeometrySet = true;
            }

            kernel.Update();
            UpdateInput();

            if (ShowFPS)
            {
                guiText.text = kernel.GetFPS().ToString("f2");
            }

            MiddleVRTools.UpdateNodes();

            if (m_displayLog)
            {
                string txt = kernel.GetLogString(true);
                print(txt);
                m_GUI.text = txt;
            }

            vrKeyboard keyb = MiddleVR.VRDeviceMgr.GetKeyboard();

            if (keyb != null && keyb.IsKeyToggled(MiddleVR.VRK_D) && (keyb.IsKeyPressed(MiddleVR.VRK_LSHIFT) || keyb.IsKeyPressed(MiddleVR.VRK_RSHIFT)))
            {
                ShowFPS = !ShowFPS;
                guiText.enabled = ShowFPS;
			}
			
			if (keyb != null && (keyb.IsKeyToggled(MiddleVR.VRK_W) || keyb.IsKeyToggled(MiddleVR.VRK_Z)) && (keyb.IsKeyPressed(MiddleVR.VRK_LSHIFT) || keyb.IsKeyPressed(MiddleVR.VRK_RSHIFT)))
			{
				ShowWand = !ShowWand;
				ShowWandGeometry(ShowWand);
			}

			// Toggle Fly mode on interactions
			if (keyb != null && keyb.IsKeyToggled(MiddleVR.VRK_F) && (keyb.IsKeyPressed(MiddleVR.VRK_LSHIFT) || keyb.IsKeyPressed(MiddleVR.VRK_RSHIFT)))
			{
				vrInteractionManager interMan = vrInteractionManager.GetInstance();
				uint interactionNb = interMan.GetInteractionsNb();
				for( uint i=0 ; i<interactionNb ; ++i )
				{
					vrProperty flyProp = interMan.GetInteractionByIndex(i).GetProperty("Fly");
					if( flyProp != null )
					{
						flyProp.SetBool( !flyProp.GetBool() );
					}
				}
			}

            DeltaTime = kernel.GetDeltaTime();

            MiddleVRTools.Log(4, "[<] Unity Update - End");
        }
        else
        {
            //Debug.LogWarning("[ ] If you have an error mentionning 'DLLNotFoundException: MiddleVR_CSharp', please restart Unity. If this does not fix the problem, please make sure MiddleVR is in the PATH environment variable.");
        }

        // If QualityLevel changed, we have to reset the Unity Manager
        if( m_NeedDelayedRenderingReset )
        {
            if( m_RenderingResetDelay == 0 )
            {
                MiddleVRTools.Log(3,"[ ] Graphic quality forced, reset Unity Manager.");
                MiddleVRTools.VRReset();
                MiddleVRTools.CreateViewportsAndCameras(DontChangeWindowGeometry, m_AllowRenderTargetAA);
                m_isGeometrySet = false;
                m_NeedDelayedRenderingReset = false;
            }
            else
            {
                --m_RenderingResetDelay;
            }
        }
    }

    void AddClusterScripts(GameObject iObject)
    {
        MiddleVRTools.Log(2, "[ ] Adding cluster sharing scripts to " + iObject.name);
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

    void SetupSimpleCluster()
    {
        if (MiddleVR.VRClusterMgr.IsCluster())
        {
            // Rigid bodies
            Rigidbody[] bodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];
            foreach (Rigidbody body in bodies)
            {
                if (!body.isKinematic)
                {
                    GameObject iObject = body.gameObject;
                    AddClusterScripts(iObject);
                }
            }

            // Character controller
            CharacterController[] ctrls = FindObjectsOfType(typeof(CharacterController)) as CharacterController[];
            foreach (CharacterController ctrl in ctrls)
            {
                GameObject iObject = ctrl.gameObject;
                AddClusterScripts(iObject);
            }
        }
    }


    void Awake()
    {
        UnityEngine.Random.seed = 99;
    }

    void DumpOptions()
    {
        MiddleVRTools.Log(3, "[ ] Dumping VRManager's options:");
        MiddleVRTools.Log(3, "[ ] - Config File : " + ConfigFile);
        MiddleVRTools.Log(3, "[ ] - Root Node : " + RootNode);
        MiddleVRTools.Log(3, "[ ] - Template Camera : " + TemplateCamera);
        MiddleVRTools.Log(3, "[ ] - Show Wand : " + ShowWand);
        MiddleVRTools.Log(3, "[ ] - Show FPS  : " + ShowFPS);
        MiddleVRTools.Log(3, "[ ] - Disable Existing Cameras : " + DisableExistingCameras);
        MiddleVRTools.Log(3, "[ ] - Grab Existing Nodes : " + GrabExistingNodes);
        MiddleVRTools.Log(3, "[ ] - Debug Nodes : " + DebugNodes);
        MiddleVRTools.Log(3, "[ ] - Debug Screens : " + DebugScreens);
        MiddleVRTools.Log(3, "[ ] - Quit On Esc : " + QuitOnEsc);
        MiddleVRTools.Log(3, "[ ] - Dont Change Window Geometry : " + DontChangeWindowGeometry);
        MiddleVRTools.Log(3, "[ ] - Simple Cluster : " + SimpleCluster);
        MiddleVRTools.Log(3, "[ ] - Force Quality : " + ForceQuality );
        MiddleVRTools.Log(3, "[ ] - Force QualityIndex : " + ForceQualityIndex );
        MiddleVRTools.Log(3, "[ ] - Anti-Aliasing Level : " + m_AntiAliasingLevel );
        MiddleVRTools.Log(3, "[ ] - Change World Scale : " + ChangeWorldScale);
        MiddleVRTools.Log(3, "[ ] - World Scale : " + WorldScale);
    }

    void OnApplicationQuit()
    {
        MiddleVRTools.VRDestroy(Application.isEditor);
    }
}
