
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorDeEcena : MonoBehaviour
{
  public string nombreDelNivel;
  public void CambioDeEcena()
  {
    SceneManager.LoadScene(nombreDelNivel);
  }
}
