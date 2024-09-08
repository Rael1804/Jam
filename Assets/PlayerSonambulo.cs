using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerSonambulo : MonoBehaviour
{
    public NavMeshAgent navMesh; 
    public Transform destino;
    // Start is called before the first frame update
    void Start()
    {
        navMesh.destination= destino.position;
    }

    // Update is called once per frame
    /*void Update()
    {
        navMesh.destination= destino.position;
    }*/

    void OnTriggerEnter(Collider other){
        if(other.tag=="WayPoint"){
            destino= other.gameObject.GetComponent<Waypoints>().nextPoint;
            navMesh.destination= destino.position;   

        }
    }
}
