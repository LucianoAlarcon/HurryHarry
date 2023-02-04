using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
    public float y, x;
    public float velMov = 5.0f;
    public float velRot = 200.0f;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Rotate(0 , 0, x * Time.deltaTime * velRot);
        transform.Translate(0, y * Time.deltaTime * velMov, 0);
        // transform.Translate(0, Time.deltaTime * 1, 0);

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

}
