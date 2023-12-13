using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public int myScore;
    // Start is called before the first frame update
    void Start()
    {
        myScore = 0;
        Debug.Log("My Score is " + myScore);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            myScore++;
            Debug.Log("My Score is" + myScore);
            collision.gameObject.SetActive(false);
        }

        
    }
    public int GetScore() { return myScore; }
}
