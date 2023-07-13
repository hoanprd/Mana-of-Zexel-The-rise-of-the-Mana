using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus98 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, OrinaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        StartCoroutine(DelayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Oh Orina! Are you here?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Is something wrong?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We came here to inquire about something that absorbs magic like dragon mana scales.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Orina";
                dia.text = "Dragon scales mana? So that's it, it's also a good idea.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Do you know where it is?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Of course I know, the problem is I don't know if you guys can get it. If you want to get dragon scales, you have to fight that mana dragon.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "We have to save Alia so the danger is natural.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Okay, I don't want to waste your time either. That dragon is on the mana cliff.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Where exactly?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "If I remember correctly, somewhere southwest of that inferno desert village. But that's just what I thought, but I'm not sure there's a mana dragon there.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "At least we can look around. As for dragons, I've never seen them in real life either.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "The mana dragon is different from normal, it looks like a cow?";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "A... cow? Does it really look like that?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Orina";
                dia.text = "That kind of dragon is quite rare anyway, if you see a flying cow, it's a mana dragon.";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you, Orina, if that's the case, here we go!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "Yeah, nothing.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus98 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Orina ơi! Cô có ở đây chứ?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Có chuyện gì à?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng tôi qua đây để hỏi thăm về một thứ có hấp thụ ma thuật như vảy rồng mana chẳng hạn.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Orina";
                dia.text = "Vẩy rồng mana? Ra là thế, đó cũng là ý kiến không tồi.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cô biết nó ở đâu chứ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Tất nhiên là biết rồi, vấn đề là không biết mấy người có lấy được không thôi. Muốn lấy vảy rồng thì phải đánh nhau với con rồng mana đó đấy.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi phải cứu Alia nên chuyện nguy hiểm là đương nhiên rồi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Được thôi, tôi cũng không muốn mất thì giờ của mấy người. Con rồng đó ở vách núi mana đấy.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cụ thể là ở đâu thế?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "Nếu nhớ không lầm thì đâu đó phía tây nam của ngôi làng inferno desert đó. Mà tôi chỉ nghĩ vậy thôi chứ chưa chắc là có con rồng mana ở đó đâu.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ít ra chúng tôi có đi tìm kiếm xung quanh là được. Mà về loài rồng, tôi cũng chưa thấy ngoài đời bao giờ.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "Con rồng mana khác với bình thường đấy, trông nó như con bò vậy?";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Con... bò? Thực sự nó trông như thế ư?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Orina";
                dia.text = "Loài rồng đó khá hiếm đó dù sao thì thấy con bò biết bay thì đó là con rồng mana đó.";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn cô Orina, nếu vậy thì chúng tôi đi đây!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "Ừ không có gì.";
            }
            else if (tang >= 17)
            {
                CutscenesController.cus98 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus98 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}