using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus89 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
            dia.text = "Okay! Finished a machine at inferno volcano already.";
        }
        else if (tang == 2)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "We should get out of here, it's really hot in here. Don't you have a better place to put your phone, Vayne?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hehe, I think here's as much fire element mana as possible.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "Then you go first.";
        }
        else if (tang == 5)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Wait for me and Maria!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "Hehe...";
        }
        else if (tang >= 7)
        {
            CutscenesController.cus89 = 1;
            ContainerController.FireManaGenerator -= 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("InsideVolcanoCave");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus89 = 1;
        ContainerController.FireManaGenerator -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideVolcanoCave");
    }
}