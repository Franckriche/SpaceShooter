using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGScroll : MonoBehaviour
{

    public float scroll_speed = 0.1f;

    private MeshRenderer _meshRenderer;

    private float x_Scroll;
    // Start is called before the first frame update
    void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
    }

    void Scroll()
    {
        x_Scroll = Time.time * scroll_speed;

        Vector2 offset = new Vector2(x_Scroll, 0f);
        _meshRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
