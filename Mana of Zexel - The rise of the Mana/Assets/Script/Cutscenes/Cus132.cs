using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus132 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAL1;
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
            dia.text = "Barrier operation protect everyone in this town.";
        }
        else if (tang == 2)
        {
            va1.SetActive(false);
            va2.SetActive(true);
            VayneVAL1.SetActive(false);
            NameTagText.text = "";
            dia.text = "Glowinggggggggggggggg...";
        }
        else if (tang == 3)
        {
            va2.SetActive(false);
            va1.SetActive(true);
            MariaVAL1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "With this we can have some peace of mind.";
        }
        else if (tang == 4)
        {
            VayneVAR1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right! But we are not allowed to rest yet, there is still an inferno desert village in need of protection.";
        }
        else if (tang == 5)
        {
            MariaVAL1.SetActive(false);
            MrLanceVAL1.SetActive(true);
            NameTagText.text = "Mr. Lance";
            dia.text = "Maria!";
        }
        else if (tang == 6)
        {
            VayneVAR1.SetActive(false);
            MariaVAR1.SetActive(true);
            NameTagText.text = "Maria";
            dia.text = "Father? Why are you going out like this, it's dangerous here!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "I'm just a little worried, I don't want you to be in danger like this.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Maria";
            dia.text = "... I've decided, if I stay weak, I won't be able to protect anyone.";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "But you're my only relative, if something happens... we'll know what to do.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Maria";
            dia.text = "I rarely see you worrying about me like this, after all, I have Vayne and Alia, we will definitely return safely.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "We're going to deal with some things now, don't worry.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Promise me you'll come back.";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "It's too much for me to act like you're going to war. I promise to return to my father.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Mr. Lance";
            dia.text = "Good luck.";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Maria";
            dia.text = "Uhm, let's go Vayne, Alia, we're starting to be the heroes of the world.";
        }
        else if (tang >= 16)
        {
            CutscenesController.cus132 = 1;
            ContainerController.LoadingOpen = true;
            MapController.TavernToSaveRoom = false;
            MapController.WishingForestToZexelTown = true;
            SceneManager.LoadScene("Zexel town");
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus132 = 1;
        ContainerController.LoadingOpen = true;
        MapController.TavernToSaveRoom = false;
        MapController.WishingForestToZexelTown = true;
        SceneManager.LoadScene("Zexel town");
    }
}