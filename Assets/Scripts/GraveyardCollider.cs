using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveyardCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject,0.5f);
        FindObjectOfType<UserScore>().InflictDamage();
    }
}
