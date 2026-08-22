using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallBook : MonoBehaviour
{

    public List<Dictionary<string, object>> npclist = new List<Dictionary<string, object>>();


    // Start is called before the first frame update
    void Start()
    {
        Dictionary<string, object> you = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Rosich" },
            { "Info",  "Warlock(Fathomless). It's you!"},
            { "Ability", "Inventory chuck" },
            { "Attack", 1 },
            { "Ability description", "[Pow!!!!]-Rosich. Yeah the name's pretty self explanatory." }
        };


        Dictionary<string, object> Angelina = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Angelina" },
            { "Info",  "Cleric(peace domain). Prettiest and kindest person anyone's seen, always does her best to help. The older sister you wish you had :3"},
            { "Ability", "Healing feathers" },
            { "Attack", 0 },
            { "Ability description", "[N/A]-Angelina. N/A (work in progres :/" }
        };

        Dictionary<string, object> Azure = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Azure" },
            { "Info",  "Artificer (armorer/battle smith). Your older sibling and armory shop keeper. Certified nonchalant meanie >:c"},
            { "Ability", "N/A (cough you can call him but dont </3)" },
            { "Attack", 0 },
            { "Ability description", "[It's legal if you don't get caught.]-Azure. Takes half of your current health with a kind sibling slap." }
        };

        Dictionary<string, object> Birch = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Birch" },
            { "Info",  "Warlock(Celestial). Enjoys the solitude of the forest without being forest-casted, likes to listen to music and draw. Silly shy boi"},
            { "Ability", "Rising Phoenix" },
            { "Attack", 0 },
            { "Ability description", "[If I deserved a second chance, you do too.]-Birch. If you have less than 20% health remaining, heals 40% back." }
        };

        Dictionary<string, object> Cherri = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Cherri" },
            { "Info",  "Artificer (chef). Owner of Cherri's Bakery, voluntarily dropped out of culinary school. Makes yummi food"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[N/A (w.i.p)]-Cherri. Buy food at her shop to heal you in battle." }
        };

        Dictionary<string, object> Clover = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Clover" },
            { "Info",  "Bard(college of glamor). Loves music and gambling, fights by the two worlds (personally you don't think that was a good idea). Practices gambling and somehow gets better"},
            { "Ability", "Musical die" },
            { "Attack", 40 },
            { "Ability description", "[Let's go gambling!!1!]-Clover. Rolls his special die, the value determines which instrument he uses." }
        };

        Dictionary<string, object> Eli = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Eli" },
            { "Info",  "Artificer (chef). Trains under Cherri, mainly takes orders for Cherri to bake. #1 Azure simp"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[Do you mind ordering something from here and giving it to Azure pretty please?']-Eli. (You respectfully said no.)" }
        };

        Dictionary<string, object> Florence = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Florence" },
            { "Info",  "Druid (Circle of the spores). Hasn't spoken to you very much, seems to want to be friends. Really cares for nature :3"},
            { "Ability", "Foolish Mushrooms" },
            { "Attack", 5 },
            { "Ability description", "[N/A]-Florence. Summons poisonus mushrooms from the ground to intoxicate the air the enemy breathes." }
        };

        Dictionary<string, object> Gang = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Gang" },
            { "Info",  "Sourcerer(Draconic Bloodline). Guards the island from the ocean, often comes to land for company. Lives under a hidden waterfall :3"},
            { "Ability", "Guardian of the lake" },
            { "Attack", 0 },
            { "Ability description", "[Water :D]-Gang. Uses a water shield to protect you, lowering the enemy's attack on you by 50%." }
        };

        Dictionary<string, object> Ghostie = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Ghostie-blob" },
            { "Info",  "Artificer (alchemist). Doesn't really sell potions since she makes them for fun, house hops every Thursday. Very hungry blobby"},
            { "Ability", "Inventory chuck" },
            { "Attack", 1 },
            { "Ability description", "[Wheeeeeeeeeee!!!]-Ghostie. After feeding her any excess items, chuck her at an enemy to deal all the damage of the items fed to her + blob volume." }
        };

        Dictionary<string, object> Jess = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Jess" },
            { "Info",  "Bard (College of creation). Loves all kinds of physical art, prolly can recreate the mona lisa. Puts any drawings gifted to her on her fridge :3"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[I'm gonna eat ur art]-Jess. " }
        };

        Dictionary<string, object> Keir = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Keir" },
            { "Info",  "Wizard(order of scribes). Pretty much just here cuz of Orion, lowk does the bare minimum :/. Book worm looking ahh"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[w.i.p]-Keir. Brosketto js lazes around all day </3" }
        };

        Dictionary<string, object> Kirai = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Kirai" },
            { "Info",  "Artificer (alchemist). Loves his potions and guns, often seen ranting about his obsessions with Zeyn and Ghostie. A very manly man"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[If Clover can gamble with his music I should be allowed to gamble with my poisons!]-Kirai. Buy potions from his shop to assist you in battle!" }
        };

        Dictionary<string, object> Kisa = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Kisa" },
            { "Info",  "Fighter(battle master)[N/A]"},
            { "Ability", "Bubble gun" },
            { "Attack", 0 },
            { "Ability description", "[Dunno how this works but Im not wasting my bullets on some cats.]-Kisa. Buy potions from his shop to assist you in battle!" }
        };

                Dictionary<string, object> Paisley = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Paisley" },
            { "Info",  "Bard (college of dance). An energetic dancer and choreographer, also a pyromaniac for some reason. Most likely to run a 3 minute mile"},
            { "Ability", "Spinning summersault" },
            { "Attack", 15 },
            { "Ability description", "[Kapow!!!]-Paisley. Directly attacks enemy by summersaulting into them. " }
        };

        Dictionary<string, object> Sasha = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Sasha" },
            { "Info",  "Ranger(Hunter/monster slayer). Often comes off as quiet and nonchalant but just doesn't find it easy to express emotions as easily as others. Peak archer (never misses zaymnnn)"},
            { "Ability", "Bloody arrow"},
            { "Attack", 30 },
            { "Ability description", "[As long as I'm able to help I'll be fine.]-Sasha. Shoots arrows fueled by her blood at the enemy. Uses different kinds of arrows each time, being explosion, poison, and water." }

        };

        Dictionary<string, object> Serene = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Serene" },
            { "Info",  "Paladin(Oath of the Ancients). Makes yummy picnic, if you need help with anything she's always there :33. Also may give you food upon interaction"},
            { "Ability", "N/A" },
            { "Attack", 0 },
            { "Ability description", "[Remember to take a quick break after fighting for so long ^^]-Serene. N/A" }
        };

        Dictionary<string, object> Vorvio = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Vorvio" },
            { "Info",  "Wizard(Graviturgy). No idea how he got here, who let the 8 year old in? He's just a babyyyy"},
            { "Ability", "Battlefield disruption" },
            { "Attack", 50 },
            { "Ability description", "[Here comes the rockplane :DD]-Vorvio.  Uses magic to hoist parts of the battlefield at the enemy. Bro's a baby how does he do that" }
        };

        Dictionary<string, object> YM = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Y.M" },
            { "Info",  " Barbarian(path of the berserker). Speaks every language except for common, learned the word 'bomb' because Zeyn taught her. Seems friendly?"},
            { "Ability", "Manic fistfight" },
            { "Attack", 25 },
            { "Ability description", "[AKO MEMBENCI INXO BWEBWE KYANWA]-Y.M. . Rapid punches cats, might get confused and hit you. (I'm sure it's not on purpose?)" }
        };

        Dictionary<string, object> Zeyn = new Dictionary<string, object>()
        {
            // stores npc info
            { "Name", "Zeyn" },
            { "Info",  " Monk (way of the open hand). Rich silly person, definitely did not steal anything. Lowk a people pleaser"},
            { "Ability", "Gun n' run" },
            { "Attack", 1 },
            { "It's legal if you don't get caught :3", "[Pow!!!!]-Zeyn. Shoots any normal cat, always gets the job done.." }
        };


        npclist.Add(you);
        npclist.Add(Angelina);
        npclist.Add(Azure);
        npclist.Add(Birch);
        npclist.Add(Cherri);
        npclist.Add(Clover);
        npclist.Add(Eli);
        npclist.Add(Florence);
        npclist.Add(Gang);
        npclist.Add(Ghostie);
        npclist.Add(Jess);
        npclist.Add(Keir);
        npclist.Add(Kirai);
        npclist.Add(Paisley);
        npclist.Add(Sasha);
        npclist.Add(Serene);
        npclist.Add(Vorvio);
        npclist.Add(YM);
        npclist.Add(Zeyn);
        CheckNpclist();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void CheckNpclist()
    {
        for (int i = 0; i < npclist.Count; i++)
        {
            Debug.Log(npclist[i]["Name"].ToString());
        }
    }
}
