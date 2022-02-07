using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    //Variables de objectos equipados
    public bool oxygenEquiped = false;
    public bool hatEquiped = false;
    public bool clothingEquiped = false;
    public bool glovesEquiped = false;

    //Cartel de victoria
    public GameObject uiObject;

    void Update()       //Verificar en cada frame
    {
        //Condición de victoria
        if(hatEquiped&clothingEquiped&glovesEquiped&oxygenEquiped)
        {
            uiObject.SetActive(true);   //Mostrar cartel de victoria
        }

        //Salir del juego
        if(Input.GetKey("escape"))
        Application.Quit();
    }
}
