using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MummyBehavior : MonoBehaviour
{
    public int health = 3;
    public Transform player;
    public float attackRange = 2.0f;
    public float waitRange = 10f;
    private bool isDead = false;
    private Animator animator;
    private NavMeshAgent agent;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isDead) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > waitRange)
            return;


        if (distance > attackRange)
        {
            // Chase the player
            agent.SetDestination(player.position);
            animator.SetBool("isRunning", true);
        }
        else
        {
            // Attack the player
            agent.ResetPath();
            animator.SetBool("isRunning", false);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Attack_0"))
            {
                animator.SetTrigger("Attack_0");
            }
        }
    }

    public void TakeDamage()
    {
        health--;
        animator.SetTrigger("Gd"); // Play a damage reaction animation
        if (health <= 0) Die();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword"))
        {
            TakeDamage();
        }
    }

    void Die()
    {
        isDead = true;
        animator.SetTrigger("Die");
        agent.enabled = false; // Stop movement
        Destroy(gameObject, 2f); // Remove after death animation
    }
}

