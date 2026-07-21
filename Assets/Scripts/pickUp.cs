using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private InvBoxControl inventoryControl;
    [SerializeField] private Sprite mySprite;
    void Start()
    {
       inventoryControl  = GameObject.Find("INVBox").GetComponent<InvBoxControl>();

       //check if this pickup is inside of the list of found items
        //if it is inside the list, we destroy this item.
        if(inventoryControl.spriteInList(mySprite) == true){
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            bool foundItem = inventoryControl.ObjCollect(mySprite);
            Debug.Log(foundItem);
            if (foundItem == true) {
                Destroy(gameObject);
            }
        }
    }
}
