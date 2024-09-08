using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Door : Interactable
{
    public Transform door;
    public AudioClip openAudio;
    public AudioClip closeAudio;

    private AudioSource audio;

    private bool open = false;


    public void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        if (open)
        {
            audio.PlayOneShot(openAudio);
            door.DOLocalRotate(new Vector3(0, 0, 0), 1);
            //Debug.Log("Abriendo");
        }
        else
        {
            audio.PlayOneShot(closeAudio);
            door.DOLocalRotate(new Vector3(0, 90, 0), 1);
            //Debug.Log("Cerrando");
        }

        open = !open;
    }

    public void Update()
    {
        if( GameManager.Instance.tiempo.currentTime < 0.1f )
        {
            door.DOLocalRotate(new Vector3(0, 0, 0), 1);
        }
    }
}
