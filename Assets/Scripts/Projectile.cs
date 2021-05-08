using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] int damage = 100;

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var health = collision.GetComponent<Health>();
        var enemy = collision.GetComponent<Attacker>();

        if(enemy && health)
        {
            health.Hit(damage);
            Destroy(gameObject);
        }

    }
}
