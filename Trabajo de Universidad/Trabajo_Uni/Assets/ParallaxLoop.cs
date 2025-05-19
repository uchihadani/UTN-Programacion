using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxLoop : MonoBehaviour
{
    public Transform fondo1;
    public Transform fondo2;
    public float velocidad = 3f;

    private float anchoFondo;

    private void Start()
    {
        // Obtener ancho del sprite basándonos en el renderer
        SpriteRenderer sr = fondo1.GetComponent<SpriteRenderer>();
        anchoFondo = sr.bounds.size.x;
    }

    private void Update()
    {
        // Mover ambos fondos
        fondo1.Translate(Vector3.left * velocidad * Time.deltaTime);
        fondo2.Translate(Vector3.left * velocidad * Time.deltaTime);

        // Calcular ancho visible actualizado por si cambia resolución
        float alturaPantalla = Camera.main.orthographicSize * 3f;
        float relacionAspecto = (float)Screen.width / (float)Screen.height;
        float anchoPantalla = alturaPantalla * relacionAspecto;

        // Si fondo1 sale por la izquierda, lo movemos detrás del fondo2
        if (fondo1.position.x <= -anchoPantalla)
        {
            fondo1.position = new Vector3(fondo2.position.x + anchoFondo, fondo1.position.y, fondo1.position.z);
        }

        // Si fondo2 sale por la izquierda, lo movemos detrás del fondo1
        if (fondo2.position.x <= -anchoPantalla)
        {
            fondo2.position = new Vector3(fondo1.position.x + anchoFondo, fondo2.position.y, fondo2.position.z);
        }
    }
}
