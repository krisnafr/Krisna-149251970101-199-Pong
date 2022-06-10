using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public int minSpeed;
    public int maxSpeed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
        BallSpeed();
        Debug.Log("velo "+rig.velocity);
    }
    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 1);
        rig.velocity = -rig.velocity;
    } 

    public void BallSpeed()
    {
        if(rig.velocity.x < minSpeed && rig.velocity.x > -minSpeed)
        {
            if(rig.velocity.x >= 0)
            {
                rig.velocity = new Vector2(minSpeed, rig.velocity.y);
            }
            else if(rig.velocity.x < 0)
            {
                rig.velocity = new Vector2(-minSpeed, rig.velocity.y);
            }
        }

        if(rig.velocity.x > maxSpeed)
        {
            rig.velocity = new Vector2(maxSpeed, rig.velocity.y);
        }
        if(rig.velocity.x < -maxSpeed)
        {
            rig.velocity = new Vector2(-maxSpeed, rig.velocity.y);
        }

        if(rig.velocity.y < minSpeed && rig.velocity.y > -minSpeed)
        {
            if(rig.velocity.y >= 0)
            {
                rig.velocity = new Vector2(rig.velocity.x, minSpeed);
            }
            else if(rig.velocity.y < 0)
            {
                rig.velocity = new Vector2(rig.velocity.x, -minSpeed);
            }
        }

        if(rig.velocity.y > maxSpeed)
        {
            rig.velocity = new Vector2(rig.velocity.x, maxSpeed);
        }
        if(rig.velocity.y < maxSpeed)
        {
            rig.velocity = new Vector2(rig.velocity.x, -maxSpeed);
        }
    }
}
