using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus71 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, ShanVAL1, AsilaVAR1;
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
            ShanVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "Everyone please wait outside, I will explain to Asila village chief.";
        }
        else if (tang == 2)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "I see, we'll wait.";
        }
        else if (tang == 3)
        {
            ShanVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Hey, do you two feel something strange?";
        }
        else if (tang == 5)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Is there anything unusual, Maria?";
        }
        else if (tang == 6)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "... It's normal for me right now. Anyway, the village chief Alasa made it possible for us to get the fire core.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "It doesn't matter, we still don't know why these two lands are closed to other villages and towns.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "... I don't know about that either.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "Just like I hope the two village chiefs here don't have any conflict with each other.";
        }
        else if (tang == 10)
        {
            MariaVAL1.SetActive(false);
            ShanVAL1.SetActive(true);
            NameTagText.text = "Shan";
            dia.text = "There's good news for everyone, village chief Asila has already agreed to let you get the fire core.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Vayne";
            dia.text = "Thank you so much Shan!";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Shan";
            dia.text = "Nothing! (I have to thank everyone.)";
        }
        else if (tang == 13)
        {
            VayneVAR1.SetActive(false);
            AsilaVAR1.SetActive(true);
            NameTagText.text = "Asila";
            dia.text = "I pray that you can obtain the energy core without affecting the village.";
        }
        else if (tang == 14)
        {
            ShanVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "We promise we won't trouble this village! And is the village chief really going to give us an energy core like that, after all, it's the treasure of this village.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Asila";
            dia.text = "If this village does not have a fire core, it will be difficult to exploit the mineral resources here, but I want someone to take it away because that energy core is what attracts monsters around. village.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Asila";
            dia.text = "For a long time, Alasa and I have always wanted to live on fertile land and be able to grow and raise livestock like other villages. But fate is as ironic as it is now.";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Vayne";
            dia.text = "If so, could you please tell me the location of the fire core.";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Asila";
            dia.text = "The fire energy core is deep inside the volcano, just go north to get there. I will go with your group to see the situation.";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Vayne";
            dia.text = "Chief, please trust us.";
        }
        else if (tang >= 20)
        {
            CutscenesController.cus71 = 1;
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
        CutscenesController.cus71 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno volcano");
    }
}