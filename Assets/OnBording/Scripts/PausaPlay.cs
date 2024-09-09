using UnityEngine;

public class PusaPlay : MonoBehaviour
{
    public GameObject panelPausa;

    void Start ()
    {
        panelPausa.SetActive(false);
    }
    public void Pausa() 
    {
        Time.timeScale = 0;
        panelPausa.SetActive(true);
    }

    public void Play () 
    {
        Time.timeScale = 1;
        panelPausa.SetActive(false);
    }
}
