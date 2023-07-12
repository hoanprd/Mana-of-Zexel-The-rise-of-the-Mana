using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus42 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAR1, MrLanceVAL1, MrLanceVAR1, OrinaVAL1;
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
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Oh everyone! Haven't they all found the gate of Zexel yet? Looking so tired and sad!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We found it, but we can't open the gate because we're not worthy.";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "At that time, we received a message to open the gate without understanding anything.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "A message? So what is that message?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hum... It seems to be to be worthy if and only if one can break the two polar opposites and bring back peace.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hum... I don't get it either haha!";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Honestly, you always laugh at other people's pain.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I don't really get it, come to think of it, it feels like the message sent me to do something related to conflict resolution.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Reminds me of your father and his friend.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "My father's friend? When my father left, he was alone. No wonder he made friends on the way here.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "It seems so, I clearly remember he had a man with long hair who always accompanied your father on quests when he came to this village. It seems they both have the same purpose as the temple of Zexel.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "At that time, those two were always arguing, neither of them would give in.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hey Mr. Lance, do you have any information on that man?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I'm afraid no, that guy didn't give any specific information, only your father did. But remember that guy's name is Zane right.";
            }
            else if (tang == 15)
            {
                MrLanceVAL1.SetActive(false);
                OrinaVAL1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Interesting isn't it? Did you guys find the Zexel portal?";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Yes, we found the gate but...";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "But can't open it?";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... That's right. But wait, Orina, what are you doing here?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Well, I came here to give some food to Mr. Here's Lance.";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Excuse me, Orina, you can just leave it on the table for now.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Vayne! Want to know how to open the gate? Come over to my place, I can help.";
            }
            else if (tang == 22)
            {
                MrLanceVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Really? If so, thank you in advance!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Orina";
                dia.text = "Uhm! See you again.";
            }
            else if (tang == 24)
            {
                OrinaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I have a bad feeling about this.";
            }
            else if (tang == 25)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Me too! How does she know how to open the gate when she's never been there?";
            }
            else if (tang == 26)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Even so, as long as the gate is open, the problem is solved, let's go to Orina's place!";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus42 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Ồ mọi người! Tất cả vẫn chưa tìm được cánh cổng Zexel à? Trông mệt mỏi và buồn bã thế!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bọn cháu tìm được rồi mà chẳng thể mở được cánh cổng vì không phải là người xứng đáng.";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Lúc ấy, bọn cháu nhận được một thông điệp để mở cổng mà chả hiểu gì cả.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Một thông điệp ư? Vậy thông điệp đó như thế nào vậy?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hum... Hình như là để trở nên xứng đáng khi và chỉ khi người đó có thể phá giải hai thái cực đối lập và mang về sự bình yên.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hum... Ta cũng chẳng hiểu nốt luôn haha!";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thiệt tình, cha toàn cười trên nỗi đau của người khác.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Ta không hiểu thật mà, nghĩ lại thì cảm giác lời nhắn ấy gửi gắm ta phải làm điều gì ấy liên quan đến giải quyết mâu thuẫn.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Làm ta nhớ đến cha của cháu và bạn của ông ta đấy Vayne.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Bạn của ba cháu? Lúc ba cháu đi thì ông ấy chỉ có một mình. Chẳng lẻ nào ông ấy đã kết bạn trên đường đi đến đây.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Có vẻ thế, ta nhớ rõ là ông ấy có một người đàn tóc dài luôn đi theo làm nhiệm cụ cùng cha cháu khi ghé qua ngôi làng này. Có vẻ cả hai đều có cùng mục đích là ngôi đền Zexel.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Lúc ấy hai người đó lúc nào cũng cãi nhau, không ai chịu nhường ai.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Này Mr. Lance, chú có thông tin gì về người đàn ông đó không?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Chú e rằng là không, gã đó không hề khai thông tin cụ thể chỉ có cha của cháu là người khai. Nhưng nhớ không lầm tên của gã đó là Zane thì phải.";
            }
            else if (tang == 15)
            {
                MrLanceVAL1.SetActive(false);
                OrinaVAL1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Thú vị đó nhỉ? Mấy nhóc đã tìm được cánh cổng Zexel rồi ư?";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đúng thế bọn em đã tìm thấy cánh cổng nhưng mà...";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "Nhưng mà không mở được chứ gì?";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Đúng thế. Mà khoan chị Orina, chị qua đây làm gì thế?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "À, tôi qua đây đưa một số thực phẩm cho Mr. Lance này đây.";
            }
            else if (tang == 20)
            {
                VayneVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Phiền cô rồi Orina, cô có thể để tạm trên bàn là được rồi.";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Vayne này! Muốn biết cách mở cánh cổng không? Hãy qua chỗ tôi đi, tôi có thể giúp được đấy.";
            }
            else if (tang == 22)
            {
                MrLanceVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật ư? Nếu vậy thì cảm ơn chị trước!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Orina";
                dia.text = "Uhm! Hẹn gặp lại.";
            }
            else if (tang == 24)
            {
                OrinaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mình có cảm giác không lành về chuyện này.";
            }
            else if (tang == 25)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị cũng thế! Làm sao chị ta biết được cách mở cổng khi chưa đến đó bao giờ chứ?";
            }
            else if (tang == 26)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cho dù thế miễn cánh cổng mở được thì vấn đề đã được giải quyết rồi, nào chúng ta đi qua chỗ Orina thôi!";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus42 = 1;
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
        CutscenesController.cus42 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}