/************************************************************************************

Filename    :   OVRCamera.cs
Content     :   Interface to camera class
Created     :   January 8, 2013
Authors     :   Peter Giokaris

Copyright   :   Copyright 2013 Oculus VR, Inc. All Rights reserved.

Use of this software is subject to the terms of the Oculus LLC license
agreement provided at the time of installation or download, or which
otherwise accompanies this software in either electronic or hard copy form.

************************************************************************************/
using UnityEngine;
using System.Runtime.InteropServices;
using MiddleVR_Unity3D;

[RequireComponent(typeof(Camera))]

//-------------------------------------------------------------------------------------
// ***** OVRCamera
//
// OVRCamera is used to render into a Unity Camera class. 
// This component handles reading the Rift tracker and positioning the camera position
// and rotation. It also is responsible for properly rendering the final output, which
// also the final lens correction pass.
//
public class VRRiftCamera : MonoBehaviour
{
    [HideInInspector]
    public Vector2 _Center               = new Vector2(0.5f, 0.5f);
    [HideInInspector]
    public Vector2 _ScaleIn              = new Vector2(1.0f,  1.0f);
    [HideInInspector]
    public Vector2 _Scale                = new Vector2(1.0f, 1.0f);    
    [HideInInspector]
    public Vector4 _HmdWarpParam         = new Vector4(1.0f, 0.0f, 0.0f, 0.0f);

    // Chromatic aberration
    [HideInInspector]
    public Vector4 _ChromaticAberration = new Vector4(0.996f, 0.992f, 1.014f, 1.014f);    

    public bool IsInit = false;

    public Material RenderMaterial = null;

    // * * * * * * * * * * * * *

    void SetMaterialProperties()
    {
        // Set RenderMaterial properties
        RenderMaterial.SetVector("_Center",       _Center);
        RenderMaterial.SetVector("_Scale",        _Scale);
        RenderMaterial.SetVector("_ScaleIn",      _ScaleIn);
        RenderMaterial.SetVector("_HmdWarpParam", _HmdWarpParam);
        
        // Chromatic aberration
        Vector4 _CA = _ChromaticAberration;
        float rSquaredCoeffR = _CA[1] - _CA[0];
        float rSquaredCoeffB = _CA[3] - _CA[2];
        _CA[1] = rSquaredCoeffR;
        _CA[3] = rSquaredCoeffB;
        RenderMaterial.SetVector("_ChromaticAberration", _CA);
    }

    // Start
    void Start()
    {
        // Anti Aliasing must be at least 2 in the Rift     
        if( QualitySettings.antiAliasing < 2 )
        {
           QualitySettings.antiAliasing = 2;
        }

        Init();
    }

    protected void Init ()
    {
        if (RenderMaterial == null)
        {
            RenderMaterial = Resources.Load("OVRLensCorrectionMat", typeof(Material)) as Material;

            if (RenderMaterial == null)
                MiddleVRTools.Log(-1,"[RiftCamera] Failed to load OVRLensCorrectionMat.");
        }

        vrObject oculusDriver = MiddleVR.VRKernel.GetObject("OculusRift Tracker Driver");

        if (oculusDriver == null)
        {
            MiddleVRTools.Log(0,"[RiftCamera] No Oculus Rift driver found!");
            return;
        }

        float DistortionScale = oculusDriver.GetProperty("DistortionScale").GetFloat();
        float AR = oculusDriver.GetProperty("AspectRatio").GetFloat();
        float K0 = oculusDriver.GetProperty("K0").GetFloat();
        float K1 = oculusDriver.GetProperty("K1").GetFloat();
        float K2 = oculusDriver.GetProperty("K2").GetFloat();
        float K3 = oculusDriver.GetProperty("K3").GetFloat();

        float OffsetLensLeft  = oculusDriver.GetProperty("OffsetLensLeft").GetFloat();
        float OffsetLensRight = oculusDriver.GetProperty("OffsetLensRight").GetFloat();

        //print("DistortionScale: " + DistortionScale);
        //print("AspectRatio: " + AR);

        //float LensSeparationDistance = oculusDriver.GetProperty("LensSeparationDistance").GetFloat();

        // Get the distortion scale and aspect ratio to use when calculating distortion shader
        float distortionScale = 1.0f / DistortionScale;
        float aspectRatio = AR;

        float LensOffsetLeft  = OffsetLensLeft;
        float LensOffsetRight = OffsetLensRight;

        // These values are different in the SDK World Demo; Unity renders each camera to a buffer
        // that is normalized, so we will respect this rule when calculating the distortion inputs
        float NormalizedWidth = 1.0f;
        float NormalizedHeight = 1.0f;

        _Scale.x = (NormalizedWidth / 2.0f) * distortionScale;
        _Scale.y = (NormalizedHeight / 2.0f) * distortionScale * aspectRatio;
        _ScaleIn.x = (2.0f / NormalizedWidth);
        _ScaleIn.y = (2.0f / NormalizedHeight) / aspectRatio;
        _HmdWarpParam.x = K0;
        _HmdWarpParam.y = K1;
        _HmdWarpParam.z = K2;
        _HmdWarpParam.w = K3;

        if (name.Contains("Left"))
        {
            float lensOffset = 0.5f + (LensOffsetLeft * 0.5f);
            _Center.x = lensOffset;
        }

        if (name.Contains("Right"))
        {
            float lensOffset = 0.5f + (LensOffsetRight * 0.5f);
            _Center.x = lensOffset;
        }

        _Center.y = 0.5f;

        if (RenderMaterial != null)
        {
            SetMaterialProperties();
        }
        else
        {
            print("NOMAT");
        }

        IsInit = true;
    }

    // OnRenderImage
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        SetMaterialProperties();

        // Draw to final destination
        if(RenderMaterial!= null)
        {
            // Render with distortion
            Graphics.Blit(source, destination, RenderMaterial);
        }
        else
        {
            // Pass through
            Graphics.Blit(source, destination);			
        }
    }
}
