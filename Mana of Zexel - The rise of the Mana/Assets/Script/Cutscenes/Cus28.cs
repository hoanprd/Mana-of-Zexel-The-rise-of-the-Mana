using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus28 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, HeeriumVAR1;
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
                dia.text = "Uncle Heerium! We're back with the ingredients you need!";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Very timely with this abundant source of iron, the weapon will be very good hahaha!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Damn it! Remember to make a super powerful weapon for me!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Heerium";
                dia.text = "Don't worry, just trust me hahaha! But it will take time to complete them, you can come back later!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you! By the way, does Uncle Heerium know about Zexel temple?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Heerium";
                dia.text = "Oh, that temple, I don't know. He met many adventurers and soldiers who were his customers who went to the temple but no one returned.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Is that scary? Don't tell me that temple has not only monsters but also ghosts?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "I don't know but I remember there was a survivor many times when he went to that temple, remember that person looked a bit like Vayne but older.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "??? Could it be that that person is my father!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Heerium";
                dia.text = "Vayne's father? Most likely, it's been over a year and I still haven't seen him, usually he loves your weapon service! Not only that, but he's also with someone who looks like a magician!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Magician? Almost no mages have appeared since the war mages era.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "I just thought so!";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I've never met a magician either!";
            }
            else if (tang == 14)
            {
                HeeriumVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What is a magician?";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I just understood that they are quite similar to alchemists but they don't make tools from mana like alchemists, they use mana to fight is chanting magic.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Like magic? Alchemy can't do magic?";
            }
            else if (tang == 17)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "There's only a small amount of magic, so my mom used to say that magicians and alchemists don't have a difference.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well, we should go back to prepare our luggage through the desert, then Heerium will finish making weapons for us!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus28 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("WeaponStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chú Heerium! Bọn cháu về cùng với nguyên liệu chú cần rồi đây!";
            }
            else if (tang == 2)
            {
                HeeriumVAR1.SetActive(true);
                NameTagText.text = "Heerium";
                dia.text = "Kịp lúc lắm với nguồn sắt dồi dào này vũ khí sẽ chất lượng lắm đây hahaha!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mệt chết đi được! Chú nhớ làm một vũ khí siêu mạnh cho cháu đấy!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Heerium";
                dia.text = "Đừng lo, cứ tin tưởng ở ta hahaha! Nhưng sẽ mất thời gian để hoàn thành chúng, có gì các cháu có thể ghé lại sau nhé!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cháu cảm ơn! À mà chú Heerium có biết thông tin về ngôi đền Zexel không?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Heerium";
                dia.text = "Ồ, ngôi đền đó sao, ta cũng không biết nữa. Chú gặp rất nhiều nhà phiêu lưu và binh sĩ từng là khách hàng của chú đã đến ngôi đền ấy nhưng không ai quay trở lại.";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đáng sợ đến cơ đó ư? Đừng nói là ngôi đền ấy không chỉ có quái vật mà còn có ma ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chú không biết nhưng chú nhớ có người sống sót nhiều lần khi đến ngôi đền ấy nhớ không lầm người đó trông khá giống Vayne nhưng già hơn.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "??? Không lẽ nào người đó là cha cháu!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Heerium";
                dia.text = "Cha của Vayne ư? Cũng có thể lắm, đã hơn một năm rồi ta vẫn chưa gặp lại anh ta, thường anh ta rất thích dịch vụ vũ khí của chú! À không chỉ thế anh ta còn đi với một người nữa trông giống như một pháp sư vậy!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Pháp sư ư? Hầu như không còn pháp sư nào xuất hiện kể từ thời ma sư chiến.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Heerium";
                dia.text = "Chú chỉ nghĩ vậy thôi!";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cháu cũng chưa từng gặp pháp sư bao giờ cả!";
            }
            else if (tang == 14)
            {
                HeeriumVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Pháp sư là gì thế?";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em cứ hiểu như họ khá giống với nhà giả kim nhưng không có chế tạo dụng cụ từ mana như giả kim thuật mà họ dùng mana để chiến đấu là niệm chú phép thuật là chính.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Như phép thuật ư? Giả kim thuật không thể làm phép thuật ư?";
            }
            else if (tang == 17)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thuật ra cũng một số ít phép thuật thôi nên mẹ tớ từng nói pháp sư với nhà giả kim vốn không ưu nhau.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mà thôi chúng ta nên quay về để chuẩn bị hành trang qua sa mạc thôi lúc ấy chú Heerium sẽ chế tạo vũ khí cho chúng ta xong đó!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus28 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("WeaponStore");
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
        CutscenesController.cus28 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("WeaponStore");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}