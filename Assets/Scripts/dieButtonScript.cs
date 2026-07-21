using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dieButtonScript : MonoBehaviour
{

    public Button yourButton;
    public fightingScript fightObject;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }

    public void TaskOnClick()
    {
        fightObject.Die();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
