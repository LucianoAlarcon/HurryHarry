using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WetFloor : MonoBehaviour
{
    public float newVel = 10f;
    private float originalVel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            originalVel = player.gameObject.GetComponent<MovPlayer>().velMov;
            player.gameObject.GetComponent<MovPlayer>().velMov = newVel;
        }
    }

        void OnTriggerExit2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            player.gameObject.GetComponent<MovPlayer>().velMov = originalVel;
        }
    }
}
