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


        public void doneTask(TypeOfGrabable typeOfTask)
        {
                numTareasHechas++;
                switch (typeOfTask)
                {

                        case TypeOfGrabable.Broom:
                                barrer.fontStyle |= FontStyles.Strikethrough;
                                break;
                        case TypeOfGrabable.Hammer:
                                ventana.fontStyle |= FontStyles.Strikethrough;
                                break;
                        case TypeOfGrabable.Key:
                                candado.fontStyle |= FontStyles.Strikethrough;
                                break;
                        case TypeOfGrabable.Knife:
                                cuchillo.fontStyle |= FontStyles.Strikethrough;
                                break;
                        case TypeOfGrabable.Tape:
                                cable.fontStyle |= FontStyles.Strikethrough;
                                break;
                        case TypeOfGrabable.Towel:
                                charco.fontStyle |= FontStyles.Strikethrough;
                                break;

                }
        }
}
