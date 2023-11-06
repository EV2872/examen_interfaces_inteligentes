using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionConSilla : MonoBehaviour
{
    public delegate void Mensaje();
    public event Mensaje OnColisionSilla = delegate {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        // usamos esta silla para que no se produzca errores con los otros scripts de las sillas
        if (collision.gameObject.name == "Chaise003") {
            // lanzamos el evento
            OnColisionSilla();
        }
    }
}
