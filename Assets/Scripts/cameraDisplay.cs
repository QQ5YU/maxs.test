using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraDisplay : MonoBehaviour
{
    // [SerializeField] Camera camera;
    public Camera camera;
    [SerializeField] RawImage rawImage;
    [SerializeField] RenderTexture renderTexture;
 
    private void Update() {
        capture();
    }
 
    private void capture() {
        camera.Render();
        RenderTexture activeRenderTexture = RenderTexture.active;
        RenderTexture.active = camera.targetTexture;
        Texture2D image = new Texture2D(renderTexture.width, renderTexture.height);
        image.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        image.Apply();
        RenderTexture.active = activeRenderTexture;
        rawImage.texture = image;
    }
}


