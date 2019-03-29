using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    public float movementSpeed = 1;
    //int MaxDistance = 10;
    //int MinDistance = 5;

    void Start()
    {
        //GameObject.FindWithTag(Player);
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform);
        Vector3 localPosition = player.transform.position - transform.position;
        transform.Translate(localPosition.x * Time.deltaTime * movementSpeed, localPosition.y * Time.deltaTime * movementSpeed, localPosition.z * Time.deltaTime * movementSpeed);
        //transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
}
