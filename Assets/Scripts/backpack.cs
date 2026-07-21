using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backpack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InvBoxControl inventoryControl;
    [SerializeField] private Sprite mySprite;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            inventoryControl.GotBag = true;
            Destroy(gameObject);
        }
    }
}
