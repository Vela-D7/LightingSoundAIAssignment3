using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerAttack : MonoBehaviour
{
    public GameObject sword; // Reference to the sword GameObject
    private Collider swordCollider;

    void Start()
    {
        swordCollider = sword.GetComponent<Collider>();
        swordCollider.enabled = false;
    }

    public void EnableSwordCollider()
    {
        swordCollider.enabled = true;
    }

    public void DisableSwordCollider()
    {
        swordCollider.enabled = false;
    }
}
