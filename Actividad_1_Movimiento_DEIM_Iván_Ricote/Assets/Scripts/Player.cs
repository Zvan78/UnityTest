using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5;
        
    void Update()
    {
        Move();

        Restart();

        Teleport();

        GameManager.Instance.playerPosition = this.transform.position;
    }
    void Move()
    {
        //Tecla derecha > Movimiento a la derecha
        if (Keyboard.current.dKey.isPressed)
        {
            transform.position += new Vector3(playerSpeed * Time.deltaTime, 0f, 0f);
        }

        // Tecla izquierda > Movimiento a la izquierda
        if (Keyboard.current.aKey.isPressed)
        {
            transform.position -= new Vector3(playerSpeed * Time.deltaTime, 0f, 0f);
        }

        // Tecla arriba > Movimiento para arriba
        if (Keyboard.current.wKey.isPressed)
        {
            transform.position += new Vector3(0f, playerSpeed * Time.deltaTime, 0f);
        }

        // Tecla abajo > Movimiento para abajo
        if (Keyboard.current.sKey.isPressed)
        {
            transform.position -= new Vector3(0f, playerSpeed * Time.deltaTime, 0f);
        }

    }

    void Restart()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }

    void Teleport()
    {
                
        if (this.transform.position.x >= 10f)
        {
            transform.position += new Vector3 (-20f,0f,0f);
        }

        if (this.transform.position.x <= -10f)
        {
            transform.position += new Vector3(20f, 0f, 0f);
        }

        if (this.transform.position.y >= 6f)
        {
            transform.position += new Vector3(0f, -12f, 0f);
        }

        if (this.transform.position.y <= -6f)
        {
            transform.position += new Vector3(0f, 12f, 0f);
        }
    }   

}
