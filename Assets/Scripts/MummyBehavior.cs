using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MummyBehavior : MonoBehaviour
{
    public int health = 3; // Mummy's health
    public Transform player; // Reference to the player
    public float attackRange = 1.0f; // Range for attacks
    public float waitRange = 3f; // Range for threatening the player
    private bool isDead = false;
    private Animator animator;
    private NavMeshAgent agent;

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

        // Debug to confirm Animator parameters exist
        Debug.Assert(animator != null, "Animator is missing on the mummy!");
    }

    void Update()
    {
        if (isDead) return;

        // Calculate the distance between the mummy and the player
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > waitRange)
        {
            // Idle state
            animator.SetBool("Run", false);
            animator.SetTrigger("Idle");
        }
        else if (distance > attackRange)
        {
            // Threaten the player
            animator.SetBool("Run", false);
            animator.SetTrigger("Threaten");
        }
        else
        {
            // Attack the player
            agent.ResetPath(); // Stop movement
            animator.SetBool("Run", false);

            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("Atack"))
            {
                animator.SetTrigger("Atack");
            }
        }
    }

    public void TakeDamage()
    {
        if (isDead) return;

        health--;
        animator.SetTrigger("Gd"); // Play damage animation

        if (health <= 0)
        {
            Die();
        }
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
        animator.SetTrigger("Die"); // Play death animation
        agent.enabled = false; // Disable movement
        Destroy(gameObject, 2f); // Destroy after 2 seconds
    }
}
