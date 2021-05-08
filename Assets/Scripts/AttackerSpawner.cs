using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackerSpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] Attacker[] attackers;
    [SerializeField] float minTimeBetweenSpawns = 1f;
    [SerializeField] float maxTimeBetweenSpawns = 6f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns));
            var attackerChild = Instantiate(attackers[UnityEngine.Random.Range(0,attackers.Length)],
                transform.position, Quaternion.identity);
            attackerChild.transform.parent = transform;

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void StopSpawning()
    {
        spawn = false;
    }
}
