/* VRCustomEditor
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using UnityEditor;
using System.Collections;
using MiddleVR_Unity3D;
using UnityEditor.Callbacks;

[CustomEditor(typeof(VRManagerScript))]
public class VRCustomEditor : Editor
{
    //This will just be a shortcut to the target, ex: the object you clicked on.
    private VRManagerScript mgr;

    static private bool m_SettingsApplied = false;

    void Awake()
    {
        mgr = (VRManagerScript)target;

        if( !m_SettingsApplied )
        {
            ApplyVRSettings();
            m_SettingsApplied = true;
        }
    }

    void Start()
    {
        Debug.Log("MT: " + PlayerSettings.MTRendering);
    }

    public void ApplyVRSettings()
    {
        PlayerSettings.defaultIsFullScreen = false;
        PlayerSettings.displayResolutionDialog = ResolutionDialogSetting.Disabled;
        PlayerSettings.runInBackground = true;
        PlayerSettings.captureSingleScreen = false;
        PlayerSettings.MTRendering = false;
        //PlayerSettings.usePlayerLog = false;

        MiddleVRTools.Log("VR Player settings changed:");
        MiddleVRTools.Log("- DefaultIsFullScreen = false");
        MiddleVRTools.Log("- DisplayResolutionDialog = Disabled");
        MiddleVRTools.Log("- RunInBackground = true");
        MiddleVRTools.Log("- CaptureSingleScreen = false");
        //MiddleVRTools.Log("- UsePlayerLog = false");

        string[] names = QualitySettings.names;
        int qualityLevel = QualitySettings.GetQualityLevel();

        // Disable VSync on all quality levels
        for( int i=0 ; i<names.Length ; ++i )
        {
            QualitySettings.SetQualityLevel( i );
            QualitySettings.vSyncCount = 0;
        }

        QualitySettings.SetQualityLevel( qualityLevel );

        MiddleVRTools.Log("Quality settings changed for all quality levels:");
        MiddleVRTools.Log("- VSyncCount = 0");
    }

    public override void OnInspectorGUI()
    {

        GUILayout.BeginVertical();

        if (GUILayout.Button("Re-apply VR player settings"))
        {
            ApplyVRSettings();
        }

        if (GUILayout.Button("Pick configuration file"))
        {
            string path = EditorUtility.OpenFilePanel("Please choose MiddleVR configuration file", "", "vrx");
            MiddleVRTools.Log("[+] Picked " + path );
            mgr.ConfigFile = path;
            EditorUtility.SetDirty(mgr);
        }

        DrawDefaultInspector();
        GUILayout.EndVertical();
        
    }

    [PostProcessBuild]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject) 
    {
        string renderingPlugin32Path = pathToBuiltProject.Replace(".exe","_Data/Plugins/MiddleVR_UnityRendering.dll");
        string renderingPlugin64Path = pathToBuiltProject.Replace(".exe","_Data/Plugins/MiddleVR_UnityRendering_x64.dll");

        switch( target )
        {
            case BuildTarget.StandaloneWindows :
            {
                Debug.Log( "[ ] 32-bit build : delete " + renderingPlugin64Path );
                
                // Delete x64 version
                if( System.IO.File.Exists( renderingPlugin64Path ) )
                {
                    System.IO.File.Delete( renderingPlugin64Path );
                }

                break;
            }
            case BuildTarget.StandaloneWindows64 :
            {
                Debug.Log( "[ ] 64-bit build : delete " + renderingPlugin32Path + " and rename " + renderingPlugin64Path );
                
                // Delete 32b version...
                if( System.IO.File.Exists( renderingPlugin32Path ) )
                {
                    System.IO.File.Delete( renderingPlugin32Path );
                }
                
                // ...and rename x64 version
                if( System.IO.File.Exists( renderingPlugin64Path ) )
                {
                    System.IO.File.Move( renderingPlugin64Path, renderingPlugin32Path );
                }

                break;
            }
        }

        // Sign Application
        MiddleVRTools.SignApplication( pathToBuiltProject );
    }
}
