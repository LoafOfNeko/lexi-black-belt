using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Linq;
using TMPro;

public class InvBoxControl : MonoBehaviour
{
    [SerializeField] private GameObject holder;
    [SerializeField] private Image[] topInv;
    [SerializeField] private Image[] storage;

    [SerializeField] private Image[] FullInventory;

    private static bool woke = false;
    private static InvBoxControl mySelf;
    public bool GotBag;
    [SerializeField] private Sprite defaultSprite;
    private Sprite[] inv;
    private Sprite[] sto;
    private Stack listOfPickedUpItems = new Stack();

    public bool isInvOpen = false;

    public fightingScript fightingScript;


    private string sceneName;

    public int selectedSlot;
    public string ItemType;
    public int ItemNumber;

    public string[] ItemDetails;

    public GameObject noBackpack;

    public int coins;
    public TMP_Text coinText;

    public GameObject ItemAnimation;
    public Image ItemAnimationImage;
    public Animator ItemAnimator;

    [Header("ItemDetails")]
    public Image selectedImage;
    public GameObject selectedTypeHeal;
    public GameObject selectedTypeDamage;
    public TMP_Text selectedNumber;
    public TMP_Text selectedName;
    public TMP_Text selectedDescription;

    public GameObject closeButton;
    public GameObject confirmButton;

    public GameObject NoItemSelected;

    public string currentItemType;

    // Start is called before the first frame update
    void Awake() {
        if (!woke) {
            mySelf = this;
            DontDestroyOnLoad(gameObject);
            GotBag = false;
            inv = new Sprite[9];
            for (int i = 0; i < 9; i++)
            {
                inv[i] = defaultSprite;
            }

            sto = new Sprite[27];
            for (int i = 0; i < 27; i++)
            {
                sto[i] = defaultSprite;
            }
            woke = true;
        }
        
    }
    void Start()
    {

        GotBag = false;
        coinText.text = "0";
        inv = new Sprite[9];
        for(int i = 0; i < 9; i++)
        {
            inv[i] = defaultSprite; 
        }

        sto = new Sprite[27];
        for (int i = 0; i < 27; i++)
        {
            sto[i] = defaultSprite;
        }
    }

