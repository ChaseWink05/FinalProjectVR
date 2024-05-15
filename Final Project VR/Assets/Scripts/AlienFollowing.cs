using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlienFollowing : MonoBehaviour
{
    public Transform patrolRoute;


    private NavMeshAgent agent;
    public Transform player;

    public float patrolSpeed = 5.0f;
    public float chaseSpeed = 1.0f;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>(); 
        agent.speed = 5.0f;

        player = GameObject.Find("PlayerController Variant").transform;
    }


    void Update()
    {
        // Only chase the player when they are inside the collider
        agent.speed = chaseSpeed;
        Vector3 directionToPlayer = player.position - agent.transform.position;
        Vector3 normalizedDirection = directionToPlayer.normalized;
        Vector3 destinationOffset = player.position - normalizedDirection * 1.2f;
        agent.destination = destinationOffset;

    }
}

