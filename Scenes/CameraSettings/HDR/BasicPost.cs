using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class BasicPost : MonoBehaviour
{

    private Material material;
    public Shader _shader;

    // Creates a private material used to the effect
    void Awake()
    {
        material = new Material(_shader);
    }

    // Postprocess the image
    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}