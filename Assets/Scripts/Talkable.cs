using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talkable : MonoBehaviour
{
    [SerializeField] private string[] texts;
    [SerializeField] private string characterName;
    [SerializeField] private textBoxControl textBox;

    // Start is called before the first frame update
    void Start()
    {
         textBox = GameObject.Find("Textbox").GetComponent<textBoxControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            textBox.TurnOn(characterName, texts);
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            textBox.TurnOff();
        }
    }
}
