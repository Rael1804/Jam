using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform grabablePosition;
    public static GameManager Instance { get { return _instance; } }
    public int maxFps = 144;

    [HideInInspector] public GameObject grabableObject;
    [HideInInspector] public TareasHechas tareas;


    private static GameManager _instance;

    public void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            QualitySettings.vSyncCount = 1;
            Application.targetFrameRate = maxFps;
            tareas = GetComponent<TareasHechas>();
        }

        DontDestroyOnLoad(gameObject);
    }
}
