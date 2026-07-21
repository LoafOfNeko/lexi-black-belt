using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadingScene : MonoBehaviour
{

    public float targetTime = 60.0f;
    private float timer;
    public GameObject LoadingScreen;

    bool screenHasLoaded = false;

    void Start()
    {
        timer = targetTime;
        screenHasLoaded = false;
    }

    void Update()
    {
        if (screenHasLoaded == true)
        {
            if (timer >= 0.0f)
            {
                timer -= Time.deltaTime;
            }
            else if (timer <= 0.01f)
            {
                LoadingScreen.SetActive(false);
                timer = targetTime;
                screenHasLoaded = false;
            }

        }
    }
    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        LoadingScreen.SetActive(true);
        print("start");
        while (!operation.isDone)
        {
            yield return null;
        }
        print("end");
        screenHasLoaded = true;
        
    }
}
