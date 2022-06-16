using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleController : MonoBehaviour
{
    public Collider2D ball;
    // public Collider2D paddle;
    public PowerUpManager manager;
    public int type;
    private float timer;
    public List<GameObject> paddleList;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
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
            int randomIndex = Random.Range(0, paddleList.Count);
            if(type == 0)
            {
                paddleList[randomIndex].GetComponent<PaddleController>().PUPaddleLength();
            }
            if(type == 1)
            {
                paddleList[randomIndex].GetComponent<PaddleController>().PUPaddleSpeed();
            }
            manager.RemovePowerUp(gameObject);
        }  
    }
}
