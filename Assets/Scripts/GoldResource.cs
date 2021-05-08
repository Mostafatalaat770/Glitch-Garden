using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldResource : MonoBehaviour
{
    [SerializeField] int startingGold = 100;
    int gold;
    Text goldTextField;

    // Start is called before the first frame update
    void Start()
    {
        gold = startingGold;
        goldTextField = GetComponent<Text>();
        goldTextField.text = startingGold.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpendGold(int amount)
    {
        gold -= amount;
        goldTextField.text = gold.ToString();
    }
    public void GainGold(int amount)
    {
        gold += amount;
        goldTextField.text = gold.ToString();

    }
    public int GetGold()
    {
        return gold;
    }

}
