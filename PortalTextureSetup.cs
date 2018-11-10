using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour {

    public Camera cameraDarkWorld;
    public Camera cameraLightWorld;

    public Material cameraMaterialDarkWorld;
    public Material cameraMaterialLightWorld;
	
	// Use this fo initialization
	void Start ()
    {
        if(cameraLightWorld.targetTexture != null)
        {
            cameraLightWorld.targetTexture.Release();
        }
        cameraLightWorld.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMaterialLightWorld.mainTexture = cameraLightWorld.targetTexture;

        if (cameraDarkWorld.targetTexture != null)
        {
            cameraDarkWorld.targetTexture.Release();
        }
        cameraDarkWorld.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMaterialDarkWorld.mainTexture = cameraDarkWorld.targetTexture;

	}
}
