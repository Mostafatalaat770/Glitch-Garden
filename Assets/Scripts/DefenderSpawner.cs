using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;
    [SerializeField] GoldResource goldResource;

    public void SetDefenderPrefab(Defender defender)
    {
        defenderPrefab = defender;
    }
    private void OnMouseDown()
    {
        SpwanDefender(GetTilePos());
    }

    private void SpwanDefender(Vector2 position)
    {
        position.x = Mathf.RoundToInt(position.x);
        position.y = Mathf.RoundToInt(position.y);
        if (goldResource.GetGold() >= defenderPrefab.GetCost())
        {
            goldResource.SpendGold(defenderPrefab.GetCost());
            Instantiate(defenderPrefab, position, Quaternion.identity);
        }
    }

    private Vector2 GetTilePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
