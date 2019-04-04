using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    public float movementSpeed = 1;
    public float MaxDistance = 10;
    public float MinDistance = 5;
    public float MaxAllowed = 3;

    void Start()
    {
        player = GameObject.Find("Player");
        movementSpeed = Random.Range(MinDistance, MaxDistance); 
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(player.transform.position, transform.position);
        if (distance < MaxAllowed)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, movementSpeed * Time.deltaTime);
        }
    }
}
