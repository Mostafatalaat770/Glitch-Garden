using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    Slider slider;
    [Tooltip("Level's time in seconds")]
    [SerializeField] int levelTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < slider.maxValue)
        {
            slider.value = Time.timeSinceLevelLoad / levelTime;
        }
        else
        {
            var spawners = FindObjectsOfType<AttackerSpawner>();
            foreach(AttackerSpawner spawner in spawners)
            {
                spawner.StopSpawning();
            }
        }
    }
}
