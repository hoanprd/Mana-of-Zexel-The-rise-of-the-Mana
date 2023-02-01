using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus31 : MonoBehaviour
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
            NameTagText.text = "Maria";
            dia.text = "Vayne! I suddenly remembered someone who is quite important in finding information!";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Vayne";
            dia.text = "Really? If so, who is that person?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Maria";
            dia.text = "If I remember correctly, this town has a girl who owns a grocery store that sells alchemy ingredients, she knows a lot of things.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Maria";
            dia.text = "She knows things that the people of the village don't know including the history and locations far from this town.";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Is she someone from another village? Maybe she's an archaeologist, so she knows so much.";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alia";
            dia.text = "Archeology? What's that? And hearing someone who knows almost everything sounds scary, doesn't it? It's like he's not an ordinary person!";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Maria";
            dia.text = "According to what the people in town say, she's like a witch! But that's just a rumour.";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Vayne";
            dia.text = "Maria never met her?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "That's right! Because of her eccentric nature, everyone gradually shunned her and so did she.";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Vayne";
            dia.text = "Oddly enough, a wise person is often liked by everyone rather than isolated.";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Maria";
            dia.text = "So you want to try her place, Vayne? Maybe she will know a lot of interesting things.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "Okay then I have to go see her! But what is her name and where is she?";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Maria";
            dia.text = "Well her name is Orina, remember that! And the accommodation is also near this pub, actually located on the left hand side of the pub next to the town's cliff.";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "In that case, let's go! Can't waste time in vain!";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey hey! Wait for me! Why doesn't anyone answer what an archaeologist is!";
        }
        else if (tang >= 16)
        {
            CutscenesController.cus31 = 1;
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
        CutscenesController.cus31 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}