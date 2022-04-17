using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material currentMat ;
    public Material targetMat;
    public bool isClicked;
    void Start()
    {
     meshRenderer=GetComponent<MeshRenderer>();
     currentMat = meshRenderer.material;
    }

    private void OnMouseEnter()
    {
        if (!isClicked)
        {
            meshRenderer.material = targetMat;
        }
          
    }

    private void OnMouseExit()
    {
        meshRenderer.material = currentMat;
    }
    public void clickTo()
    {
        isClicked = true;
        meshRenderer.material = currentMat;
    }
}
