using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar escenas

public class CambiarEscena : MonoBehaviour
{
    // Esta funci�n debe ser p�blica para aparecer en el OnClick
    public void CambiarASegundaEscena()
    {
        // Reemplaza "JuegoBolos" con el nombre exacto de tu escena
        SceneManager.LoadScene("JuegoDomino");
    }
}
