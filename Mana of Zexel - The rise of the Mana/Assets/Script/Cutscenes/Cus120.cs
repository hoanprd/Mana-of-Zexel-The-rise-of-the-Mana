using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus120 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject ZexelVAL1;
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
            NameTagText.text = "";
            dia.text = "Glowinggggggg...";
        }
        else if (tang == 2)
        {
            ZexelVAL1.SetActive(true);
            NameTagText.text = "Zexel";
            dia.text = "Remember one more thing. Unity is the key to victory.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Zexel";
            dia.text = "I used to be with my friends.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Zexel";
            dia.text = "Especially the older sister that I respect a lot.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Zexel";
            dia.text = "An alchemist with red hair named Maria helped me win the battle with Sicxalon.";
        }
        else if (tang == 6)
        {
            ZexelVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "To be countinute...";
        }
        else if (tang >= 7)
        {
            CutscenesController.cus115 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Epilogue");
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
        SceneManager.LoadScene("Epilogue");
    }
}