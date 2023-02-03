using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus119 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tang == 1)
        {
            NameTag.SetActive(true);
            NameTagText.text = "Sicxalon";
            dia.text = "Grrruuuhhhhhhhhhhhhhhhhhhhhhhhh...";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "This monster is terrible if you destroy it, it will all explode.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "What should we do, it has weakened a lot.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "If we don't destroy it, there's only a way to seal it like my mother did.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "...Wait, I have an idea.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "What are you going to do, Vayne? Don't go near that monster!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "I will reincarnate it, it will definitely help the next generation.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Now submit to me Hyaaaaaaa!!!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "";
            dia.text = "Sengggggggggggggggg...";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "That's...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "The soul of Sicxalon. I have succeeded!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Alia";
            dia.text = "Well done, Vayne!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "With this, just give the gods mana and they can do the rest.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Zane";
            dia.text = "Bastard, how dare you... I can't lose like that.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Shut up, you're no longer capable of fighting, give up, we're lucky we haven't hit you yet.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Zane";
            dia.text = "Pity me... hahahahaha I'll let you all go to heaven with me!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Zane";
            dia.text = "I'll blow them all up!!!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Stop it Zane!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "Mana shield!";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alia";
            dia.text = "Sister Maria! What are you thinking of doing!";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne, Alia both of you can't die, you both have a bright future, get out of here quickly.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "No... can't leave you alone!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Maria";
            dia.text = "Our journey isn't long but I've come to realize some things... some things called sacrifices are required to protect those we love.";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Alia";
            dia.text = "... Sister Mariaa!!!";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Zane";
            dia.text = "You wants to die with me...";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Don't try to touch my two friends.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'll take you out!";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Maria";
            dia.text = "Mana shield pushes Vayne away!";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ahhh... Sister Maria!";
        }
        else if (tang == 31)
        {
            NameTagText.text = "";
            dia.text = "Rrroommmmmmm...";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Alia";
            dia.text = "No! The wall has fallen...";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Vayne";
            dia.text = "Damn... we have to get out Maria...";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Alia";
            dia.text = "No... can't leave Maria like that...";
        }
        else if (tang == 35)
        {
            NameTagText.text = "Vayne";
            dia.text = "We have to get out quickly or we'll be buried here... we can't let her make a meaningless sacrifice! Hic...";
        }
        else if (tang == 36)
        {
            NameTagText.text = "Alia";
            dia.text = "Hic... hic... Impossible...";
        }
        else if (tang == 37)
        {
            NameTagText.text = "Vayne";
            dia.text = "(I'm sorry and thank you Maria...)";
        }
        else if (tang == 38)
        {
            NameTagText.text = "Maria";
            dia.text = "Hmm... looks like I can close my eyes peacefully, right?";
        }
        else if (tang == 39)
        {
            NameTagText.text = "Zane";
            dia.text = "Nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";
        }
        else if (tang == 40)
        {
            NameTagText.text = "Maria";
            dia.text = "(Father, I'm sorry I didn't keep my promise. Goodbye everyone.)";
        }
        else if (tang == 41)
        {
            NameTagText.text = "";
            dia.text = "Bbbbbbbbbbbbbbbbbbbbbbbbooooooooooooooooooooooooooooommmmmmmmmmmmmmmmmmmmmmmmmmm...";
        }
        else if (tang == 42)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 43)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hoh phoh... Hoh phoh... Alia! Alia where are you!";
        }
        else if (tang == 44)
        {
            NameTagText.text = "Alia";
            dia.text = "Huh... Vayne! I'm ok!";
        }
        else if (tang == 45)
        {
            NameTagText.text = "Vayne";
            dia.text = "Luckily, we're all safe!";
        }
        else if (tang == 46)
        {
            NameTagText.text = "Alia";
            dia.text = "Sister Maria! She...";
        }
        else if (tang == 47)
        {
            NameTagText.text = "Vayne";
            dia.text = "I can't feel any trace of her anymore... she saved us...";
        }
        else if (tang == 48)
        {
            NameTagText.text = "Alia";
            dia.text = "Hic... no way...";
        }
        else if (tang == 49)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't worry Maria, we survived. Thank you, Maria!";
        }
        else if (tang == 50)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 51)
        {
            NameTagText.text = "Mana elf";
            dia.text = "This is Sicxalon's soul...";
        }
        else if (tang == 52)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! I hope you can transform this soul into someone who can help the world in the future, okay?";
        }
        else if (tang == 53)
        {
            NameTagText.text = "Mana elf";
            dia.text = "I see, very smart choice. We will take care of the rest and on behalf of the other mana I sincerely thank everyone.";
        }
        else if (tang == 54)
        {
            NameTagText.text = "Vayne";
            dia.text = "(The battle is really over, but the journey isn't over yet...)";
        }
        else if (tang == 55)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 56)
        {
            NameTagText.text = "Klener";
            dia.text = "Vayne, Alia you two are back!";
        }
        else if (tang == 57)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm...";
        }
        else if (tang == 58)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 59)
        {
            NameTagText.text = "Klener";
            dia.text = "Where's Maria? What is she busy with?";
        }
        else if (tang == 60)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria! She doesn't come back with us?";
        }
        else if (tang == 61)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria! She doesn't come back with us?";
        }
        else if (tang == 62)
        {
            NameTagText.text = "Alia";
            dia.text = "Maria did... she sacrificed herself for us...";
        }
        else if (tang == 63)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "No... Maria you promised to come back!";
        }
        else if (tang == 64)
        {
            NameTagText.text = "Vayne";
            dia.text = "Mr. Lance please calm down... she made no senseless sacrifices, she saved the world... we will never forget her.";
        }
        else if (tang == 65)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I see, I need... a quiet place just me...";
        }
        else if (tang == 66)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 67)
        {
            NameTagText.text = "Alia";
            dia.text = "...";
        }
        else if (tang == 68)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia I'm leaving town tomorrow morning, tomorrow morning we'll talk.";
        }
        else if (tang == 69)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhm... Good night.";
        }
        else if (tang == 70)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 71)
        {
            NameTagText.text = "Vayne";
            dia.text = "Everything is ready, maybe we should go.";
        }
        else if (tang == 72)
        {
            NameTagText.text = "Vayne";
            dia.text = "I will miss this place very much, also the first mark of a long journey.";
        }
        else if (tang == 73)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't worry Dad, I've learned a lot.";
        }
        else if (tang == 74)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 75)
        {
            NameTagText.text = "Klener";
            dia.text = "Vayne! Everyone is waiting for you to say goodbye!";
        }
        else if (tang == 76)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wow, you know I'm leaving today?";
        }
        else if (tang == 77)
        {
            NameTagText.text = "Orina";
            dia.text = "It was Alia who told us everything.";
        }
        else if (tang == 78)
        {
            NameTagText.text = "Heerium";
            dia.text = "Huhuhuhu... can't you stay here much longer!";
        }
        else if (tang == 79)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I have some presents for you along the way.";
        }
        else if (tang == 80)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you everyone... thank you all for helping me over this time.";
        }
        else if (tang == 81)
        {
            NameTagText.text = "Klener";
            dia.text = "We need to thank you too, Vayne, you've protected this town. Not only that, it also helps the surrounding villages.";
        }
        else if (tang == 82)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "That's why I thank you on behalf of all of you for everything and stay safe, Vayne!";
        }
        else if (tang == 83)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes! And Alia isn't here?";
        }
        else if (tang == 84)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Looks like she went somewhere early in the morning!";
        }
        else if (tang == 85)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well... So I'm on my way. Good bye!";
        }
        else if (tang == 86)
        {
            NameTagText.text = "All";
            dia.text = "Goodbye and see you soon!";
        }
        else if (tang == 87)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 88)
        {
            NameTagText.text = "Vayne";
            dia.text = "(Alia isn't planning to follow me.)";
        }
        else if (tang == 89)
        {
            NameTagText.text = "Vayne";
            dia.text = "Heh? Alia!";
        }
        else if (tang == 90)
        {
            NameTagText.text = "Alia";
            dia.text = "I've been waiting for you for a while! Hihi!";
        }
        else if (tang == 91)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'd be happy to have you with me!";
        }
        else if (tang == 92)
        {
            NameTagText.text = "Alia";
            dia.text = "Me too, where is our new journey going?";
        }
        else if (tang == 93)
        {
            NameTagText.text = "Vayne";
            dia.text = "Let's see... or go back to your hometown, you have to go back and tell your mother what happened or else she would be very worried.";
        }
        else if (tang == 94)
        {
            NameTagText.text = "Alia";
            dia.text = "Okay! Let's go, please show me the way!";
        }
        else if (tang == 95)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm... let's go.";
        }
        else if (tang == 96)
        {
            NameTagText.text = "";
            dia.text = "The end.";
        }
        else if (tang >= 97)
        {
            CutscenesController.cus114 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Outtro");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus114 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Outtro");
    }
}