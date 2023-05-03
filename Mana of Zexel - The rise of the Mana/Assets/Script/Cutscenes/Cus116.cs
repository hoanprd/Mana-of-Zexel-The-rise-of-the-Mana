using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus116 : MonoBehaviour
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
            NameTagText.text = "Villager (Man)";
            dia.text = "You must be Vayne right? We have been informed by Mr. Asila that we will be helping to restore the damage to the village.";
        }
        else if (tang == 2)
        {
            VayneVAL1.SetActive(true);
            NameTagText.text = "Vayne";
            dia.text = "That's right! I came here to see if anyone needs any help.";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "Sir Asila has made a policy to start exporting the popular items of the village to the outside. Our family is responsible for transporting goods to the trading point, but the road is quite difficult right now.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Vayne";
            dia.text = "Difficult, the passage is no longer usable?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Villager (Man)";
            dia.text = "The inferno beast's attack has missed the safe path. So now the rest of the way, there are so many wild wolves guarding that we can't go there.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Vayne";
            dia.text = "I see, just cleaning up those wild wolves is fine, right?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Villager (Woman)";
            dia.text = "Yes, bother you, please help me.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "It's okay, we'll be honor to do that!";
        }
        else if (tang >= 9)
        {
            CutscenesController.cus116 = 1;
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
        CutscenesController.cus116 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}