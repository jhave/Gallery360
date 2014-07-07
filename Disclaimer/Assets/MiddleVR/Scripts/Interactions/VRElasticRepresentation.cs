using UnityEngine;
using System.Collections;
using MiddleVR_Unity3D;

public class VRElasticRepresentation : MonoBehaviour {

    public GameObject ElasticRoot;
    public GameObject Elastic;

    // Use this for initialization
    void Start () {
        if( ElasticRoot==null || Elastic==null )
        {
            MiddleVR.VRLog( 2, "[X] VRElasticRepresentation error: bad ElasticRoot or Elastic GameObject reference" );
        }
    }

    // Update is called once per frame
    void Update () {
    }

    void SetElasticLength( float iLength)
    {
        float length = iLength/2.0f;

        Vector3 localScale = Elastic.transform.localScale;
        localScale.y = length;
        Elastic.transform.localScale = localScale;

        Vector3 localPosition = Elastic.transform.localPosition;
        localPosition.z = length;
        Elastic.transform.localPosition = localPosition;
    }

    void SetElasticStartPoint( Vector3 iPosition )
    {
        ElasticRoot.transform.localPosition = iPosition;
    }

    // Need to be called when elastic start point has already been defined
    void SetElasticEndPoint( Vector3 iPosition )
    {
        float elasticLength = (iPosition-ElasticRoot.transform.localPosition).magnitude;
        SetElasticLength( elasticLength );

        Quaternion rotation = Quaternion.FromToRotation( Vector3.forward, (iPosition-ElasticRoot.transform.localPosition).normalized );
        ElasticRoot.transform.localRotation = rotation;
    }

    // Only method to be public to simplify usage and force call order
    public void SetElasticPoints( Vector3 iStartPoint, Vector3 iEndPoint )
    {
        SetElasticStartPoint( iStartPoint );
        SetElasticEndPoint( iEndPoint );
    }
}
