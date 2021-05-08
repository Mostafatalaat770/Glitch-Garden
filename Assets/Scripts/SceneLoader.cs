using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int timeBetweenScenes = 3;
    int currentSceneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        StartCoroutine(WaitForNextScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGameScene()
    {
        WaitForNextScene();
        SceneManager.LoadScene("Level 1");

    }
    public void LoadStartScreen()
    {
        WaitForNextScene();
        SceneManager.LoadScene("Start Screen");

    }
    public void LoadGameOverScreen()
    {
        SceneManager.LoadScene("Start Screen");

    }
    IEnumerator WaitForNextScene()
    {
        yield return new WaitForSeconds(timeBetweenScenes);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    
}
