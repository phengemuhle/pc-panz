using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using static Cinemachine.CinemachineTargetGroup;

public class EnemyMovement : MonoBehaviour {

    private AgroDetection agroDetection;
    private Animator animator;
    private NavMeshAgent navMeshAgent;
    private Transform target;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        agroDetection = GetComponent<AgroDetection>();
        agroDetection.OnAgro += AgroDetection_OnAgro;
        
    }

    void AgroDetection_OnAgro(Transform target)
    {
        this.target = target;
    }
    private void Update()
    {
        if (target != null)
        {
            navMeshAgent.SetDestination(target.position);
            float currentSpeed = navMeshAgent.velocity.magnitude;
            animator.SetFloat("Speed", currentSpeed);

        }
    }
}
