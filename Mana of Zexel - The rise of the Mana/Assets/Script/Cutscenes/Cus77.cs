using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus77 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, AsilaVAL1;
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
            AsilaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Alright! I will tell you what happened before and when our two villages were closed to the outside world.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Asila";
            dia.text = "When our parents died, that was the ruler of both inferno volcano and inferno ice villages. Me and my brother Alasa are the next rulers.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Asila";
            dia.text = "Alasa and I used to get along well, when we became village chiefs, my brother and I both wanted to separate the independent land and only trade in goods. The work as well as the goods of the two sides are exchanged daily. Here we supply minerals and ores for heat-powered tools. Alasa will supply cold products such as ice and apparel.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Makes sense! Both villages use their strengths and weaknesses to help each other, but why are the two of them independent of each other?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Asila";
            dia.text = "That's right! We thought that when the whole village combined the territory like my parents did before, it would be difficult to manage, so I thought it would be best to split it up. At that time, we also exported goods from both sides to other villages. However, since I am the only one in charge of the export items, as my brother's duty, I don't want my brother to do as much work as I do. But Alasa disagrees.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Asila";
            dia.text = "However, Alasa wanted in return for the control of the land of alta inferno which is located to the west of both villages.";
        }
        else if (tang == 7)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Alta inferno? I have never heard of that land.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Asila";
            dia.text = "Of course the people outside our village don't know that. It is a fertile land used for farming and providing food for our two villages.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Asila";
            dia.text = "You know, my brother's personality is somewhat monopolistic, so I also accept letting his rule that fertile land. Until, one day...";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Asila";
            dia.text = "Someone destroyed that land, making the crops in that land no longer exist. And the only person my brother suspects is me. I swore with honor that I did not do it and no one wanted to, but Alasa did not believe me.";
        }
        else if (tang == 11)
        {
            MariaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "So the village you two had a conflict with.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Asila";
            dia.text = "My brother's distrust makes me very regretful about dividing the two villages like this. I wish my brother could understand and forgive me. Because of that, Alasa's export goods were also banned, and to avoid outside knowing about the conflict between the two villages, I cut off contact with the outside so that others wouldn't take advantage of the conflict between the two villages.";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "So it is. This is difficult to resolve if one party has lost the trust of the other.";
        }
        else if (tang == 14)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "... So you will continue to live in isolation like this forever?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Asila";
            dia.text = "...";
        }
        else if (tang == 16)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Alia... this thing...";
        }
        else if (tang == 17)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "You think there's no way, but in fact you're running away from it. Your brother must have felt as sad as you!";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Asila";
            dia.text = "My brother feels the same way?";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Alia";
            dia.text = "Think if the land of alta inferno is restored then everything will be solved!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Asila";
            dia.text = "Restore the land?";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Alia";
            dia.text = "That's right! Vayne once revived the rice crop for farmers in the town of Zexel. Nothing is impossible.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Asila";
            dia.text = "I don't think Alasa will believe this.";
        }
        else if (tang == 23)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "If so, we'll help you with this. We'll go there and tell your brother about the alta inferno reinstatement.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Asila";
            dia.text = "You... can you do it?";
        }
        else if (tang == 25)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alia said I saved a fertile land once, I'll probably do it again. Alia, thanks for giving me the idea.";
        }
        else if (tang == 26)
        {
            AsilaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like you can think too, Alia!";
        }
        else if (tang == 27)
        {
            VayneVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Nothing! But we have to convince the village chief Alasa first.";
        }
        else if (tang == 28)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Uhm!";
        }
        else if (tang == 29)
        {
            MariaVAL1.SetActive(false);
            AsilaVAL1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "I thank you as well as count on you. Please help me solve this troublesome conflict!";
        }
        else if (tang == 30)
        {
            NameTagText.text = "Vayne";
            dia.text = "Trust us, because if we can resolve the conflict we can convince the village chief Alasa to hand over Zexel's ice core.";
        }
        else if (tang >= 31)
        {
            CutscenesController.cus77 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno volcano");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus77 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}