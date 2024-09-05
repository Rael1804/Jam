using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        SpawnObjetos();
    }

    void SpawnObjetos()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        // Instancia el objeto en el spawn point seleccionado
        GameObject instancia = Instantiate(objeto, 
                                           spawnPoints[randomIndex].position, 
                                           spawnPoints[randomIndex].rotation, 
                                           spawnPoints[randomIndex]);
   
    }
}
