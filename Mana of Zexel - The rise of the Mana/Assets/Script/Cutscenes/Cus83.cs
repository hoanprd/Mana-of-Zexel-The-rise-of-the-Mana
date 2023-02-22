using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus83 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAL1;
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
            MariaVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "It's been a long journey, isn't it?";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Yes, but I'm happy to have resolved the conflict between the two villages of inferno volcano and inferno ice.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Vayne, what are you going to do next?";
        }
        else if (tang == 4)
        {
            AliaVAR1.SetActive(false);
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Well, I want to take advantage of the mana resources in the inferno volcano and inferno ice to restore the mana I spent quite a bit.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "You mean create more mana transmitters and receivers in that land?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "That's right! But this time I will upgrade it to absorb the elements in those two places.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "Interesting! I wish you luck, my sister and Alia will always be there to support you.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Uhm! I'll do this quickly.";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus83 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus83 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}