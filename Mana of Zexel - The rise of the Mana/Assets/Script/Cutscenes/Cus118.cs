using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus118 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
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
            NameTagText.text = "Villager (Woman)";
            dia.text = "You must be Vayne right? We have been informed by Mr. Asila that we will be helping to restore the damage to the village.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Yes that's right! Is there anything I can help you with? Please let me know!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Currently I lost my husband when the inferno beast attacked the village. I ask you to help me find him.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Do you remember the last time you two met before being separated?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Last time we had to run south to avoid the attack. But then he suddenly disappeared.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "In the south? Could it be that her husband is lost in the nearby ice cave?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "I'm not sure because I haven't searched the ice cave yet.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, we'll help you find your husband. Please wait for good news from us!";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Yes, thank you very much!";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus118 = 1;
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
        CutscenesController.cus118 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}