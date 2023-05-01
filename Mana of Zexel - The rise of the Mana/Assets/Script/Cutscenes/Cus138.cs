using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus138 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
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
            ZaneVAL1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "You guys are a lot stronger than last time, aren't you? You're surprised.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Of course! You think we'll come here unprepared?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Zane";
            dia.text = "That doesn't matter either...";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Zane! I want to ask you one more question?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Zane";
            dia.text = "Say it brat.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Maria";
            dia.text = "What do you plan to do after ruling this world?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Zane";
            dia.text = "... What the hell are you asking?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "What you do and your thoughts are completely separate. I know that you're in this mess because of your personal feelings. Although we didn't know each other before, you know that loneliness will follow you for the rest of your life along with the ambition of revenge.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Zane";
            dia.text = "Shut up! Sicxalon show me your strength.";
        }
        if (tang == 10)
        {
            ZaneVAL1.SetActive(true);
            MariaVAR1.SetActive(false);
            NameTagText.text = "Sicxalon";
            dia.text = "Gruuhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh...";
        }
        else if (tang == 11)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That monster's mana is terrible, did Zexel ever fight with this thing!";
        }
        else if (tang == 12)
        {
            ZaneVAR1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "What, kill them quickly, what are you waiting for!";
        }
        else if (tang == 13)
        {
            VayneVAL1.SetActive(false);
            ZaneVAR1.SetActive(false);
            NameTagText.text = "Sicxalon";
            dia.text = "Hmm.........";
        }
        else if (tang == 14)
        {
            ZaneVAL1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "No way... I've clearly mastered the sealing power... why can't I control it!";
        }
        else if (tang == 15)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Zane! Danger stay away from that monster!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Zane";
            dia.text = "!!!";
        }
        else if (tang == 17)
        {
            ZaneVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Sengggggggggggggg...";
        }
        else if (tang == 18)
        {
            ZaneVAL1.SetActive(true);
            NameTagText.text = "Zane";
            dia.text = "There's no way... I was killed by the monster itself!";
        }
        else if (tang == 19)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "That's what you get you villain.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Zane";
            dia.text = "Damn... let's see how you guys deal with that monster.";
        }
        else if (tang == 21)
        {
            AliaVAR1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We'll reincarnate it for you. Step aside and observe, we fight not for our selfishness but for our loved ones.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Vayne";
            dia.text = "Come on everyone, the final battle must be won!";
        }
        else if (tang >= 23)
        {
            CutscenesController.cus138 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSSicxalon 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus138 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSSicxalon 1");
    }
}