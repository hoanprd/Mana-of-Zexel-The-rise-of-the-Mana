using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus142 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1, KlenerVAL1, HeeriumVAL1, OrinaVAL1, ManaElfVAL1, ZaneVAL1, ZaneVAR1;
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
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Everything is ready, maybe I should go.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "I will miss this place very much, also the first mark of a long journey.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't worry Dad, I've learned a lot.";
        }
        else if (tang == 4)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Knock Knock knock...";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Who is that? Please come in!";
        }
        else if (tang == 6)
        {
            MrLanceVAR1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "It's me Vayne!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Ah, it's Mr. What about Lance? It's only early morning, you wake up really early!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Are you going to leave now?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, I was planning to leave early this morning.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "...";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well, the thing about Maria...";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "It's okay, I've prepared myself for that... Come to think of it, I still have people in this town. It's not like I'll be as lonely as you think.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "After all, she saved this town once, everyone values her as a hero like her mother.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? If that's the case, I'll save myself from blaming myself.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Don't be self-deprecating, Alia and Maria are both happy to meet someone like you, everyone will end up like the end of their story.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes, every journey comes to an end.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "I will visit this place again when I have a chance.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Okay, if you don't mind, I have a little surprise for you at the front door.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Surprise?...";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Open the door and you'll find out.";
        }
        else if (tang == 21)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            VayneVAL1.SetActive(false);
            MrLanceVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 22)
        {
            KlenerVAL1.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "Vayne! Everyone is waiting for you to say goodbye!";
        }
        else if (tang == 23)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "";
            dia.text = "Wow, you know I'm leaving today?";
        }
        else if (tang == 24)
        {
            KlenerVAL1.SetActive(false);
            OrinaVAL1.SetActive(true);
            NameTagText.text = "Orina";
            dia.text = "It was Alia who told us everything.";
        }
        else if (tang == 25)
        {
            OrinaVAL1.SetActive(false);
            HeeriumVAL1.SetActive(true);
            NameTagText.text = "Heerium";
            dia.text = "Huhuhuhu... can't you stay here much longer!";
        }
        else if (tang == 26)
        {
            HeeriumVAL1.SetActive(false);
            MrLanceVAL1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "I have some presents for you on the way, this food will last you for a few weeks.";
        }
        else if (tang == 27)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you everyone... thank you all for helping me over the years.";
        }
        else if (tang == 28)
        {
            MrLanceVAL1.SetActive(false);
            KlenerVAL1.SetActive(true);
            NameTagText.text = "Klener";
            dia.text = "We need to thank you too, Vayne, you've protected this town. Not only that, it also helps the surrounding villages.";
        }
        else if (tang == 29)
        {
            KlenerVAL1.SetActive(false);
            MrLanceVAL1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "That's why I thank you on behalf of all of you for everything and stay safe, Vayne!";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "Yes! And Alia isn't here?";
        }
        else if (tang == 31)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Looks like she went somewhere early in the morning!";
        }
        else if (tang == 32)
        {
            NameTagText.text = "Vayne";
            dia.text = "Well... So I'm on my way. Good bye!";
        }
        else if (tang == 33)
        {
            MrLanceVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "All";
            dia.text = "Goodbye and see you soon!";
        }
        else if (tang >= 17)
        {
            CutscenesController.cus142 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus142 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}