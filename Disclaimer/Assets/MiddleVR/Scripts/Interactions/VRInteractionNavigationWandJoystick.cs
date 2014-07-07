using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;
using System;


public class VRInteractionNavigationWandJoystick : MonoBehaviour {
    public string Name = "InteractionNavigationWandJoystick";

    public string DirectionReferenceNode = "HandNode";
    public string NavigationNode = "CenterNode";
    public string TurnAroundNode = "HeadNode";

    vrNode3D m_DirectionReferenceNode = null;
    vrNode3D m_NavigationNode = null;
    vrNode3D m_TurnAroundNode = null;
    
    public float TranslationSpeed = 1.0f;
    public float RotationSpeed = 45.0f;

    public bool Fly = false;

    vrInteractionNavigationWandJoystick m_it = null;

    // Use this for initialization
    void Start () {
        
        m_it = new vrInteractionNavigationWandJoystick(Name);
        GC.SuppressFinalize(m_it);

        MiddleVR.VRInteractionMgr.AddInteraction(m_it);
        MiddleVR.VRInteractionMgr.Activate(m_it);

        m_DirectionReferenceNode = MiddleVR.VRDisplayMgr.GetNode(DirectionReferenceNode);
        m_NavigationNode = MiddleVR.VRDisplayMgr.GetNode(NavigationNode);
        m_TurnAroundNode = MiddleVR.VRDisplayMgr.GetNode(TurnAroundNode);

        if ( m_DirectionReferenceNode!= null && m_NavigationNode != null && m_TurnAroundNode != null )
        {
            m_it.SetDirectionReferenceNode(m_DirectionReferenceNode);
            m_it.SetNavigationNode(m_NavigationNode);
            m_it.SetTurnAroundNode(m_TurnAroundNode);
            m_it.SetTranslationSpeed(TranslationSpeed);
            m_it.SetFly(Fly);
        }
        else
        {
            MiddleVR.VRLog( 2, "[X] VRInteractionNavigationWandJoystick: One or several nodes are missing." );
        }
    }

    // Update is called once per frame
    void Update () {
        // Nothing to do for this interaction, everything is done in the kernel
    }

    void OnApplicationQuit()
    {
        if( m_it != null )
        {
            //MiddleVR.VRInteractionMgr.DestroyInteraction(m_it);
            //m_it = null;
            
        }
    }
}
