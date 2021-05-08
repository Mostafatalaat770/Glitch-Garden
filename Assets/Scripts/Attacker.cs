using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float movementSpeed = 0f;
    Animator animator;
    [SerializeField] int damage = 50;
    GameObject target;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        UpdateAnimationState();
    }
    public void SetMovementSpeed(float movementSpeed)
    {
        this.movementSpeed = movementSpeed;
    }
    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        this.target = target;
    }

    private void HitTarget()
    {
        if (!target)
        {
            return;
        }

        var health = target.GetComponent<Health>();
        if (health)
            health.Hit(damage);
    }

    private void UpdateAnimationState()
    {
        if (!target)
        {
            animator.SetBool("isAttacking", false);
        }
    }
}
