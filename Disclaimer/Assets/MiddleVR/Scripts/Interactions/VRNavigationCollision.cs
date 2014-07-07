using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using MiddleVR_Unity3D;

public class VRNavigationCollision : MonoBehaviour {

    public float  CollisionDistance = 0.20f;
    public string CollisionNodeName = "HeadNode";

    GameObject m_CollisionNode;
    GameObject m_NavigationNode;
    vrNode3D   m_VRNavigationNode;

    bool m_Fly = false;

    bool m_Initialized = false;

    Vector3 m_LastCollisionNodePosition;

    
    public void SetCollisionNode( GameObject iCollisionNode )
    {
        m_CollisionNode = iCollisionNode;
    }
    
    public void SetNavigationNode( GameObject iNavigationNode )
    {
        m_NavigationNode   = iNavigationNode;
        m_VRNavigationNode = MiddleVR.VRDisplayMgr.GetNode(iNavigationNode.name);

        if( m_VRNavigationNode == null )
        {
            MiddleVRTools.Log( 2, "[X] VRHeadCollision: the navigation node to set doesn't have a corresponding vrNode3D in MiddleVR nodes." );
        }
    }

    public void SetFly( bool iFly )
    {
        m_Fly = iFly;
    }

    // Use this public method from interaction scripts to initialize and start collision
    public void Initialize() 
    {
        if( m_CollisionNode!=null && m_NavigationNode!=null && m_VRNavigationNode!=null )
        {
            m_LastCollisionNodePosition = m_CollisionNode.transform.position;
            m_Initialized = true;
            MiddleVRTools.Log( 2, "[ ] VRHeadCollision: initialized" );
        }
        else
        {
            MiddleVRTools.Log( 2, "[X] VRHeadCollision: impossible to retrieve sepcified navigation or collision nodes" );
        }
    }


    void InitializeFromActiveNavigation()
    {
        // Search for navigation interaction parameters
        uint interactionNb = MiddleVR.VRInteractionMgr.GetInteractionsNb();

        if( interactionNb == 0 )
        {
            MiddleVRTools.Log( 4, "[~] VRHeadCollision: no interaction found in Interaction Manager" );
            return;
        }
        
        bool fly = true;
        string navNodeName = "";

        for( uint i=0 ; i<interactionNb ; ++i )
        {
            vrInteraction interaction = MiddleVR.VRInteractionMgr.GetInteractionByIndex(i);
            if( interaction.IsActive() && interaction.TagsContain("Navigation") )
            {
                // Get fly mode
                vrProperty flyProp = interaction.GetProperty("Fly");
                if( flyProp != null )
                {
                    fly = flyProp.GetBool();
                }
                
                // Get navigation node
                vrProperty navNodeProp = interaction.GetProperty("NavigationNode");
                if( navNodeProp != null )
                {
                    navNodeName = navNodeProp.GetObject().GetName();
                }

                break;
            }
        }

        // Initialize parameters from found ones
        SetCollisionNode ( GameObject.Find(CollisionNodeName) );
        SetNavigationNode( GameObject.Find(navNodeName) );
        SetFly( fly );

        // Try to start the collisions
        Initialize();
    }

    Vector3 ComputeReactionMovement( Vector3 iStartPosition, Vector3 iMovement )
    {
        Vector3 reactionMovement = Vector3.zero;

        RaycastHit hit; 
        if( Physics.SphereCast( iStartPosition, CollisionDistance, iMovement.normalized, out hit, iMovement.magnitude ) )
        {
            // Compute reaction vector
            Vector3 collisionNormal = hit.normal;
            if(!m_Fly)
            {
                collisionNormal.y = 0.0f;
            }

            if( Vector3.Dot( iMovement, collisionNormal ) < 0.0f )
            {
                reactionMovement = -Vector3.Project( iMovement, collisionNormal.normalized );
            }
        }

        return reactionMovement;
    }

    void Start () 
    {
    }

    // Update is called once per frame
    void Update () {
    
        if( !m_Initialized )
        {
            InitializeFromActiveNavigation();
        }

        if( m_NavigationNode == null || m_VRNavigationNode == null || m_CollisionNode == null )
        {
            return;
        }

        // Check if moved

        Vector3 startPos = m_LastCollisionNodePosition;
        Vector3 endPos   = m_CollisionNode.transform.position;
        Vector3 lastMovement = endPos-startPos;

        if( lastMovement.magnitude > 0.0f )
        {
            Vector3 reactionMovement = ComputeReactionMovement( startPos, lastMovement ); 

            // Update Unity and MVR versions of navigation node
            m_NavigationNode.transform.position += reactionMovement;
            m_VRNavigationNode.SetPositionWorld( (new vrVec3(m_NavigationNode.transform.position.x, m_NavigationNode.transform.position.y, m_NavigationNode.transform.position.z)).To((uint)VR3DEngine.VR3DEngine_Unity3D) );
        }

        m_LastCollisionNodePosition = m_CollisionNode.transform.position;
    }
}
