using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus41 : MonoBehaviour
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
            NameTagText.text = "Maria";
            dia.text = "Here it is! The Zexel Gate? It looks really big, not only that, I can feel something huge behind this gate.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! A huge source of magic power. But the question is, how can we get through this gate?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Alia";
            dia.text = "Don't worry, we can climb over it. Take a look here!";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Hyaaaaaaa... Come on!";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Wait Alia! There's a boundary!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "What! Ahhhhhhhhh...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia! You okay Alia?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alia";
            dia.text = "Uhm... I'm fine, luckily I haven't put all my strength into it yet.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "This barrier isn't easy to break. I've never seen a barrier cover like this continuously.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "So if we break the barrier it will regenerate automatically?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Perhaps the gate will give us a way to unlock it.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Let me see.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Vayne";
            dia.text = "Dear power of mana, lead the way! Show me the way to go!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "";
            dia.text = "Glowing....";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Is the gate reacting?";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Does it work! Who is that?";
        }
        else if (tang == 17)
        {
            NameTagText.text = "???";
            dia.text = "...";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Maria";
            dia.text = "That's what men deserve!";
        }
        else if (tang == 19)
        {
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Vayne";
            dia.text = "Who are you?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alia";
            dia.text = "This woman...";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Zexel";
            dia.text = "Welcome! My name is Zexel, who is sleeping peacefully behind the gate inside the temple.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Zexel";
            dia.text = "Only those who are worthy can pass through this gate.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "How worthy are these people to deserve?";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Zexel";
            dia.text = "To become worthy if and only if one can break the two polar opposites and bring back peace.";
        }
        else if (tang == 26)
        {
            NameTagText.text = "Maria";
            dia.text = "Gone, what does that last sentence mean?";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Vayne";
            dia.text = "Are you kidding me? In the end, we don't know anything.";
        }
        else if (tang == 28)
        {
            NameTagText.text = "Alia";
            dia.text = "(That woman, it feels so familiar in my heart...)";
        }
        else if (tang == 29)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Let's go back to town.";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Maria";
            dia.text = "Do you have any ideas?";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Vayne";
            dia.text = "I don't know but there's a way.";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Maria";
            dia.text = "Okay, then we'll go home. Hey Alia, are you all right?";
        }
        else if (tang == 33)
        {
            NameTagText.text = "Alia";
            dia.text = "Yes! Wait for me!";
        }
        else if (tang == 34)
        {
            NameTagText.text = "Alia";
            dia.text = "(Zexel? Not strange but very familiar?)";
        }
        else if (tang >= 35)
        {
            CutscenesController.cus41 = 1;
            SceneManager.LoadScene("Zexel gate");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus41 = 1;
        SceneManager.LoadScene("Zexel gate");
    }
}