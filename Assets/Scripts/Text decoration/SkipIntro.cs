using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipIntro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;
    public GameObject tiempo;
   
    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Return))  // KeyCode.Return es la tecla Enter
        {
            // Aquí colocas la acción que quieres que ocurra cuando se presiona "Enter"
            canvas.SetActive(false);
            tiempo.SetActive(true);
        }
    }
}
