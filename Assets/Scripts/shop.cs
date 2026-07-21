using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    [SerializeField] private GameObject holder;
    [SerializeField] private Image[] placeholders;
    private static bool woke = false;
    private static shop mySelf;
 //   public bool GotBag;

    [SerializeField] private Sprite defaultSprite;
    private Sprite[] inv;

    private bool toggleInv = false;

    // Start is called before the first frame update
    void Awake()
    {
        if (!woke)
        {
            mySelf = this;
            DontDestroyOnLoad(gameObject);

            inv = new Sprite[9];
            for (int i = 0; i < 9; i++)
            {
                inv[i] = defaultSprite;
            }
           
            woke = true;
        }

    }
    void Start()
    {

        //   GotBag = false;
        inv = new Sprite[9];
       for (int i = 0; i < 9; i++)
         {
             inv[i] = defaultSprite;
         }

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("e"))
        {
            Toggle();

            if (toggleInv)
            {
                OpenInv();

            }
            else
            {
                CloseInv();
            }
        }
    }
 
    private void Toggle()
    {
        toggleInv = !toggleInv;
    }
 
    private void OpenInv()
    {
        holder.SetActive(true);
        ImgShow();
    }

    private void CloseInv()
    {
        holder.SetActive(false);
    }

    void ImgShow()
        {
            for (int i = 0; i < 9; i++)
            {
                placeholders[i].overrideSprite = inv[i];
            }

        }
      

          public bool ObjCollect(Sprite newItem)
          {

              int numfull = 0;
              for (int i = 0; i < 9; i++)
              {
                  if (inv[i] == defaultSprite)
                  {
                      inv[i] = newItem;
                      return true; /// We Put the item in the inventory
                  }
                  numfull++;
              }
              
              return false;// All full

           }
}
