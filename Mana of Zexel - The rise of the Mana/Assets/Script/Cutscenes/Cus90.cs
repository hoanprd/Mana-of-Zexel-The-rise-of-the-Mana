using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus90 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1;
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
            dia.text = "Okay! Another machine in inferno ice already.";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Ahhhhhh... It's those disgusting slimes again!";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Calm down Alia, don't touch them.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alia";
            dia.text = "Calm down, they keep coming towards me. Why don't they like the other two! I don't like you guys.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay, okay, I'll deal with them.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Let's get out of here, I'm freezing cold too!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "(It's hard to understand girls!)";
        }
        else if (tang >= 8)
        {
            CutscenesController.cus90 = 1;
            ContainerController.IceManaGenerator -= 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("InsideIceCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus90 = 1;
        ContainerController.IceManaGenerator -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideIceCave");
    }
}