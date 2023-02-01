using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus78 : MonoBehaviour
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
            NameTagText.text = "Shan";
            dia.text = "Oh it your guys again! Is everything okay in the inferno volcano village?";
        }
        else if (tang == 2)
        {
            NameTagText.text = "Alia";
            dia.text = "Hey Shan! Do you know what happened after we used your respected village chief Alasa's ice crystals?";
        }
        else if (tang == 3)
        {
            NameTagText.text = "Shan";
            dia.text = "I don't know anything, what I do is follow orders.";
        }
        else if (tang == 4)
        {
            NameTagText.text = "Alasa";
            dia.text = "What's so noisy? It your guys again?";
        }
        else if (tang == 5)
        {
            NameTagText.text = "Vayne";
            dia.text = "Alasa village chief, you took advantage of me to want to destroy your brother's village!";
        }
        else if (tang == 6)
        {
            NameTagText.text = "Alasa";
            dia.text = "Looks like that village is gone?";
        }
        else if (tang == 7)
        {
            NameTagText.text = "Vayne";
            dia.text = "That village is back to normal, thanks to us!";
        }
        else if (tang == 8)
        {
            NameTagText.text = "Alasa";
            dia.text = "So you came here to avenge my brother?";
        }
        else if (tang == 9)
        {
            NameTagText.text = "Maria";
            dia.text = "No, we're here to settle those two conflicts!";
        }
        else if (tang == 10)
        {
            NameTagText.text = "Alasa";
            dia.text = "Hum... So he told you everything? But I told him I wouldn't trust him anymore!";
        }
        else if (tang == 11)
        {
            NameTagText.text = "Alasa";
            dia.text = "If you think that I don't have faith, you're wrong! It was he who arranged the border management to silence us from outside help.";
        }
        else if (tang == 12)
        {
            NameTagText.text = "Vayne";
            dia.text = "No, he did it so he wouldn't be taken advantage of by the bad guys outside the village!";
        }
        else if (tang == 13)
        {
            NameTagText.text = "Alasa";
            dia.text = "So what about the land of alta inferno? How can we trust him?";
        }
        else if (tang == 14)
        {
            NameTagText.text = "Vayne";
            dia.text = "You two are brothers, the one who has no faith is you, Alasa. If I could revive alta inferno's crops, wouldn't that solve your conflict?";
        }
        else if (tang == 15)
        {
            NameTagText.text = "Alasa";
            dia.text = "This is our personal matter, no need to interfere.";
        }
        else if (tang == 16)
        {
            NameTagText.text = "Alia";
            dia.text = "Your brother is very sad about you, Asila entrusted us to prove him wrong by asking Vayne to revive the land of alta inferno for you Alasa!";
        }
        else if (tang == 17)
        {
            NameTagText.text = "Alasa";
            dia.text = "... What does he think... why would he want to revive that land?";
        }
        else if (tang == 18)
        {
            NameTagText.text = "Shan";
            dia.text = "... (We seem to be better than I thought. If so...)";
        }
        else if (tang == 19)
        {
            NameTagText.text = "Shan";
            dia.text = "Chief, what they say makes sense, as well as this is an opportunity to resolve the conflict that has been difficult for both sides for many years.";
        }
        else if (tang == 20)
        {
            NameTagText.text = "Alasa";
            dia.text = "... But how are you planning to revive that land when it's a dead land.";
        }
        else if (tang == 21)
        {
            NameTagText.text = "Vayne";
            dia.text = "You can trust us on this, we will handle the revival of the land ourselves.";
        }
        else if (tang == 22)
        {
            NameTagText.text = "Alasa";
            dia.text = "Okay, I will wait for good news from you.";
        }
        else if (tang >= 23)
        {
            CutscenesController.cus78 = 1;
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
        CutscenesController.cus78 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}