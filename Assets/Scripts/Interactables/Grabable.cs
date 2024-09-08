using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Scripting;

public class Grabable : Interactable
{
    private Rigidbody rb;
    private BoxCollider col;

    public void Awake()
    {
        col = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
    }

    public override void Interact()
    {
        if (GameManager.Instance.grabableObject != null)
        {
            GameManager.Instance.grabableObject.transform.parent = null;
            GameManager.Instance.grabableObject.GetComponent<Rigidbody>().isKinematic = false;
        }
        GameManager.Instance.grabableObject = this.gameObject;
        rb.isKinematic = true;
        transform.parent = GameManager.Instance.grabablePosition;
        transform.DOLocalMove( Vector3.zero, 0.5f);
        transform.DOLocalRotate( Vector3.forward * 45, 0.5f);
    }

}
