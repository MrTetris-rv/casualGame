using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpeed : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 0.3f;

    private MeshRenderer mesh_Renderer;
    private string tex = "_MainTex";

    private void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        Scroll();
    }

    private void Scroll()
    {
        Vector2 offset = mesh_Renderer.sharedMaterial.GetTextureOffset(tex);
        offset.y += Time.deltaTime * _scrollSpeed;

        mesh_Renderer.sharedMaterial.SetTextureOffset(tex, offset);
    }
}
