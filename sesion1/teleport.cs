using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // si la tecla T esta pulsada
        if (Input.GetKey(KeyCode.T)) {
            // creamos un vector con componentes aleatorias
            Vector3 nuevasPos = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 5f), Random.Range(-10f, 10f));
            // actualizamos posicion
            transform.position = nuevasPos;
        }
    }
}
