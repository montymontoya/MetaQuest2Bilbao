using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string nombre;
    GameObject cabeza; // con este objeto podemos conocer el estatus de la cabeza [escalable a conocer datos de headset]
    //Con los objetos "mano" podemos conocer el estatus de las manos, por ejemplo si sostiene algo o no [escalable a conocer datos de mandos]
    Hand manoIzquierda;
    Hand manoDerecha;
    ControllerInput control;
    //MotionSystem Built_In


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
