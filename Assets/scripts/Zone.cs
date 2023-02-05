using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zone : MonoBehaviour
{
    public int counter = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            counter++;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            counter--;
        }
    }
}
