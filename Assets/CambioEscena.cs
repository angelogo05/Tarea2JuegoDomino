using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar escenas

public class CambiarEscena : MonoBehaviour
{
    // Esta función debe ser pública para aparecer en el OnClick
    public void CambiarASegundaEscena()
    {
        // Reemplaza "JuegoBolos" con el nombre exacto de tu escena
        SceneManager.LoadScene("JuegoDomino");
    }
}
