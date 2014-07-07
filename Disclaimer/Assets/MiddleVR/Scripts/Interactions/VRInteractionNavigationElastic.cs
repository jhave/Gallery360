using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;
using System;

public class VRInteractionNavigationElastic : MonoBehaviour {
    public string Name = "InteractionNavigationElastic";

    public string ReferenceNode  = "HandNode";
    public string NavigationNode = "CenterNode";
    public string TurnAroundNode = "HeadNode";
    
    vrNode3D m_ReferenceNode  = null;
    vrNode3D m_NavigationNode = null;
	vrNode3D m_TurnAroundNode = null;

	public uint  WandActionButton = 0;
    
    public float TranslationSpeed = 1.0f;
    public float RotationSpeed    = 45.0f;

    public float DistanceThreshold = 0.025f;
    public float AngleThreshold    = 5.0f;

    public bool UseRotationYaw   = true;

    public bool Fly           = false;

    public GameObject       ElasticRepresentationPrefab;
    GameObject              m_ElasticRepresentationObject;
    VRElasticRepresentation m_ElasticRepresentation; 

    vrInteractionNavigationElastic m_it = null;

    bool m_Initialized = false;
    Transform m_VRRootNode = null;

    // Use this for initialization
    void Start () {
        
        m_it = new vrInteractionNavigationElastic(Name);
        GC.SuppressFinalize(m_it);

        MiddleVR.VRInteractionMgr.AddInteraction(m_it);
        MiddleVR.VRInteractionMgr.Activate(m_it);

        m_ReferenceNode  = MiddleVR.VRDisplayMgr.GetNode(ReferenceNode);
        m_NavigationNode = MiddleVR.VRDisplayMgr.GetNode(NavigationNode);
        m_TurnAroundNode = MiddleVR.VRDisplayMgr.GetNode(TurnAroundNode);
        
        if ( m_ReferenceNode!= null && m_NavigationNode != null && m_TurnAroundNode != null )
		{
			m_it.SetActionButton( WandActionButton );

            m_it.SetReferenceNode(m_ReferenceNode);
            m_it.SetNavigationNode(m_NavigationNode);
            m_it.SetTurnAroundNode(m_TurnAroundNode);
            
            m_it.SetTranslationSpeed(TranslationSpeed);
            m_it.SetRotationSpeed(RotationSpeed);
            
            m_it.SetDistanceThreshold( DistanceThreshold );
            m_it.SetAngleThreshold(AngleThreshold);

            m_it.SetUseRotationYaw(UseRotationYaw);

            m_it.SetFly(Fly);
        }
        else
        {
            MiddleVR.VRLog( 2, "[X] VRInteractionNavigationElastic: One or several nodes are missing." );
        }
    }

    // Update is called once per frame
    void Update () {
        // Nothing to do for this interaction, everything is done in the kernel

        if( !m_Initialized )
        {
            if( GameObject.Find("VRManager").GetComponent<VRManagerScript>().RootNode != null )
            {
                m_VRRootNode = GameObject.Find("VRManager").GetComponent<VRManagerScript>().RootNode.transform;
            }

            m_Initialized = true;
        }
 
        if( ElasticRepresentationPrefab == null )
        {
            MiddleVRTools.Log( "[X] VRInteractionNavigationElastic error: bad elastic prefab reference" );
            return;
        }

        if( m_it.HasNavigationStarted() )
        {
            m_ElasticRepresentationObject = (GameObject)GameObject.Instantiate( ElasticRepresentationPrefab );
            m_ElasticRepresentationObject.transform.parent = m_VRRootNode;
            m_ElasticRepresentation =  m_ElasticRepresentationObject.GetComponent<VRElasticRepresentation>();
            UpdateElasticRepresentation();
        }
        else if( m_it.IsNavigationRunning() )
        {
            UpdateElasticRepresentation();
        }
        else if( m_it.IsNavigationStopped() && m_ElasticRepresentation != null )
        {
            GameObject.Destroy( m_ElasticRepresentationObject );
        }
    }

    void UpdateElasticRepresentation()
    {
        if( m_ElasticRepresentation == null )
        {
            MiddleVR.VRLog( 2, "[X] VRInteractionNavigationElastic error: bad elastic representation reference" );
            return;
        }

        Vector3 startPosition = MiddleVRTools.ToUnity( m_it.GetInteractionStartWorldMatrix().GetTranslation() );
        Vector3 endPosition   = MiddleVRTools.ToUnity( m_ReferenceNode.GetPositionWorld() );
        m_ElasticRepresentation.SetElasticPoints( startPosition, endPosition );
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
