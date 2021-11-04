using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 enemyMovement = new Vector3(0f, 0f, 0f);
    public float enemySpeed = 5;

    void Update()
    {
        Move();        
    }

    void Move()
    {
        enemyMovement = (GameManager.Instance.playerPosition - this.transform.position).normalized * enemySpeed * Time.deltaTime;
        transform.position += enemyMovement;

    }
}
