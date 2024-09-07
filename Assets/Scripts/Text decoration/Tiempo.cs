using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    public TextMeshProUGUI timerText; // Referencia al TextMeshProUGUI
    public float totalTime = 300f; // 5 minutos en segundos (5 * 60 = 300)
    private float currentTime;

    void Start()
    {
        // Inicializamos el tiempo al valor total
        currentTime = totalTime;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (currentTime > 0)
        {
            // Restamos el tiempo que ha pasado desde el último frame
            currentTime -= Time.deltaTime;

            // Asegurarnos de no ir por debajo de 0
            if (currentTime < 0)
            {
                currentTime = 0;
            }

            // Actualizar el texto del temporizador
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Convertir el tiempo en formato minutos:segundos
        int minutes = Mathf.FloorToInt(currentTime / 60); // Obtener los minutos
        int seconds = Mathf.FloorToInt(currentTime % 60); // Obtener los segundos

        // Formatear el texto como MM:SS
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}