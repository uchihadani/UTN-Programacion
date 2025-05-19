using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float velocidadRotacion;
    [SerializeField] private Vector3 position;
    [SerializeField] private GameObject SpawPoint;

    [SerializeField] private GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, SpawPoint.transform.position, transform.rotation);
        }

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        transform.Translate(horizontal * Time.deltaTime * velocidad, vertical * Time.deltaTime * velocidad, 0);
        transform.Rotate(0, 0, -horizontal * velocidadRotacion * Time.deltaTime);




    }

}
