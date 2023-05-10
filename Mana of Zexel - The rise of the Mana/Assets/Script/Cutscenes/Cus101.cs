using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus101 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1, MeruVAR1;
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
            MrLanceVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Are you two back? Alia is much better now.";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Well then, we brought back the dragon scales.";
        }
        else if (tang == 3)
        {
            MrLanceVAL1.SetActive(false);
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Mrs. Meru, we're counting on you.";
        }
        else if (tang == 4)
        {
            MariaVAR1.SetActive(false);
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Unexpectedly, these are real mana dragon scales. Okay, it will take quite a while to make the antidote.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is there anything we can do to help?";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Meru";
            dia.text = "No need, only me is enough. And you should also look at yourself, don't carry so much responsibility that destroys your body.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "...I see...";
        }
        else if (tang == 8)
        {
            VayneVAL1.SetActive(false);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We should go out for a while and rest, Vayne. Alia will definitely be fine.";
        }
        else if (tang == 9)
        {
            MeruVAR1.SetActive(false);
            MrLanceVAR1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Then let me make dinner for everyone.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus101 = 1;
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
        CutscenesController.cus101 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}