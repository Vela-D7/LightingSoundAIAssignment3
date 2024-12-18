using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MummyBehavior2 : MonoBehaviour
{
    public int health = 3;
    public Transform player;
    public float attackRange = 2.0f;
    public float threatenRange = 10f;
    private bool isDead = false;
    private Animator animator;
    private NavMeshAgent agent;

    [SerializeField] private string _attack_1 = "Attack1"; // Animation trigger for attack

    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (isDead) return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance > threatenRange)
        {
            // Idle animation
            animator.SetTrigger("Idle");
            return;
        }

        if (distance > attackRange)
        {
            // Threaten animation
            animator.SetTrigger("Threaten");
        }
        else
        {
            // Perform attack
            animator.SetTrigger(_attack_1);
        }
    }

    public void TakeDamage()
    {
        health--;
        animator.SetTrigger("GetDamage");

        if (health <= 0) Die();
    }

    void Die()
    {
        isDead = true;
        animator.SetTrigger("Die");
        agent.enabled = false;
        Destroy(gameObject, 2f);
    }
}
