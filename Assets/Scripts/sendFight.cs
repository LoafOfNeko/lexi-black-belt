using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SendFight : MonoBehaviour
{
    private bool isEnemy = false;
    public GameObject popUpThingy;

    public int sceneTravel = -1;

    public GameObject DoNotDestroyOnLoad;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && isEnemy == true)
        {
            this.gameObject.transform.SetParent(DoNotDestroyOnLoad.transform);
            this.gameObject.tag = ("Enemy");
            SceneManager.LoadScene(sceneTravel);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isEnemy = true;
            popUpThingy.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            isEnemy = false;
            popUpThingy.SetActive(false);
        }
    }
}
