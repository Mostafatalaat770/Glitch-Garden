using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    [SerializeField] int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // to get level timer status
        var levelTimerSlider = FindObjectOfType<GameTimer>().GetComponent<Slider>();

        // to get number of attackers in every spawner
        var numberOfAttackers = 0;
        var spawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawners)
        {
            numberOfAttackers += spawner.transform.childCount;
            if(levelTimerSlider.value == levelTimerSlider.maxValue)
            {
                spawner.StopSpawning();
            }
        }

        // check if timer finished and no attackers left
        // if yes end level and load next scene
        if(numberOfAttackers == 0 && (levelTimerSlider.value == levelTimerSlider.maxValue))
        {
            //TODO load next scene
            Debug.Log("level done!");
        }
    }
}
