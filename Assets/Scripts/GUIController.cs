using UnityEngine;
using TMPro;

public class GUIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Referencia al texto para mostrar la puntuación en la interfaz
    [SerializeField] TextMeshProUGUI txtScore;

    [SerializeField] TextMeshProUGUI txtLives;

     private void OnGUI()
    {
        // Actualizamos el texto de la puntuación
        txtScore.text = string.Format("{0,3:D3}", GameManager.Score);  // Formateamos a 3 dígitos

        txtLives.text = GameManager.Lives.ToString();
    }
}
