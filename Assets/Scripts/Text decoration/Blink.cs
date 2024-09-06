using UnityEngine;
using TMPro;
using System.Collections;

public class Blink : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; 
    public float blinkInterval = 1.0f;  
    public float fadeSpeed = 1.0f;     

    void Start()
    {
        if (textMeshPro == null)
        {
            textMeshPro = GetComponent<TextMeshProUGUI>();
        }

  
        StartCoroutine(FadeText());
    }

    IEnumerator FadeText()
    {
        while (true) 
        {
           
            yield return StartCoroutine(FadeOutText());

            yield return new WaitForSeconds(blinkInterval);

            yield return StartCoroutine(FadeInText());

            yield return new WaitForSeconds(blinkInterval);
        }
    }

    IEnumerator FadeOutText()
    {
        Color textColor = textMeshPro.color;
        while (textMeshPro.color.a > 0f)
        {
            textColor.a -= Time.deltaTime * fadeSpeed; 
            textMeshPro.color = textColor;          
            yield return null;                       
        }
    }

    IEnumerator FadeInText()
    {
        Color textColor = textMeshPro.color;
        while (textMeshPro.color.a < 1f)
        {
            textColor.a += Time.deltaTime * fadeSpeed; 
            textMeshPro.color = textColor;            
            yield return null;                     
        }
    }
}
