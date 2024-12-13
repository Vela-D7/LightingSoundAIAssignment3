using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MummyBehavior3 : MonoBehaviour
{
    public int health = 3; // Health of the mummy
    public Transform player; // Reference to the player's transform
    public float attackRange = 1.0f; // Range within which the mummy can attack
    public float waitRange = 1f; // Range within which the mummy threatens the player
    private bool isDead = false;
    private Animator animator; // Reference to the animator
    private NavMeshAgent agent; // Reference to the NavMeshAgent for movement

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isDead) return;

        // Calculate the distance between the mummy and the player
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > waitRange)
        {
            // If out of range, play idle animation
            animator.SetBool("isRunning", false);
            animator.SetTrigger("idle_axe");
            return;
        }

        if (distance > attackRange)
        {
            // If within the waiting range, threaten the player
            animator.SetBool("isRunning", false);
            animator.SetTrigger("Treaten_sword_shield");
        }
        else
        {
            // If within the attack range, perform an attack
            agent.ResetPath();
            animator.SetBool("isRunning", false);

            // Randomly choose between two attacks
            if (!animator.GetCurrentAnimatorStateInfo(0).IsName("attack_0_axe") && !animator.GetCurrentAnimatorStateInfo(0).IsName("attack_1_axe"))
            {
                int attackChoice = Random.Range(0, 2); // Randomly select an attack (0 or 1)
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
        animator.SetTrigger("GetDamage_Axe"); // Play damage reaction animation

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
        animator.SetTrigger("Die_Axe"); // Play death animation
        agent.enabled = false; // Stop movement
        Destroy(gameObject, 2f); // Destroy the mummy after the death animation
    }
}
