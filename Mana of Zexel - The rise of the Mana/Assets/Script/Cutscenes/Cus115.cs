using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus115 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1;
    public GameObject NameTag;
    private int tang = 0, stop1 = 0, stop2 = 0;

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
            dia.text = "Ma'am, is this mineral enough?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Thank you... thank you very much, this will help us a lot.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Vayne";
            dia.text = "No problem, glad to have helped.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "I ask you to accept this little bit of sincerity from me.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "";
            dia.text = "Photonria +1";
            if (stop1 == 0)
            {
                stop1 = 1;
                ContainerController.PhotonriaPick = 1;
            }
        }
        else if (tang == 6)
        {
            NameTagText.text = "";
            dia.text = "Baxiata +1";
            if (stop2 == 0)
            {
                stop2 = 1;
                ContainerController.BaxiataPick = 1;
            }
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "Does your family specialize in producing these gems?";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Yes, these mineral resources will be finely processed to obtain, but the precious gem is not only full of energy but also collectible, so its export value will be high.";
        }
        else if (tang == 9)
        {
            VayneVAL1.SetActive(false);
            NameTagText.text = "Vayne";
            dia.text = "So that's it! Really great.";
        }
        else if (tang >= 10)
        {
            CutscenesController.cus115 = 1;
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
        CutscenesController.cus115 = 1;
        ContainerController.LoadingOpen = true;
        if (tang < 5)
        {
            ContainerController.PhotonriaPick = 1;
            ContainerController.BaxiataPick = 1;
        }
        else if (tang == 5)
        {
            ContainerController.BaxiataPick = 1;
        }
        SceneManager.LoadScene("Inferno volcano");
    }
}