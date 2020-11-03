using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgSpeed : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    private MeshRenderer mesh_Renderer;
    private string tex = "_MainTex";


    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(tex);
        offset.y += Time.deltaTime * scrollSpeed;

        mesh_Renderer.sharedMaterial.SetTextureOffset(tex, offset);
    }
}
