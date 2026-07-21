using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public fightingScript fightingScript;
    private GameObject invObject;
    private InvBoxControl InvBoxControl;

    void Start()
    {
        invObject = DoNotDestroyOnLoad.Instance.inventorySystem;
        InvBoxControl = invObject.GetComponent<InvBoxControl>();
    }

    public void AttackButton()
    {
        fightingScript.Attack();
    }

    public void ItemButton()
    {
        InvBoxControl.FightInv();
    }

    public void CallButton()
    {
        fightingScript.Call();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
