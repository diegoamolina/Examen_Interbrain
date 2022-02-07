using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Welcome : MonoBehaviour
{
    public GameObject uiObject;         //Objeto de interfaz

    void Start()                        //Inicio
    {
        GetComponent<Text>().color = Color.white;   //Seleccionar color de texto
        StartCoroutine(WaitforSec());               //Ejecutar rutina
    }

    IEnumerator WaitforSec()            //Rutina
    {
        yield return new WaitForSeconds(5);     //Esperar 5 segundos
        uiObject.SetActive(false);              //Desactivar objeto
    }
}
