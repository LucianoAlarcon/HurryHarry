using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text textProx;
    public GameObject state1;
    public GameObject state2;
    public GameObject state3;

    private int theZone = 0;

    public int bigZone;
    public int mediumZone;
    public int smallZone;

    public float timer = 0;
    public TMP_Text timerText;

    
    // Start is called before the first frame update
    void Start()
    {
        textProx.text = theZone.ToString();
        state1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        bigZone = GameObject.FindGameObjectWithTag("BigZone").GetComponent<Zone>().counter;
        mediumZone = GameObject.FindGameObjectWithTag("MediumZone").GetComponent<Zone>().counter;
        smallZone = GameObject.FindGameObjectWithTag("SmallZone").GetComponent<Zone>().counter;
        onCollisionZone();

        timer -= Time.deltaTime;

        timerText.text = "" + timer.ToString("f1");
    }

    void onCollisionZone()
    {
        if(bigZone == 1)
        {
            state1.SetActive(false);
            state2.SetActive(true);
            if(mediumZone == 1)
            {
                state2.SetActive(false);
                state3.SetActive(true);
                if(smallZone == 1)
                {
                    textProx.text = theZone.ToString();
                } else {
                    textProx.text = theZone.ToString();
                }
            } else {
                state3.SetActive(false);
            }
        } else {
            state1.SetActive(true);
            state2.SetActive(false);
        }
    }
}
