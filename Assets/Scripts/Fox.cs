﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject target = collision.gameObject;

        if (target.GetComponent<Gravestone>())
        {
            animator.SetTrigger("jumpTrigger");
            
        }
        else if (target.GetComponent<Defender>())
        {
                GetComponent<Attacker>().Attack(target);
        }
    }
}