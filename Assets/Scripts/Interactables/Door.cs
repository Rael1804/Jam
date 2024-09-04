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
        print(this.gameObject.name);

        if (open)
        {
            door.DORotate(new Vector3(0, 0, 0), 1);
        }
        else
        {
            door.DORotate(new Vector3(0, 90, 0), 1);
        }

        open = !open;
    }
}
