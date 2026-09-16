using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class factRandomizer : MonoBehaviour
{

    private List<string> fact_list;
    public GameObject loadingScreen;
    public Text textObject;
    // Start is called before the first frame update
    void Start()
    {
        fact_list = new List<string>();

        // adding facts to list
        fact_list.Add("Azure’s shop is somewhere in his room, you just have to look!");
        fact_list.Add("Azure may look like a human, but he’s semi-aquatic. We don’t really know what he is so we just pretend he’s a human.");
        fact_list.Add("Azure hates anyone who’s too clingy (Cough cough eli and cherri cough cough)");
        fact_list.Add("Sasha can both process and feel emotions, she just struggles to show them.");
        fact_list.Add("Sasha thinks of Rosich and Azure as her siblings because they’re the closest thing to family.");
        fact_list.Add("Sasha could probably win the hunger games.");
        fact_list.Add("Ghostie’s actually very smart for a blob, as their brains come from dead people who aren't really smart.");
        fact_list.Add("Sometimes ghostie forgets how to speak common, so she fakes it by blurting out random sounds when someone talks to her.");
        fact_list.Add("Ghostie likes eating bleach for some reason. Everyone tells her not to but she eats it anyways.");
        fact_list.Add("Zeyn is kinda a people pleaser so she might do some tasks for you.");
        fact_list.Add("For some reason Zeyn has a personal helicopter.");
        fact_list.Add("Angelina takes the form of a humanoid so she doesn’t disturb anyone.");
        fact_list.Add("Angelina spawned in with an estate and a lot of money.");
        fact_list.Add("Angelina has a relative she’s told you about before. I think their name was wings…? You don’t remember much about that conversation. There must be a reason why.");
        fact_list.Add("Cherri and Eli like Azure a bit too much. Maybe you should krill them. Who said that?");
        fact_list.Add("I hope no one uses Eli as their favorite character. Or a liked character.");
        fact_list.Add("Cherri learned how to bake when she was 5.");
        fact_list.Add("Cherri isn’t as infuriating as Eli.");
        fact_list.Add("Y.M’s full name is Your Mom.");
        fact_list.Add("Y.M speaks literally any other language than common. Like, any…");
        fact_list.Add("Y.M somehow knows the word ‘Bomb’ because of someone…");
        fact_list.Add("Jess and paisley are siblings. They love each other but siblings will be siblings lol");
        fact_list.Add("Jess loves expressing herself through art. She has hundreds of sculptures, paintings, and sketchbooks at home that she’s created through the years.");
        fact_list.Add("Paisley is much more energetic than her older sister and likes dancing. She finds it as an outlet to her energy and a fun way to express herself.");
        fact_list.Add("Clover, paisley, and Jess are all different kinds of bards. They (and when I say ‘they’ I mean clover) call themselves the Creatives.");
        fact_list.Add("Clover has a special dice that is his family heirloom. Depending on its roll, he gets a different instrument.");
        fact_list.Add("Clover used to have a huge crush on Sasha.");
        fact_list.Add("Clover can’t play the piano. Too confusing. Too many keys. Aaaaa");
        fact_list.Add("An inside joke going around is that clover plays the background music.");
        fact_list.Add("Florence was based off of my among us avatar.");
        fact_list.Add("Florence is a little shy, so they’re a bit quiet around you.");
        fact_list.Add("Sage loves flowers and can identify them by their smell, but she wishes she could see them.");
        fact_list.Add("Sage’s eyes are extremely sensitive to light so she wears a blindfold in order to protect her eyes.");
        fact_list.Add("Kirai used to be into cooking, but when she discovered potion making it clicked well for her.");
        fact_list.Add("Kirai loves fashion and dressing up, she puts together a new outfit every occasion she gets.");
        fact_list.Add("Kirai is a bit crazy… she has a lot of guns in her room, it's a bit suspicious. What could she be using those for?");
        fact_list.Add("Robyn bullies Azure because he’s “mean” to Rosich, so she bonded with Zeyn rather quickly over it.");
        fact_list.Add("Zeyn and Robyn bully kids on Roblox.(they also bully Azure on there frequently)");
        fact_list.Add("Robyn has the ability to make copies of herself in order to confuse enemies.");
        fact_list.Add("Robyn use to own a baseball bat but she could only duplicate herself, and enemies could tell who was the real Robyn by whichever had the bat.");
        fact_list.Add("The cats aren’t as they seem.");
        fact_list.Add("Open your eyes and stop pretending.");
        fact_list.Add("It’s not recommended to make top-down pixel rpgs on unity. Just saying.");
        fact_list.Add("I wish it was easier to make this demo sigh");
        fact_list.Add("Is that a omori reference");
        fact_list.Add("Azure makes weapons for certain people if they ask (not for you bozo, pay up) but he won’t make a specific weapon no matter what because of someone…. I wonder who.");
        fact_list.Add("Zeyn stole her helicopter from someone.");
        fact_list.Add("Orion is a menace to society-");
        fact_list.Add("Jess recreated the Mona Lisa perfectly. Who knows, maybe she’s the one who painted it originally… jk jk she’s js good at art like that");
        fact_list.Add("Kier is pretty depressed I thonk");
        fact_list.Add("The only person Orion likes on outlier island is Ghostie. He feeds her the evidence. What who said that");
        fact_list.Add("Orion will be chill with you if you give him some food. Fellow bigback spotted");
        fact_list.Add("Jess gets bullied by paisley (sibling rivalry)(lol imagine getting bullied by your younger sibling couldn’t be me)");
        fact_list.Add("Orion didn’t want to tell anyone his name but since everyone pestered him about it he just told them to call him Orion. We still don’t actually know what his name is.");
        fact_list.Add("Kier likes to read, that’s why we barely see him.");
        fact_list.Add("Orion likes cats.");
        fact_list.Add("Yeah, Azure’s ‘weaponeer smart’, but he isn’t really smart in any other way.");
        fact_list.Add("Azure is kinda greedy so if you want a weapon, be prepared to be broke (really expensive)");
        fact_list.Add("Zeyn is that one rich kid of the group");
        fact_list.Add("No one knows how Orion suddenly got onto the island…");
        fact_list.Add("Zeyn likes to listen to people yap even if she doesn’t know what the subject they’re talking about, she’ll just pretend to know what it is");
        fact_list.Add("Zeyn and Robin are both sillies who love chaos");
        fact_list.Add("Azure is afraid of moths… Zeyn exploits his phobia for more free things-");
        fact_list.Add("Zeyn can sing really good, but she will only sing around a select few");
        fact_list.Add("Azure randomly knows how to make stuff, if he wants to make something, he’ll make it without knowing how he did");
        fact_list.Add("Jess will never draw something if someone else asks… she likes her own creative freedom-");
        fact_list.Add("Zeyn has trust issues, but the more you seems friendly with no bad intentions, she’ll be fun and exciting to be around");
        fact_list.Add("Azure will never show what music he’s listening to…");
        fact_list.Add("Azure lets Ghostie eat whatever things he made that he doesn’t need / or just doesn’t like how it turned out");
        fact_list.Add("Eli’s favorite animal is a bunny");
        fact_list.Add("Zeyn knows a lot of ways to fight, such as kickboxing, judo, taekwondo, karate, etc.");
        fact_list.Add("Who knows what Zeyn does with the weapons she gets from Azure…");
        fact_list.Add("Azure also accepts sweets as payment for weapons and stuff (he loves sugar >:3)");
        fact_list.Add("Eli and Cherri constantly tries to get Azure’s attention, but Azure doesn’t like and care about them (he finds them annoying)");
        fact_list.Add("Zeyn likes to visit Kirai and talk about…. Guns >:3. They hang out a lot just to talk about them lol");
        fact_list.Add("Zeyn is good with younger kids (cough cough paisley)");
        fact_list.Add("Azure stays mostly inside doing something on his ipad or making something in his shop");
        fact_list.Add("Zeyn is definitely a horrible role model… so don’t do what she ever does ^^");
        fact_list.Add("Orion is the only person on outlier island who doesn’t like or hate angelina, sort of a neutral relationship :3");
        fact_list.Add("Zeyn, Orion, and Keir are all around the same height…");
        fact_list.Add("Kier stays indoors and barely goes out of his house.");
        fact_list.Add("Orion has a lot of cats in his house… where did he get them??");
        fact_list.Add("I wonder why Kier’s hair covers one of his eyes… (totally isn’t because someone is lazy to draw the other eye-)");
        fact_list.Add("Azure likes to wear comfortable clothes over stylish so he wears a lot of random mismatched clothes :>");
        fact_list.Add("Zeyn, Kirai, and Robyn are all close friends");
        fact_list.Add("Kier is kinda strong ykyk but Kier doesn’t like to do anything that requires a lot of effort-");
        fact_list.Add("Azure tries to hide from Eli and Cherri’s constant pestering (he’s cooked-)");
        fact_list.Add("Eli and Cherri like to bake stuff and sell them, but if someone asks… yes they can have food for free ");
        fact_list.Add("Kier is like the only person who isn’t hating on Eli and instead Kier kinda enjoys Eli’s company sometimes…");
        fact_list.Add("Orion and Kier live together… it’s very dark inside their house… maybe they’re too broke to afford the electricity bills. Or maybe they're js emo like that :skull:");
        fact_list.Add("Zeyn likes to sing rock");
        fact_list.Add("Kier is surprisingly pretty good at singing… only angelina knows that ^^");
        fact_list.Add("Jess is learning how to cook and bake some stuff from cherri (no eli bc it’s girl’s time!)");
        fact_list.Add("Zeyn is the one who braid’s Serene’s hair everyday in the morning");
        fact_list.Add("Zeyn likes buying a lot of different clothes… that she’ll never find the time to wear-");
        fact_list.Add("Serene’s hair is kinda long, so that’s why she likes to keep it braided… so it’ll be a little bit shorter (that’s totally the reason why-)");
        fact_list.Add("Jess is really smart when dealing with art related info! Maybe you should visit her sometime about it.");
        fact_list.Add("Zeyn likes fighting either with a gun or just outright fist-fight (bc she knows a lot of martial arts >:3)");
        fact_list.Add("Azure is constantly listening to music, but no one knows what device he has it connected it to- (people have tried and failed)");
        fact_list.Add("Don’t try to fight Zeyn… just a heads up (you’ll be cooked in one second)");
        fact_list.Add("Jess is a bit shy to compliments, she gets embarrassed easily");
        fact_list.Add("Zeyn can’t cook… so she asks Serene to make her food, or she goes to Eli and Cherri for some food");
        fact_list.Add("Shh… don’t tell Zeyn i told you this… but i heard Zeyn kinda got her house on fire after trying to cook… that’s why she doesn’t cook >:3");
        fact_list.Add("Azure is bad at driving");
        fact_list.Add("Zeyn has a helicopter and a motorcycle… can she even use them safely?");
        fact_list.Add("Kier is non-binary");
        fact_list.Add("Azure is pretty short for 16 years old");
        fact_list.Add("Clover and Birch are such a cute couple like I love them so much aaa");
        fact_list.Add("Birch enjoys music artists like Cavetown, Conan Gray, and Alex G");
        fact_list.Add("Birch is my babyyyyyyyy");
        fact_list.Add("Birch and Angelina look a bit uncomfortable around eachother");
        fact_list.Add("You remember the first time you did Sasha's hair. She refused to undo the ponytails you did until you reassured that you could just remake them.");
        fact_list.Add("Are you sure cats really look like that?");
        fact_list.Add("Clover owns a slot machine to practice gambling. It doesn't even dispence anything but somehow he wins every time");
        fact_list.Add("You remember that one time you dyed your hair with Clover and Birch. Black did NOT suit you guys.");
        fact_list.Add("You remember seeing two birds that follow Sasha around. It looked like a crow and a sparrow? They've always been spotted near her.");
        fact_list.Add("You remember Angelina talking about some disease Florence has. It might have been called hana... Hakan... Hanakar... yeah you don't feel like putting energy into remembering");
        fact_list.Add("You remember patching up clothes for all of your friends. Sasha always had some rips in her clothes so you'd always focus on fixing what she'd bring in first.");
        fact_list.Add("You remember when your hair use to be the same as Azure's. After disliking your black hair, you tried to re-dye it back but you accidentally grabbed the wrong color.");
        fact_list.Add("You wear gloves so you don't accidentally scratch anyone, you enjoy having long nails but don't plan on hurting anyone with them.");
        fact_list.Add("");
        fact_list.Add(" ");

    }

    private int newFact = 1;
    // Update is called once per frame
    void Update()
    {
        // checks if loading screen is on
        if (loadingScreen.activeSelf == true)
        {
            //picks q random fact from list and displays it
            if (newFact == 1)
            {
                int randomIndex = Random.Range(0, fact_list.Count);
                string text = fact_list[randomIndex];
                textObject.text = text;
                print("hello");
                newFact = 0;
                Invoke("turnOn", 2);
            }

        }
    }

    private void turnOn()
    {
        newFact = 1;
    }
 
}
