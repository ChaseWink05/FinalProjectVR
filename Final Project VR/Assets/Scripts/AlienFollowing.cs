using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//Source for this is the textbook we used in the ISP

public class AlienFollowing : MonoBehaviour
{
    public Transform patrolRoute;
    private NavMeshAgent agent;
    public Transform player; //This is for the player position

    public float patrolSpeed = 5.0f;
    public float chaseSpeed = 1.0f;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        agent.speed = 5.0f;
        //assigning this to a varibable because we need to know where the actual player is for the alien to follow in the update function. Getting this on the first frame
        player = GameObject.Find("PlayerController Variant").transform;
    }


    void Update()
    {
        // Only chase the player when they are inside the collider, this is the logic that tells the alien where to go and to make sure it is not inside of you
        agent.speed = chaseSpeed;
        Vector3 directionToPlayer = player.position - agent.transform.position;
        Vector3 normalizedDirection = directionToPlayer.normalized;
        Vector3 destinationOffset = player.position - normalizedDirection * 1.2f;
        agent.destination = destinationOffset;

    }
}

