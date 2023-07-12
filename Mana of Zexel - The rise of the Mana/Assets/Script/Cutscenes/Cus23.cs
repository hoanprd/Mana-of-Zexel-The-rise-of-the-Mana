using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus23 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, MariaVAR1, KlenerVAL1, KlenerVAR1;
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
                dia.text = "Delicious food has arrived!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ahhh! Great, I'm so hungry!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehee";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... This just porridge?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Is this really just porridge?";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It doesn't matter if it's porridge or not, everyone just taste it! It's very unusual!";
            }
            else if (tang == 7)
            {
                KlenerVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Woah!";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Huh?";
            }
            else if (tang == 9)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... It's just porridge! But wait, there is something very strange in this bowl of porridge, I feel like I am getting better than usual.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe, Maria please take a look?";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "The feeling of eating is full of coffee!";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This feeling is having mana infused inside.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, that's the mana porridge. To make a nutritious dish, porridge is a reasonable thing because liquid food will help the body absorb the mana inside faster, making the body full of energy.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Interesting, back then I thought alchemy was only used as a healing item instead of that food.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's very simple, but as long as the alchemist's mana is infused, any dish will be delicious.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "If so, I have a lot to try.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "Delicious! Hey Vayne, you do this often.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Of course as long as people like it. Anyway, let's all eat well and prepare for the information search, and I'll go and prepare some little alchemy tools.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus23 = 1;
                ContainerController.Porridge -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Món ngon đã đến đây!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ahhh! Tuyệt vời, mình đói lắm rồi đó!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehee";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Chỉ là cháo thôi sao?";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Đây thực sự chỉ là cháo?";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không quan trọng là cháo hay không mọi người cứ nếm thử hương vị nó đi! Nó rất khác thường đấy!";
            }
            else if (tang == 7)
            {
                KlenerVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Woah!";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "... Huh?";
            }
            else if (tang == 9)
            {
                KlenerVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Nó chỉ là cháo thôi mà! Mà khoan có gì đó rất lạ trong tô cháo này cảm giác như mình được khỏe lại hơn bình thường.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe, Maria hãy đón thử xem?";
            }
            else if (tang == 11)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cảm giác ăn vào phê cả người luôn ấy!";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cảm giác này là có mana truyền vào bên trong.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế đó là món cháo mana đó. Để làm được một món ăn đầy đủ dinh dưỡng thì cháo là thứ hợp lý vì đồ ăn lỏng sẽ giúp cho cơ thể hấp thụ mana bên trong nhanh hơn khiến cơ thể tràn đầy sinh lực.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Thú vị thật, hồi giờ chị tưởng giả kim thuật chỉ dùng làm đồ hồi phục thay vì đồ ăn đó.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Rất đơn giản thôi đúng chứ chỉ cần mana của nhà giả kim truyền vào thì món ăn nào cũng ngon hết.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy chị cũng có nhiều thứ để thử đó.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "Ngon tuyệt! Này Vayne cậu thường xuyên làm thứ này nhé.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tất nhiên rồi miễn là mọi người thích. Dù sao thì mọi người cứ ăn no đi để rồi chuẩn bị công cuộc tìm kiếm thông tin nhé, còn tớ sẽ đi chuẩn bị vài dụng cụ giả kim tý.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus23 = 1;
                ContainerController.Porridge -= 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
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
        CutscenesController.cus23 = 1;
        ContainerController.Porridge -= 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(0, false);
    }
}