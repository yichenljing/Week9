using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour { 

    public float speed = 0.003f; //declare a speed for player moving
    public KeyCode upbutton;    
    public KeyCode downbutton;
    public KeyCode leftbutton;
    public KeyCode rightbutton;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        // Vector3 moveAmt = new Vector3();
        if (Input.GetKey(upbutton))    //if player press upbotton
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y ,
                                             transform.position.z + speed // move forward
                                                );
        }
        if (Input.GetKey(downbutton)) //if player press downbotton
        {
            transform.position = new Vector3(transform.position.x,
                                             transform.position.y ,
                                             transform.position.z - speed // move backward
                                                );
        }
        if (Input.GetKey(leftbutton)) //if player press leftbotton
        {
            transform.position = new Vector3(transform.position.x - speed, //move left
                                             transform.position.y,
                                             transform.position.z
                                                );
        }
        if (Input.GetKey(rightbutton))  //if player press rightbotton
        {
            transform.position = new Vector3(transform.position.x + speed, //move right
                                               transform.position.y,
                                               transform.position.z
                                                );

        }

    }
}
