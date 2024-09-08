using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CameraEnd : MonoBehaviour
{
    public Transform placeEnd;
    public Transform placeLookAtEnd;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.tiempo.currentTime < 0.1f)
        {
            transform.DOMove(placeEnd.position, 0.3f);
            transform.DOLookAt(placeLookAtEnd.position, 0.3f);
        }
    }
}
