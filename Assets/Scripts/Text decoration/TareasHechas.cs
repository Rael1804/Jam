using TMPro;
using UnityEngine;

public class TareasHechas : MonoBehaviour
{
    public TextMeshProUGUI cuchillo; 
    public TextMeshProUGUI charco;
    public TextMeshProUGUI ventana;
    public TextMeshProUGUI candado;
    public TextMeshProUGUI barrer;
    public TextMeshProUGUI cable;

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
