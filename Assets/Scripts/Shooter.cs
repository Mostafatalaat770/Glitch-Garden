using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gunPrefab, gunPos;
    AttackerSpawner myLaneSpawner;
    Animator animator;
    private void Start()
    {
        SetLaneSpawners();
        animator = GetComponent<Animator>();

    }
    private void Update()
    {
        if (IsAttackerOnLane())
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isAttacking", false);
        }
    }
    public void Fire()
    {
        Instantiate(gunPrefab, gunPos.transform.position, gunPos.transform.rotation);
    }

    private void SetLaneSpawners()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners) {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
        if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }

    }

    private bool IsAttackerOnLane()
    {
        return myLaneSpawner.transform.childCount > 0 ? true : false;

    }
}
