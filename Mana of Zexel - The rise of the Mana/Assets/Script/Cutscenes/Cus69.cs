using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus69 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3, FOP;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, ShanVAL1, ShanVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I can clearly feel the mana in this area, not only that the mana here contains ice element.";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Mana ice elemental? What's that?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't you know, Maria? Mana can still contain elements.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Really? I never knew about this case.";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Ice crystals are probably around here.";
        }
        else if (tang == 6)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Everyone, split up and search.";
        }
        else if (tang == 7)
        {
            ShanVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            va1.SetActive(false);
            va2.SetActive(true);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 8)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Is there a crystal ball on this side? I feel a huge amount of mana from that thing.";
        }
        else if (tang == 9)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Hey everyone, come see this.";
        }
        else if (tang == 10)
        {
            va2.SetActive(false);
            va3.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "This is...";
        }
        else if (tang == 11)
        {
            AliaVAR1.SetActive(false);
            ShanVAR1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "As described by the village chief, it's the ice crystal we're looking for.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Then just bring it back to the village chief. Hmm...";
        }
        else if (tang == 13)
        {
            VayneVAL1.SetActive(false);
            ShanVAR1.SetActive(false);
            FOP.SetActive(true);
            NameTagText.text = "";
            dia.text = "Glowing...";
        }
        else if (tang == 14)
        {
            FOP.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "(What is this, Orina's glass jar is glowing?)";
        }
        else if (tang == 15)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "!!!";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Maria";
            dia.text = "Shan! Danger behind! Avoid it.";
        }
        else if (tang == 17)
        {
            VayneVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "!!!";
        }
        else if (tang == 18)
        {
            ShanVAL1.SetActive(false);
            MariaVAR1.SetActive(false);
            NameTagText.text = "Ice slime";
            dia.text = "Grgggggggggggggggg...";
        }
        else if (tang == 19)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Shield!";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne! Quickly deal with that slime.";
        }
        else if (tang == 21)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Hyaaaaaaaaaaaaaaaaaaaa... mana strike.";
        }
        else if (tang == 22)
        {
            MariaVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "... Thanks for just now.";
        }
        else if (tang == 23)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's nothing, but you often patrol around the two villages? If that's the case, it's dangerous, your parents will be worried!";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Shan";
            dia.text = "My parents passed away when I was young.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Vayne";
            dia.text = "... Then I'm sorry about it.";
        }
        else if (tang == 24)
        {
            NameTagText.text = "Shan";
            dia.text = "We should be back soon.";
        }
        else if (tang >= 25)
        {
            CutscenesController.cus69 = 1;
            ContainerController.LoadingOpen = true;
            ContainerController.IceCrystalPick = 1;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus69 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.IceCrystalPick = 1;
        SceneManager.LoadScene("InsideIceCave");
    }
}