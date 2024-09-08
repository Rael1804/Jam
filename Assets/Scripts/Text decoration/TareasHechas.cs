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

        [HideInInspector] public int numTareasHechas;

        public void SetCuchillo()
        {
                cuchillo.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }

        public void SetCharco()
        {
                charco.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }

        public void SetVentana()
        {
                ventana.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }

        public void SetCandado()
        {
                candado.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }

        public void SetBarrer()
        {
                barrer.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }

        public void SetCable()
        {
                cable.fontStyle |= FontStyles.Strikethrough;
                numTareasHechas++;
        }
}
