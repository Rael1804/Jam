using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabable : Interactable
{
    public bool grabed = false;

    public override void Interact()
    {
        if (!grabed)
        {
            grabed = true;
        }
    }



    
}
