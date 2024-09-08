using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraInteract : MonoBehaviour
{
    //public float distToUse;
    //public LayerMask itemLayer;
    public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (target != null)
            {
                target.GetComponent<Interactable>().Interact();
            }
            //Scan();
        }
    }

    /*
    private void Scan()
    {
        Ray rayFordward = new Ray(transform.position, transform.TransformDirection(Vector3.forward));

        RaycastHit hit;
        if (Physics.Raycast(rayFordward, out hit, distToUse, itemLayer))
        {
            print("asdasd");
            GameObject target = hit.transform.gameObject;
            target.GetComponent<Interactable>().Interact();
        }
    }
    */

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            target = other.gameObject;
            //target.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            //target.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
            target = null;
        }
    }
}



