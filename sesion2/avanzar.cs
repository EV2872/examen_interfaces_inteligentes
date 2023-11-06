using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanzar : MonoBehaviour
{
    public float speed = 1;
    public float speedRotation = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        // si las flechas estan pulsadas rota a la vez de que mueve hacia delante
        if (movimientoHorizontal != 0) {
            transform.Rotate(Vector3.up, movimientoHorizontal * speedRotation * Time.deltaTime);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        // si no estan pulsadas solo se mueve hacia delante
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
