using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receptorEjer5 : MonoBehaviour
{

    // script que delega el evento
    colisionConSilla cSilla;
    GameObject zombie;
    GameObject[] arañas;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // cogemos el script que se lanza cuando colisiona con la silla
        cSilla = GameObject.Find("Zombie").GetComponent<colisionConSilla>();
        // suscribimos
        cSilla.OnColisionSilla += realizarMovimientos;
        arañas = GameObject.FindGameObjectsWithTag("spider");
        zombie = GameObject.Find("Zombie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void realizarMovimientos() {
        foreach (var araña in arañas)
        {
            // calcula la direccion, no hace falta lookAt porque estan en el mismo plano a 
            // diferencia de las sillas en el script receptorEjer4
            Vector3 direccion = zombie.transform.position - araña.transform.position;
            // avanzan las arañas en direccion al zombie
            araña.transform.Translate(direccion * speed * Time.deltaTime);
        }
    }
}
