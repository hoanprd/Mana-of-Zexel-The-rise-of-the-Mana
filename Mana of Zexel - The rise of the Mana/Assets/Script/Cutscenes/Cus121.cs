using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus121 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1;
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
            NameTag.SetActive(true);
            NameTagText.text = "Villager (Woman)";
            dia.text = "Hey, did you go somewhere? Did you know that...";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I'm sorry, just because of the wedding ring I dropped...";
        }
        else if (tang == 3)
        {
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Calm down you two, your husband was very persistent in finding his wedding ring under the ice cave despite the danger down there.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes, please don't be mad at your husband, he just doesn't want you to be upset about the previous memory.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Thanks everyone, without your help it seems I would have given up.";
        }
        else if (tang == 6)
        {
            MariaVAL1.SetActive(false);
            VayneVAR1.SetActive(false);
            NameTagText.text = "Villager (Woman)";
            dia.text = "Hey,...";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I'm sorry...";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "You don't need to apologize, I... I was so worried about you! If you die, I'll know what to do!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "I won't act foolishly anymore,...";
        }
        else if (tang == 10)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Looks like it's all worked out.";
        }
        else if (tang >= 11)
        {
            CutscenesController.cus121 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Inferno ice");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus121 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}