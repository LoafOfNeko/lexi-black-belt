using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class fightingScript : MonoBehaviour
{
    public int fightCoinModifier;

    public int enemyLife;
    public int playerLife;
    public int npcLife;
    public int playerAttack;
    public int enemyAttack;
    public int healItem;
    public TMP_Text enemyNameText;
    public TMP_Text damageText;
    public TMP_FontAsset redOutline;
    public TMP_FontAsset greenOutline;

    public Button itemButton;
    public Button callButton;
    public Button attackButton;

    public GameObject EnemyCharacter;

    public Slider EnemyHealthBar;
    public Slider PlayerHealthBar;
    public Slider NpcHealthBar;

    public GameObject FightWin;
    public GameObject FightLose;

    public TMP_Text FightWinText;
    public TMP_Text FightLoseText;


    [Header("Auto-Assign")]
    public GameObject enemy;
    public string enemyName;
    public InvBoxControl InvBoxControl;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy")[0];
        enemyName = enemy.name;
        EnemyCharacter.GetComponent<Image>().sprite = enemy.GetComponent<SpriteRenderer>().sprite;
        enemyNameText.text = enemy.name;
        InvBoxControl = GameObject.Find("INVBox").GetComponent<InvBoxControl>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyHealthBar.value = enemyLife;
        PlayerHealthBar.value = playerLife;
        NpcHealthBar.value = npcLife;
    }


    public void Attack()
    {
        disableButtons();
        enemyLife = enemyLife - playerAttack;

        Invoke("enemyTurn", 2f);
        showDamageText(playerAttack, "damageEnemy");
    }

    public void Call()
    {
        disableButtons();
        //call npc
    }

    public void Die()
    {
        playerLife = playerLife - playerLife;
    }

    public void enemyTurn()
    {
        disableButtons();
        playerLife = playerLife - enemyAttack;
        Debug.Log(playerLife);
        showDamageText(enemyAttack, "damagePlayer");
        Invoke("enableButtons", 1.5f);
        Invoke("checkForEnd", 1.4f);
    }

    public void showDamageText(float value, string type)
    {
        if (type == "heal")
        {
            damageText.color = Color.green;
            damageText.font = greenOutline;
            damageText.text = "+ " + value.ToString();
            damageText.transform.localPosition = new Vector3(400, 207, 0);
        }
        else if (type == "damageEnemy")
        {
            damageText.color = Color.red;
            damageText.font = redOutline;
            damageText.text = "- " + value.ToString();
            damageText.transform.localPosition = new Vector3(0, 160, 0);
        }
        else if (type == "damagePlayer")
        {
            damageText.color = Color.red;
            damageText.font = redOutline;
            damageText.text = "- " + value.ToString();
            damageText.transform.localPosition = new Vector3(400, 207, 0);
        }


            damageText.gameObject.SetActive(true);

        Invoke("hideDamageText", 1.5f);
    }

    public void checkForEnd()
    {
        if (enemyLife <= 0)
        {
            Debug.Log("Enemy defeated");
            InvBoxControl.coins += fightCoinModifier;
            FightWin.SetActive(true);
            FightLose.SetActive(false);
            FightWinText.text = "You defeated " + enemyName + " and gained " + fightCoinModifier + " coins";
            Invoke("returnFromFight", 1f);
        }

        if (playerLife <= 0)
        {
            Debug.Log("Player defeated");
            InvBoxControl.coins -= fightCoinModifier;
            FightWin.SetActive(false);
            FightLose.SetActive(true);
            FightLoseText.text = "You were defeated by " + enemyName + " and lost " + fightCoinModifier + " coins";
            Invoke("returnFromFight", 1f);
        }
    }

    public void returnFromFight()
    {
        SceneManager.LoadScene("Outside");
    }

    public void hideDamageText()
    {
        damageText.gameObject.SetActive(false);
    }

    public void disableButtons()
    {
        itemButton.interactable = false;
        callButton.interactable = false;
        attackButton.interactable = false;
    }

    public void enableButtons()
    {
        itemButton.interactable = true;
        callButton.interactable = true;
        attackButton.interactable = true;
    }
}
