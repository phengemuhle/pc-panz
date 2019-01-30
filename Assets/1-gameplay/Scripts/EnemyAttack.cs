using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    [SerializeField]
    private float attackRefreshRate = 1.5f;

    private Health healthTarget;
    private AgroDetection agroDetection;
    private float attackTimer;

      
    private void Awake()
    {
        agroDetection = GetComponent<AgroDetection>();
        agroDetection.OnAgro += AgroDetection_OnAgro;
    }

    private void AgroDetection_OnAgro(Transform target)
    {
        Health health = target.GetComponent<Health>();
        if(health != null)
        {
            healthTarget = health;
        }
    }

    private void Update()
    {
        if(healthTarget != null)
        {
            attackTimer += Time.deltaTime;
            if (CanAttack())
            {
                Attack();
            }
        }
    }

    private bool CanAttack()
    {
        return attackTimer >= attackRefreshRate;
    }
    private void Attack()
    {
        attackTimer = 0;
        healthTarget.TakeDamage(1);
    }







}
