using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject pj;

    private float target_posX;
    private float target_posY;

    private float posX;
    private float posY;

    public float rightMax;
    public float leftMax;
    public float topMax;
    public float botMax;

    public float speed;
    public bool isOn = true;
    

    void Awake()
    {
        posX = target_posX + rightMax;
        posY = target_posY + topMax;
        transform.position = Vector3.Lerp(transform.position, new Vector3(posX, posY, -1), -1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move_Cam();
    }

    void Move_Cam()
    {
        if(isOn)
        {
            if(pj)
            {
                target_posX = pj.transform.position.x;
                target_posY = pj.transform.position.y;

                if(target_posX > rightMax && target_posX < leftMax){
                    posX = target_posX;
                }
                if(target_posY > topMax && target_posY < botMax){
                    posY = target_posY;
                }
            }
            transform.position = Vector3.Lerp(transform.position, new Vector3(posX, posY, -1), speed * Time.deltaTime);
        }
    }
}
