using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletMovement : MonoBehaviour
{
    [SerializeField] private int velocidad;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 1 * Time.deltaTime * velocidad, 0);

    }
}
