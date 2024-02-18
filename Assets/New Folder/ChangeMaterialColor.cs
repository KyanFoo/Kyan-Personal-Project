using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    public Material materialToApply;
    public Color colorToApply;

    void Start()
    {
        ApplyMaterial();
        ChangeColor(colorToApply);
    }
    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.SetVector("_Direction", new Vector2(1.0f, 1.0f));
        }
    }

    void ApplyMaterial()
    {
        if (materialToApply != null)
        {
            GetComponent<Renderer>().material = materialToApply;
        }
        else
        {
            Debug.LogError("Material to apply is not set!");
        }
    }

    void ChangeColor(Color newColor)
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material.color = newColor;
        }
        else
        {
            Debug.LogError("Renderer component not found!");
        }
    }
}
