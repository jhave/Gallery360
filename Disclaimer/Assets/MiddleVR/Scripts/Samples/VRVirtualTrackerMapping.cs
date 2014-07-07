/* VRVirtualTracker
 * MiddleVR
 * (c) i'm in VR
 */

using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRVirtualTrackerMapping : MonoBehaviour
{
	public string m_SourceTrackerName="VRPNTracker0.Tracker0";
	public string m_DestinationVirtualTrackerName="MyTracker";

	public bool UsePositionX = true;
	public bool UsePositionY = true;
	public bool UsePositionZ = true;
    
    public bool  UsePositionScale   = false;
    public float PositionScaleValue = 1.0f;

	public bool UseYaw       = true;
	public bool UsePitch     = true;
	public bool UseRoll      = true;

    private bool m_Init = false;
    
    // The trackers
    private vrTracker m_SourceTracker = null;
    private vrTracker m_DestinationVirtualTracker = null;
	
	// Start
	void Start () 
	{
		// Retrieve trackers by name
		m_SourceTracker             = MiddleVR.VRDeviceMgr.GetTracker(m_SourceTrackerName);
		m_DestinationVirtualTracker = MiddleVR.VRDeviceMgr.GetTracker(m_DestinationVirtualTrackerName);
		
		if( m_SourceTracker == null )
        {
            MiddleVRTools.Log("[X] VirtualTrackerMapping: Error : Can't find tracker '" + m_SourceTrackerName + "'.");
        }
        if( m_DestinationVirtualTracker == null )
		{
			MiddleVRTools.Log("[X] VirtualTrackerMapping: Error : Can't find tracker '" + m_DestinationVirtualTrackerName + "'.");
		}

        if (m_SourceTracker != null && m_DestinationVirtualTracker != null)
        {
            m_Init = true;
        }
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (m_Init == true)
        {
            // Multiply by scale value only if used
            if (UsePositionScale)
            {
                // Position
                if (UsePositionX)
                    m_DestinationVirtualTracker.SetX(PositionScaleValue * m_SourceTracker.GetX());
                // Inverting Unity Y and MiddleVR Z because of different coordinate systems
                if (UsePositionY)
                    m_DestinationVirtualTracker.SetZ(PositionScaleValue * m_SourceTracker.GetZ());
                // Inverting Unity Y and MiddleVR Z because of different coordinate systems
                if (UsePositionZ)
                    m_DestinationVirtualTracker.SetY(PositionScaleValue * m_SourceTracker.GetY());
            }
            else
            {
                // Position
                if (UsePositionX)
                    m_DestinationVirtualTracker.SetX(m_SourceTracker.GetX());
                // Inverting Unity Y and MiddleVR Z because of different coordinate systems
                if (UsePositionY)
                    m_DestinationVirtualTracker.SetZ(m_SourceTracker.GetZ());
                // Inverting Unity Y and MiddleVR Z because of different coordinate systems
                if (UsePositionZ)
                    m_DestinationVirtualTracker.SetY(m_SourceTracker.GetY());
            }

            // Orientation
            if (UseYaw)
                m_DestinationVirtualTracker.SetYaw(m_SourceTracker.GetYaw());
            if (UsePitch)
                m_DestinationVirtualTracker.SetPitch(m_SourceTracker.GetPitch());
            if (UseRoll)
                m_DestinationVirtualTracker.SetRoll(m_SourceTracker.GetRoll());

        }
	}
}
