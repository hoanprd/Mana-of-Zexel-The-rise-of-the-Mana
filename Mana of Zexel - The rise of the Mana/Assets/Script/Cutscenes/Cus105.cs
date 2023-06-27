using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus105 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, JescaVAL1, MeruVAR1;
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
            if (tang == 1)
            {
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Oh grandma! You are back!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "I'm back! Is my granddaughter at home well?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Jesca";
                dia.text = "Of course it's fine, I also prepared some premixed medicine while you were away.";
            }
            else if (tang == 4)
            {
                MeruVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "You're so good Jesca, do you want to be a great doctor like your grandmother?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Jesca";
                dia.text = "Ah, Alia, are you feeling well! I'm very happy to meet you.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Jesca";
                dia.text = "Are you thinking of stopping by here?";
            }
            else if (tang == 7)
            {
                JescaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Too bad we'll have to go back to Zexel town, if given the chance I'll visit.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "You guys better be careful. Wounds like that are hard to save.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "We'll be more careful.";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "By the way, Mrs. Meru, what do you mean by calling the girl we met before a magician?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Meru";
                dia.text = "Just a guess, usually magicians have silver hair as well as eye color.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Meru";
                dia.text = "But forget it, I feel like she's your friend so it should be fine.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Anyway, we thank you very much.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Meru";
                dia.text = "It's okay, I wish you all a safe journey.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus105 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                JescaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "À bà nội ơi! Bà về rồi à!";
            }
            else if (tang == 2)
            {
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Bà về rồi đây! Cháu gái của bà ở nhà ngoan chứ?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Jesca";
                dia.text = "Tất nhiên là ngoan rồi, cháu cũng chuẩn bị một số loại thuốc pha sẵn trong lúc bà vắng nhà đấy.";
            }
            else if (tang == 4)
            {
                MeruVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Em giỏi thật đấy Jesca, em muốn trở thành một vị thầy thuốc vĩ đại như bà của em à?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Jesca";
                dia.text = "À chị Alia, chị khỏe lại rồi ư! Em rất vui khi được gặp chị đấy.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Jesca";
                dia.text = "Anh chị có tính ghé lại đây chơi không?";
            }
            else if (tang == 7)
            {
                JescaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật tiếc là bọn anh sắp phải quay về lại thị trấn Zexel rồi, nếu như có dịp anh sẽ ghé thăm.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Mấy đứa tốt nhất nên cẩn thận. Những vết thương như thế rất khó mà cứu được đó.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bọn cháu sẽ cẩn thận hơn ạ.";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "À mà bà Meru, vừa nãy bà gọi cô gái mà chúng ta gặp trước kia là một ma pháp sư là có ý gì thế?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Meru";
                dia.text = "Chỉ là phỏng đoán thôi, thường thì các ma pháp sư sẽ có màu tóc cũng như màu mắt đặc trưng là bạc.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Meru";
                dia.text = "Mà bỏ qua đi, ta cảm thấy cô ấy là bạn của mấy cháu nên chắc sẽ không sao đâu.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Dù sao thì bọn cháu cảm ơn bà nhiều.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Meru";
                dia.text = "Không có gì, ta chúc mấy đứa đi đường bình an nhé.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus105 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus105 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}