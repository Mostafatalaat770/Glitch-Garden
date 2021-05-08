using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UserScore : MonoBehaviour
{
    [SerializeField] int startScore = 100;
    int score;
    TextMeshProUGUI scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        scoreLabel = GetComponent<TextMeshProUGUI>();
        scoreLabel.SetText(startScore.ToString());
        score = startScore;
    }

    public void InflictDamage()
    {
        if (score != 0)
        {
            score--;
            scoreLabel.SetText(score.ToString());
        }
        if(score == 0)
        {
            FindObjectOfType<SceneLoader>().LoadGameOverScreen();
        }
    }

}
