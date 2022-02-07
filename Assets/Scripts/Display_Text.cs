using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_Text : MonoBehaviour
{
    public GameObject uiObject; //Referencia a mensaje canvas
    public GameObject player;   //Referencia al usuario
    private bool inside;        //Variable que indica dentro o fuera de un área
    private GameObject[] thisTypeOfObjects;     //Referencia a todos los objetos de este tipo

    void Start ()   //Inicio
    {
        uiObject.SetActive(false);                  //El mensaje inicia inactivo
        inside = false;                             //El usuario no está en un área de interacción
        player = GameObject.FindWithTag("Player");  //Obtener la referencia al usuario
    }
    
    void OnTriggerEnter (Collider other)    //Dentro del área de interacción
    {
        uiObject.SetActive(true);	//Activar objeto
        inside = true;              //El usuario está en el área
    }

    void OnTriggerExit (Collider other)     //Fuera del área de interacción
    {
        uiObject.SetActive(false);	//Desactivar objeto
        inside = false;             //El usuario no está en el área
    }

    void OnGUI()
    {
        //Si dentro del área de interacción el jugador oprime espacio
        if (inside && Event.current.Equals(Event.KeyboardEvent(KeyCode.Space.ToString())))	//Al oprimir espacio
            {
                switch(this.tag)    //Distinguir el tipo de objeto y darlo como equipado
                    {
                        case "OxygenTank":
                            player.GetComponent<Player>().oxygenEquiped = true;
                            break;
                        case "Hat":
                            player.GetComponent<Player>().hatEquiped = true;
                            break;
                        case "Clothing":
                            player.GetComponent<Player>().clothingEquiped = true;
                            break;
                        case "Gloves":
                            player.GetComponent<Player>().glovesEquiped = true;
                            break;
                    }
                uiObject.SetActive(false);      //Desactivar mensaje

                //Apuntar a todos los objetos de este tipo
                thisTypeOfObjects = GameObject.FindGameObjectsWithTag(this.tag); 

                //Desactivar todos los objetos de este tipo
                foreach (GameObject thisobject in thisTypeOfObjects)
                    {
                        thisobject.SetActive(false);    //Desactivar cada objeto
                    }
            }
    }
}
