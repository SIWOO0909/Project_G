using UnityEngine;
using UnityEngine.UI;

public class RenderTextureToTexture2D : MonoBehaviour
{
    public RenderTexture renderTexture;
    public RawImage rawImage;

    void Start()
    {
        Texture2D tex = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
        RenderTexture.active = renderTexture;
        tex.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        tex.Apply();
        rawImage.texture = tex;
        RenderTexture.active = null;
    }
}