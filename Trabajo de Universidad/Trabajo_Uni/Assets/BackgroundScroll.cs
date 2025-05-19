using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float velocidad = 2f;

    private void Update()
    {
        // Calcular ancho visible en pantalla en cada frame
        float alturaPantalla = Camera.main.orthographicSize * 2f;
        float relacionAspecto = (float)Screen.width / (float)Screen.height;
        float anchoPantalla = alturaPantalla * relacionAspecto;

        // Mover el fondo hacia la izquierda
        transform.Translate(Vector3.left * velocidad * Time.deltaTime);

        // Si sale completamente por la izquierda, reposicionarlo a la derecha
        if (transform.position.x <= -anchoPantalla)
        {
            transform.position += new Vector3(anchoPantalla * 2f, 0f, 0f);
        }
    }
}
