
using UnityEngine;

public class AmongUsMovement : MonoBehaviour
{
    public float velocidadMovimiento = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocidadMovimiento * Time.deltaTime);
    }
}
