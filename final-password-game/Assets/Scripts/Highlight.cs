using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material currentMat ;
    public Material targetMat;
    void Start()
    {
     meshRenderer=GetComponent<MeshRenderer>();
     currentMat = meshRenderer.material;
    }

    private void OnMouseEnter()
    {
        meshRenderer.material = targetMat;   }

    private void OnMouseExit()
    {
        meshRenderer.material = currentMat;
    }
}
