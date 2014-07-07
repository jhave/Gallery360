using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;
using System;

public class VRInteractionNavigationGrabWorld : MonoBehaviour {

    public string Name = "InteractionNavigationGrabWorld";

    public string ReferenceNode  = "HandNode";
    public string NavigationNode = "CenterNode";

    vrNode3D m_ReferenceNode  = null;
    vrNode3D m_NavigationNode = null;

    public uint  WandActionButton = 0;

    vrInteractionNavigationGrabWorld m_it = null;


    // Use this for initialization
    void Start () {

        m_it = new vrInteractionNavigationGrabWorld(Name);
        GC.SuppressFinalize(m_it);

        MiddleVR.VRInteractionMgr.AddInteraction(m_it);
        MiddleVR.VRInteractionMgr.Activate(m_it);

        m_ReferenceNode        = MiddleVR.VRDisplayMgr.GetNode(ReferenceNode);
        m_NavigationNode       = MiddleVR.VRDisplayMgr.GetNode(NavigationNode);

        if ( m_ReferenceNode!= null && m_NavigationNode != null )
        {
            m_it.SetActionButton( WandActionButton );

            m_it.SetReferenceNode(m_ReferenceNode);
            m_it.SetNavigationNode(m_NavigationNode);
        }
        else
        {
            MiddleVR.VRLog( 2, "[X] VRInteractionNavigationGrabWorld: One or several nodes are missing." );
        }
    }

    // Update is called once per frame
    void Update () {
        // Nothing to do for this interaction, everything is done in the kernel
    }

    /*
    void OnApplicationQuit()
    {
        if( m_it != null )
        {
            //MiddleVR.VRInteractionMgr.DestroyInteraction(m_it);
            //m_it = null;
        }
    }*/
}