    void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Input.GetKeyDown(KeyCode.E) && SceneManager.GetSceneByName("Outside").isLoaded)
        {
            if (isInvOpen == false)
            {
                OpenInv();

            }
            else
            {
                CloseInv();
            }
        }

        coinText.text = coins.ToString();

        if (Input.GetKeyDown(KeyCode.O))
        {
            coins++;
        }

        ItemAnimation = GameObject.Find("ItemAnimation");
        ItemAnimationImage = GameObject.Find("ItemAnimationImage").GetComponent<Image>();
        ItemAnimator = GameObject.Find("ItemAnimationImage").GetComponent<Animator>();
    }

    public void FightInv()
    {
        if (isInvOpen == false)
        {
            OpenInv();

        }
        else
        {
            CloseInv();
        }
    }


    public void OpenInv()
    {
        holder.SetActive(true);
        ImgShow();
        isInvOpen = true;

        if (GotBag == true)
        {
            noBackpack.SetActive(false);
        }
        else
        {
            noBackpack.SetActive(true);
        }

        if (SceneManager.GetSceneByName("FightingScene").isLoaded)
        {
            closeButton.SetActive(false);
            confirmButton.SetActive(true);
        }
        else
        {
            closeButton.SetActive(true);
            confirmButton.SetActive(false);
        }

        NoItemSelected.SetActive(true);
    }

    public void CloseInv()
    {
        holder.SetActive(false);
        isInvOpen = false;
        NoItemSelected.SetActive(true);
    }

    void ImgShow() {
        for (int i = 0; i < 9; i++)
        {
            topInv[i].sprite = inv[i];
        }

        for (int i = 0; i < 27; i++)
        {
            storage[i].sprite = sto[i];
        }
    }
    public bool spriteInList(Sprite item)
    {
        foreach(Sprite pickUp in listOfPickedUpItems){
            if(pickUp == item){
                return true;
            }
        }
        return false;//IF the item was not found
    }



    public bool ObjCollect(Sprite newItem)
    {

        int numfull = 0;
        for(int i=0; i<9; i++)
        {
            if (inv[i] == defaultSprite)
            {
                inv[i] = newItem;
                listOfPickedUpItems.Push(newItem);
                return true; /// We Put the item in the inventory
            }
            numfull++;
        }
        if (GotBag == true && numfull == 9) {
            for (int i = 0; i < 27; i++)
            {

                if (sto[i] == defaultSprite)
                {
                    sto[i] = newItem;
                    listOfPickedUpItems.Push(newItem);
                    return true;/// We Put the item in the inventory
                }
            }
        }

        return false;// All full
        

    }

    public void InvButtonPress(int slot)
    {
        if (SceneManager.GetSceneByName("FightingScene").isLoaded)
        {
            fightingScript = GameObject.Find("fightManager").GetComponent<fightingScript>();
        }

        NoItemSelected.SetActive(false);

        selectedSlot = slot;
        FullInventory = topInv.Concat(storage).ToArray();
        Image selectedItem = FullInventory[selectedSlot];

        if (selectedItem.sprite.name == "sprite-empty")
        {
            return;
        }
        ItemDetails = selectedItem.sprite.name.Split("-");

        
        string ItemType = ItemDetails[0];
        string ItemNumberString = ItemDetails[1];
        string ItemName = ItemDetails[2];
        string ItemDescription = ItemDetails[3];
        ItemNumber = Convert.ToInt32(ItemNumberString);
        Debug.Log("Name: "+ItemName + " Type: " + ItemType + " Number: " + ItemNumberString);

        selectedImage.sprite = selectedItem.sprite;
        selectedNumber.text = ItemNumberString;
        selectedName.text = ItemName;
        selectedDescription.text = ItemDescription;

        ItemAnimationImage.sprite = selectedItem.sprite;

        if (ItemType == "heal")
        {
            selectedTypeHeal.SetActive(true);
            selectedTypeDamage.SetActive(false);
            currentItemType = "heal";
        }
        else if (ItemType == "item")
        {
            selectedTypeHeal.SetActive(false);
            selectedTypeDamage.SetActive(true);
            currentItemType = "item";
        }
    }

    public void UseItem()
    {
        if (currentItemType == "heal")
        {
            fightingScript.playerLife += ItemNumber;
            fightingScript.showDamageText(ItemNumber, "heal");
        }
        else if (currentItemType == "item")
        {
            fightingScript.enemyLife -= ItemNumber;
            fightingScript.showDamageText(ItemNumber, "damageEnemy");

            ItemThrowAnim();
        }

        if (fightingScript.playerLife > 100)
        {
            fightingScript.playerLife = 100;
        }

        Invoke("FS_enemyTurn", 2f);
    }

    public void ItemThrowAnim()
    {
        ItemAnimation.SetActive(true);
        ItemAnimator.Play("ItemFriendlyThrow");
        Invoke("ItemIdleAnim", 1.5f);
    }

    public void ItemIdleAnim()
    {
        ItemAnimator.Play("ItemIdle");
        ItemAnimation.SetActive(false);
    }

    public void FS_enemyTurn()
    {
        fightingScript.enemyTurn();
    }

    public void ConfirmButton()
    {
        FullInventory[selectedSlot].sprite = defaultSprite;
        if (selectedSlot <= 9)
        {
            inv[selectedSlot] = defaultSprite;
        }
        else
        {
            sto[selectedSlot - 9] = defaultSprite;
        }

        CloseInv();

        fightingScript.disableButtons();
        Invoke("UseItem", 1f);
    }

}
//cheese