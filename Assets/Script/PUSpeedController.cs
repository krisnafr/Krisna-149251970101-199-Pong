using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitude;
    public PowerUpManager manager;
    private float timer;
    private void Start()
    {
        timer = 0;
    }
    private void Update() 
    { 
        timer += Time.deltaTime; 
 
        if (timer > manager.destroyInterval) 
        { 
            manager.RemovePowerUp(gameObject);
        } 
    } 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball) 
        { 
            ball.GetComponent<BallController>().PUSpeedActive(magnitude);
            manager.RemovePowerUp(gameObject);
        }  
    }
}
