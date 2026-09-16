using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class titleManager : MonoBehaviour
{

    public VideoPlayer titleVideo;

    public GameObject lastFrame;

    void OnEnable(){
        titleVideo.loopPointReached += OnVideoFinished;
    }

    void OnDisable()
    {
        titleVideo.loopPointReached -= OnVideoFinished;
    }

    // Start is called before the first frame update
    void Start()
    {
        lastFrame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnVideoFinished(VideoPlayer source){
        titleVideo.gameObject.SetActive(false);
        lastFrame.SetActive(true);
    }
}
