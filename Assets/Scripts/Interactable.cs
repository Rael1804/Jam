using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Material matInteracted;
    private Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    public void Interact()
    {
        ren.material = matInteracted;
    }
}
