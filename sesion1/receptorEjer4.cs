using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receptorEjer4 : MonoBehaviour
{
    // script que delega (se me olvido cambiarle el nombre)
    NewBehaviourScript dPizarra;
    // vector de gameobjects
    GameObject[] macetas;
    GameObject[] sillas;
    GameObject zombie;
    float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        // recogemos el script que lanza el evento dependiendo de la distancia a la pizarra
        dPizarra = GameObject.Find("Zombie").GetComponent<NewBehaviourScript>();
        // nos suscribimos
        dPizarra.OnCercaDePizarra += realizarMovimientos;
        // guardamos todas las macetas con ese tag
        macetas = GameObject.FindGameObjectsWithTag("maceta");
        // guardamos todas las sillas con ese tag
        sillas = GameObject.FindGameObjectsWithTag("silla");
        zombie = GameObject.Find("Zombie");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void realizarMovimientos() {
        foreach (var maceta in macetas)
        {
            // cremos una posicion aleatoria
            Vector3 nuevasPos = new Vector3(Random.Range(-10f, 10f), Random.Range(0f, 5f), Random.Range(-10f, 10f));
            // actualizamos la posicion de la maceta
            maceta.transform.position = nuevasPos;
        }
        foreach (var silla in sillas)
        {
            // hacemos que apunten a el zombie para que no se desplazen en una direccion erronea
            // porque no tiene el mismo valor del eje y
            silla.transform.LookAt(zombie.transform);
            // calculamos la direccion
            Vector3 direccion = zombie.transform.position - silla.transform.position;
            // desplazamos la silla en direccion al zombie
            silla.transform.Translate(direccion * speed * Time.deltaTime);
        }
    }
}
