using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePicture : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        //transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);


        // Input.GetAxis("Vertical")  [-1, 1] Math
        float axis_Y = transform.position.y + Input.GetAxis("Vertical") * speed * Time.deltaTime;


        transform.position = new Vector2(transform.position.x, axis_Y);

        //Vector3( X axis, Y axis, Z axis)

        //EXample:
        //transform.position  -> [output] (10, 17, 34);
        //transform.position = new VEctor3( 3, transform.position.y, 0)
        //transform.position  -> [output] (3, 17, 0);

        //10k
        //Time.deltaTime = [0,1] * 3 (speed)  = 1.5  30fps 60pfs 58=59  //to keep the speed constantly without matter the speed of diferent computers
        if (Input.GetKey(KeyCode.A)) //10 -3 -> -2
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);


        if (Input.GetKey("d")) //dont use Capital letter to dont crash the game
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);

    }
}
