using TMPro;
using UnityEngine;

public class TareasHechas : MonoBehaviour
{
    public TextMeshPro cuchillo; 
    public TextMeshPro charco;
    public TextMeshPro ventana;
    public TextMeshPro candado;
    public TextMeshPro barrer;
    public TextMeshPro cable;

    public void SetTachado()
    {
            cuchillo.fontStyle |= FontStyles.Strikethrough;  
    }

    public void SetCharco()
    {
            charco.fontStyle |= FontStyles.Strikethrough;  
    }

    public void SetVentana()
    {
            ventana.fontStyle |= FontStyles.Strikethrough; 
    }

    public void SetCandado()
    {
            candado.fontStyle |= FontStyles.Strikethrough; 
    }

    public void SetBarrer()
    {
            barrer.fontStyle |= FontStyles.Strikethrough;  
    }

    public void SetCable()
    {
            cable.fontStyle |= FontStyles.Strikethrough;  
    }
}
