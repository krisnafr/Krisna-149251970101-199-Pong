using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private float timerSpeed;
    private float timerSize;
    public float PUDuration;
    private bool isPUSpeed;
    private bool isPUSize;
    private int initialSpeed;
    private Vector2 initialSize;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        initialSpeed = speed;
        initialSize = transform.localScale;
        timerSpeed = 0;
        timerSize = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
        if(isPUSpeed == true)
        {
            timerSpeed += Time.deltaTime;
            if (timerSpeed > PUDuration) 
            { 
                resetPaddleSpeed();
            } 
        }
        if(isPUSize == true)
        {
            timerSize += Time.deltaTime;
            if (timerSize > PUDuration) 
            { 
                resetPaddleLength();
            } 
        }
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return  Vector2.down * speed;
        }

        return Vector2.zero;
    }
    
    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
        if(upKey == KeyCode.W)
        {
            // Debug.Log("Paddle kiri: " + movement);
        }
        if(upKey == KeyCode.O)
        {
            // Debug.Log("Paddle kanan: " + movement);
        }
    }
    public void PUPaddleLength()
    {
        if(isPUSize == false)
        {
            transform.localScale *= new Vector2(1f,2f);
            isPUSize = true;
        }

    }
    public void PUPaddleSpeed()
    {
        if(isPUSpeed == false)
        {
            speed *= 2;
            isPUSpeed = true;
        }
    }
    private void resetPaddleLength()
    {
        transform.localScale = initialSize;
        isPUSize = false;
        timerSize -= PUDuration;
    }
    private void resetPaddleSpeed()
    {
        speed = initialSpeed;
        isPUSpeed = false;
        timerSpeed -= PUDuration;
    }
}
