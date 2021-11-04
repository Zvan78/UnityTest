using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Vector3 playerPosition = new Vector3(0f, 0f, 0f);

    private void Awake() // Se ejecuta antes del Start, lo primero que se va ejecutar 
    {
        Instance = this;
    }

    
}
