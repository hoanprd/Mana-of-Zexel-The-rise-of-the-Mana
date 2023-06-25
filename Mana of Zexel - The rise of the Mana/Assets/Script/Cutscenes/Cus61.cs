using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus61 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, ShanVAL1, ShanVAR1, AsilaVAR1;
    public GameObject NameTag;
    private int tang = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {

        }
        else
        {

        }
        if (tang == 1)
        {
            AliaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "I wonder if the village chief will see us or not, why is it taking so long!";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Just calm down, as long as we're being honest.";
        }
        else if (tang == 3)
        {
            AliaVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Someone came out!";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Lucky for everyone, the village chief is willing to meet you.";
        }
        else if (tang == 5)
        {
            MariaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Really! Thank you so much Shan!";
        }
        else if (tang == 6)
        {
            ShanVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "My name is Asila and I am the village chief in this area. Hey guys, what's wrong with you coming here to see me? If it doesn't matter, don't blame me for going crazy.";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Oh my gosh! He so fierce!";
        }
        else if (tang == 8)
        {
            AliaVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Chief, my name is Vayne, the other two are Alia and Maria, we came here to search for energy cores in the land of inferno volcano created by alchemist Zexel a hundred years ago.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Asila";
            dia.text = "I refuse!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "... But why?";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Asila";
            dia.text = "You should know that energy core is what sustains our village if you take it away this village will be engulfed in flames.";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(false);
            AsilaVAR1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "...";
        }
        else if (tang == 13)
        {
            ShanVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Impossible!";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "(Impossible, do the mana gods want us to destroy this village?)";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "(No, it's not like that if I let my selfishness take over, I'll never be able to open that gate.)";
        }
        else if (tang == 16)
        {
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "You guys go home, even if I die I will never give you energy cores!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "...";
        }
        else if (tang == 18)
        {
            AsilaVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Let's go, Vayne. Surely there is a way to solve this.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "If that's the case then we're really sorry that we don't know the consequences of this, if that's the case then we're sorry.";
        }
        else if (tang == 20)
        {
            MariaVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "Hum... It's annoying.";
        }
        else if (tang == 21)
        {
            VayneVAL1.SetActive(false);
            AsilaVAR1.SetActive(false);
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 22)
        {
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey, should we gather some ingredients in this land? To thank Heerium for helping us and he will be happy to receive resources here.";
        }
        else if (tang == 23)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "You're right! If that's the case, then I'll gather some ingredients here and come back.";
        }
        else if (tang == 24)
        {
            AliaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "(Hmm... Interesting I should report this to him.)";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus61 = 1;
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
        CutscenesController.cus61 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}