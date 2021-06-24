using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    NavMeshAgent NavMeshAgent;
    float distanceToTarget = Mathf.Infinity;

    void Start()
    {
        NavMeshAgent = GetComponent<NavMeshAgent>();    
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
            NavMeshAgent.SetDestination(target.position);
        } 
    }
}
