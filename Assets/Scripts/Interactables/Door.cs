using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Door : Interactable
{
    public Transform door;

    private bool open = false;

    public override void Interact()
    {
        if (open)
        {
            door.DOLocalRotate(new Vector3(0, 0, 0), 1);
            //Debug.Log("Abriendo");
        }
        else
        {
            door.DOLocalRotate(new Vector3(0, 90, 0), 1);
            //Debug.Log("Cerrando");
        }

        open = !open;
    }
}
