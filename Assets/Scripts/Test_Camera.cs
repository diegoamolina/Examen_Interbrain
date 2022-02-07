using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Camera : MonoBehaviour
{
    
    public Camera TestCamera;       //Objeto cámara
    public float horizontalSpeed;   //Velocidad horizontal de la cámara
    public float verticalSpeed;     //Velocidad vertical de la cámara
    public float horizontalRotationSpeed;   //Velocidad horizontal de rotación
    public float verticalRotationSpeed;     //Velocidad vertical de rotación
    float hor;      //Movimiento horizontal
    float ver;      //Movimiento vertical

    void Update()   //En cada frame
    {
        //Movimiento de la cámara
        //Guardar el movimiento de las flechas en las variables hor y ver
        hor = horizontalSpeed * Input.GetAxis("Horizontal") * horizontalRotationSpeed;
        ver = verticalSpeed * Input.GetAxis("Vertical") * verticalRotationSpeed;

        transform.Rotate (0,hor,0);             //Mover horizontalmente
        TestCamera.transform.Rotate(-ver,0,0);  //Mover verticalmente

        //Movimiento del jugador
        if(Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(0,0,0.1f);                 //Mover hacia adelante
        }
        else if(Input.GetKey(KeyCode.S)) 
            {
                transform.Translate(0,0,-0.1f);            //Mover hacia atrás
            }
            else if(Input.GetKey(KeyCode.A)) 
                {
                    transform.Translate(-0.1f,0,0);        //Mover hacia la izquierda
                }
                else if(Input.GetKey(KeyCode.D)) 
                    {
                        transform.Translate(0.1f,0,0);     //Mover hacia la derecha
                    }
    }
}
