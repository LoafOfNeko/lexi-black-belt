using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitTrigger : MonoBehaviour
{
    private bool isDoor = false;
    public GameObject popUpThingy;
    private PlayerTeleporter player;

    public int sceneTravel = -1;

    public Vector3 location;

    public loadingScene sceneLoader;


    // Start is called before the first frame update
    void Start()
    {
        sceneLoader = GameObject.Find("LoadingScene").GetComponent<loadingScene>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isDoor == true)
        {
            //SceneManager.LoadScene(sceneTravel);
            sceneLoader.LoadScene(sceneTravel);
            player.teleport(location);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            player = col.gameObject.GetComponent<PlayerTeleporter>();
            isDoor = true;
            popUpThingy.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isDoor = false;
            popUpThingy.SetActive(false);
        }
    }
}
