using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus112 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
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
            NameTagText.text = "Vayne";
            dia.text = "Looks like the monster just now is the last one to deal with.";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Why did they attack inside the town so suddenly, they don't dare to go deep into the town these days.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "Something provoked them. Surely the earthquake just now had something to do with this.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria, are you all right?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Maria";
            dia.text = "I'm fine, you are fine dad! Phuhhh...";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Klener";
            dia.text = "Thank you, Vayne, the people have been safely evacuated.";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Alia";
            dia.text = "Will the material monsters come if we're absent? We can't keep this going.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "I'll use the barrier to stop them.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "If it's the barrier I used, it won't be strong enough to hold them back.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Don't worry I will upgrade the barrier stronger to protect the town of Zexel and the village in the inferno desert. Make sure to give us enough time to get rid of Zane.";
        }
        else if (tang >= 11)
        {
            CutscenesController.cus112 = 1;
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
        CutscenesController.cus112 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}