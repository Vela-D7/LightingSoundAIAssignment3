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
        {
            // Idle when out of range
            animator.SetBool("isRunning", false);
            animator.SetTrigger("idle_axe");
            return;
        }

        if (distance > attackRange)
        {
            // Chase the player
            agent.SetDestination(player.position);
            animator.SetBool("isRunning", true);
            animator.SetTrigger("Run_axe");
        }
        else
        {
            // Attack the player
            agent.ResetPath();
            animator.SetBool("isRunning", false);

            // Choose attack based on some condition (for example, alternate between two attacks)
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("attack_0_axe") && !animator.GetCurrentAnimatorStateInfo(0).IsName("attack_1_axe"))
            {
                int attackChoice = Random.Range(0, 2); // Randomly choose an attack (0 or 1)
                if (attackChoice == 0)
                {
                    animator.SetTrigger("attack_0_axe");
                }
                else
                {
                    animator.SetTrigger("attack_1_axe");
                }
            }
        }
    }

    public void TakeDamage()
    {
        health--;
        animator.SetTrigger("GetDamage_Axe"); // Play a damage reaction animation

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
        animator.SetTrigger("Die_Axe"); // Play the death animation
        agent.enabled = false; // Stop movement
        Destroy(gameObject, 2f); // Remove after death animation
    }
}
