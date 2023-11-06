using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // tipo de evento
    public delegate void Mensaje();
    // evento que vamos a delegar
    public event Mensaje OnCercaDePizarra = delegate {};
    GameObject pizarra;
    float distancia = 10;
    // Start is called before the first frame update
    void Start()
    {
        pizarra = GameObject.Find("Tableau");
    }

    // Update is called once per frame
    void Update()
    {
        // si la distancia a la pizarra es menor a la establecida lanza el evento
        if (Vector3.Distance(transform.position, pizarra.transform.position) < distancia) {
            OnCercaDePizarra();
        }
    }
}
