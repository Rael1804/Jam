using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerSonambulo : MonoBehaviour
{
    public NavMeshAgent navMesh; 
    public Transform destino;

    public GameObject victoria;
    public GameObject derrota;

    void Start()
    {
        navMesh.destination= destino.position;
    }

    void OnTriggerEnter(Collider other){
        if(other.tag=="WayPoint"){
            if(other.gameObject.name == "WP (5)"){
                if(true){//victoria)
                    victoria.SetActive(true);
                    }else{
                        derrota.SetActive(true);
                        }//derrota
                        this.gameObject.SetActive(false);
            }else{
                destino= other.gameObject.GetComponent<Waypoints>().nextPoint;
                navMesh.destination= destino.position;  
            }
        }
    }
}
