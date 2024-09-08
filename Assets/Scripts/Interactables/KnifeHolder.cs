using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class KnifeHolder : Interactable
{
    public TypeOfGrabable tipo;
    public GameObject boxWithAllTheKnifes;
    public override void Interact()
    {
        if (GameManager.Instance.grabableObject != null)
        {
            GameObject knife = GameManager.Instance.grabableObject;
            if (knife.GetComponent<Grabable>().typeOfobject == tipo)
            {
                Invoke("ChangeModel", 0.5f);

                Destroy(knife, 0.5f);
                knife.transform.DOMove(transform.position, 0.5f);
                knife.transform.DORotate(transform.rotation.eulerAngles, 0.5f);
                GameManager.Instance.tareas.doneTask(tipo);
            }
        }
    }

    public void ChangeModel()
    {
        this.gameObject.SetActive(false);
        Instantiate(boxWithAllTheKnifes, transform.position, transform.rotation);
    }
}
