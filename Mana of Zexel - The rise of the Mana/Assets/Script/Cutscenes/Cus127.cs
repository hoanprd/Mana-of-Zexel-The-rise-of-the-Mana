using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus127 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MeruVAR1;
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
            VayneVAL1.SetActive(true);
            NameTag.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Everyone get out of here because there's going to be a big explosion!";
        }
        else if (tang == 2)
        {
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Everyone's in the safe zone, Vayne! Let it explode.";
        }
        else if (tang == 3)
        {
            VayneVAL1.SetActive(false);
            AliaVAR1.SetActive(false);
            NameTagText.text = "";
            dia.text = "...";
        }
        else if (tang == 4)
        {
            NameTagText.text = "";
            dia.text = "Boooooooooooooooooooommmmmmmm...";
        }
        else if (tang == 5)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "Cough... Cough... All right!";
        }
        else if (tang == 6)
        {
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Look, there's an underground spring. Success!";
        }
        else if (tang == 7)
        {
            VayneVAL1.SetActive(false);
            AliaVAL1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "Great with this water, people don't have to worry anymore.";
        }
        else if (tang == 8)
        {
            MariaVAR1.SetActive(false);
            MeruVAR1.SetActive(true);
            NameTagText.text = "Meru";
            dia.text = "Great, now we just need to get diggers for a bigger geyser.";
        }
        else if (tang == 9)
        {
            AliaVAL1.SetActive(false);
            NameTagText.text = "Villager (Man)";
            dia.text = "Mrs. Meru! It's dangerous!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Meru";
            dia.text = "What is it? Why are you in such a hurry!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "The monster has entered the village! Everyone, please run away!";
        }
        else if (tang == 12)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "It's the inferno scorpion monsters, they want to invade this village?";
        }
        else if (tang == 13)
        {
            MeruVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Looks like something happened to them, especially the earthquake just now that drove them crazy.";
        }
        else if (tang == 14)
        {
            MariaVAR1.SetActive(false);
            AliaVAR1.SetActive(true);
            NameTagText.text = "Alia";
            dia.text = "We have to help them, we can't stand by.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Vayne";
            dia.text = "Be careful, Alia! That monster is more ferocious than usual, can't be subjective.";
        }
        else if (tang >= 16)
        {
            CutscenesController.cus127 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("BSInfernoScorpion 1");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus127 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSInfernoScorpion 1");
    }
}