using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus111 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ShanVAL1, AsilaVAL1, AlasaVAR1, ZaneVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That monster, you've already lost, don't ever destroy other people's villages, okay?";
            }
            else if (tang == 2)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Inferno beast";
                dia.text = "grhhh...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It's unconscious.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Looks like that thing knows what's out of the question. Maybe it's just resentful that it's been sealed here for so long.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "I thank you guys, once again you saved my brothers and sisters.";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "I really don't know how to repay you guys?";
            }
            else if (tang == 7)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We don't need to repay the favor, what we do is voluntary.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alasa";
                dia.text = "Don't be a guest, I will give you this money first as the sincerity of the two of us. Please accept it.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe... it's a waste not to accept it.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Zen +1000";
            }
            else if (tang == 11)
            {
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "You guys are much stronger than before. Unbelievable.";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We are ready to raise our strength to fight the magician Zane.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Shan";
                dia.text = "Have you met him already?";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, it was difficult to fight him at first but now we will defeat him and stop evil plots.";
            }
            else if (tang == 15)
            {
                ShanVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Blinkkkkkk...";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That monster is gone, what happened?";
            }
            else if (tang == 17)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Hahaha, looks like you've become stronger than before. It seem the girl who was severely injured by me has already recovered.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Zane! What are you doing here?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Zane";
                dia.text = "Just visiting this inferno monster for a bit, thanks to you guys defeating me I can easily absorb it.";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "You bastard! What is your goal after all?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Zane";
                dia.text = "Oh, you're the kid who wants revenge on your parents, isn't it? I'm just helping you do it.";
            }
            else if (tang == 22)
            {
                ShanVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Stop joking around Zane, we don't have time to listen to your jokes like that.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha, you still haven't experienced what my nightmare is like. When everyone in this world hates you.";
            }
            else if (tang == 24)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "What do you mean?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zane";
                dia.text = "A time when magicians were hated and hunted to death. I'm one of the lucky ones to be alive, so I'm just giving back to this world my pain.";
            }
            else if (tang == 26)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's pointless, that era is over, what's the point of holding a grudge in your heart?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Zane";
                dia.text = "You ask yourself Vayne, do you hold a grudge against me?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "... I...";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Zane";
                dia.text = "Anyway, the conversation was interesting. I should just get back to my work.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Blinkkkkkkk...";
            }
            else if (tang == 31)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We're not going to leave him alone in this.";
            }
            else if (tang == 32)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Definitely give him a lesson.";
            }
            else if (tang == 33)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "Sir Asila! Everyone has been moved to a safe location, we're here to help you fight monsters!";
            }
            else if (tang == 34)
            {
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Oh, thanks everyone, but the monster is done.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Really! Did you two deal with it?";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Asila";
                dia.text = "Actually, this group of adventurers defeated that monster.";
            }
            else if (tang == 37)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "The three of you are our benefactors!";
            }
            else if (tang == 38)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's okay, consider us a reliable ally.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Asila";
                dia.text = "How's the damage done?";
            }
            else if (tang == 40)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "Well, the situation in our village has a few houses damaged, it will be difficult to fix because of the ancient raw materials we have to import from outside...";
            }
            else if (tang == 41)
            {
                NameTagText.text = "Asila";
                dia.text = "That's hard.";
            }
            else if (tang == 42)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "If we open the border to the outside from now on, it will take time to get used to the new lifestyle.";
            }
            else if (tang == 43)
            {
                NameTagText.text = "Asila";
                dia.text = "But who's the internal damage we haven't solved yet. Unless...";
            }
            else if (tang == 44)
            {
                NameTagText.text = "Asila";
                dia.text = "Vayne, it seems a bit selfish but...";
            }
            else if (tang == 45)
            {
                AlasaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You don't have to be afraid Vayne will help you.";
            }
            else if (tang == 46)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Huh? I mean can help what I can.";
            }
            else if (tang == 47)
            {
                NameTagText.text = "Asila";
                dia.text = "You just need to help the villagers deal with the damage from the inferno beast attack just now. That will help us a lot while we will start to open the border to the outside. Think of it as dividing the work to treat.";
            }
            else if (tang == 48)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's up Vayne? We can make friends with these two villages with our help.";
            }
            else if (tang == 49)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's fine, I'll use alchemy to help everyone.";
            }
            else if (tang == 50)
            {
                NameTagText.text = "Asila";
                dia.text = "Thank you, Mr. Vayne, you are indeed our benefactor. If anything, please visit the villagers to ask about the situation comfortably!";
            }
            else if (tang == 51)
            {
                VayneVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "I think I will need you to help my villagers too Vayne, thank you very much indeed.";
            }
            else if (tang == 52)
            {
                AlasaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Everyone please be optimistic and believe, I will do my best for everyone.";
            }
            else if (tang >= 53)
            {
                CutscenesController.cus111 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Con quái vật kia, ngươi đã thua rồi đừng bao giờ phá làng phá xóm người khác được chứ?";
            }
            else if (tang == 2)
            {
                AliaVAL1.SetActive(false);
                NameTagText.text = "Inferno beast";
                dia.text = "grhhh...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nó gục rồi.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ nó biết điều không đụng chạm đến đây nữa đâu. Có lẽ nó chỉ bực tức vì bị phong ấn ở đây lâu thôi.";
            }
            else if (tang == 5)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ta cảm ơn mấy đứa, một lần nữa mấy đứa lại cứu hai anh em ta nữa rồi.";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Ta thực sự không biết trả ơn mấy đứa như nào đây?";
            }
            else if (tang == 7)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Bọn cháu không cần trả ơn đâu, những gì bọn cháu làm là tự nguyện hết.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alasa";
                dia.text = "Thôi đừng khách sao, ta cho mấy đứa số tiền này trước coi như tấm lòng thành của hai anh em ta. Xin hãy nhận nó.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe... đúng là không nhận thì uổng quá.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Zen +1000";
            }
            else if (tang == 11)
            {
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Các cậu đã mạnh hơn trước rất nhiều. Thật không thể tin nổi.";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bọn tớ đã chuẩn bị sẵn sàng nâng cao sức mạnh bản thân để chiến đấu với tên ma pháp sư Zane rồi.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Shan";
                dia.text = "Các cậu đã gặp hắn rồi ư?";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, ban đầu đúng là khó khăn khi đấu với hắn nhưng giờ đã khác bọn ta sẽ hạ hắn và ngăn chặn các âm mưu xấu xa.";
            }
            else if (tang == 15)
            {
                ShanVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Blinkkkkkk...";
            }
            else if (tang == 16)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Con quái vật đó đã biến mất, đã xảy ra chuyện gì?";
            }
            else if (tang == 17)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Hahaha, có vẻ các người đã trở nên mạnh hơn trước rồi. Cũng như con nhỏ bị ta đánh cho trọng thương đã hồi phục rồi.";
            }
            else if (tang == 18)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Zane! Ngươi tính làm gì ở đây?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Zane";
                dia.text = "Chỉ là ghé thăm con quái vật inferno này một tý, nhờ các ngươi đã đánh bại ta có thể dễ dàng hấp thụ nó.";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Tên khốn nhà ngươi! Rốt cuộc mục đích của ngươi là gì?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Zane";
                dia.text = "Ồ, ngươi chính là thằng nhóc đòi trả thù mối hận cho ba mẹ ngươi đấy à? Ta chỉ giúp ngươi thực hiện nó thôi mà.";
            }
            else if (tang == 22)
            {
                ShanVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đừng giỡn mặt nữa Zane, bọn ta không rảnh để nghe ngươi đùa như thế đâu.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zane";
                dia.text = "Hahaha, các ngươi vẫn chưa trải nghiệm ác mộng của ta là như thế nào. Khi mà mọi người trên thế giới này ghét bỏ ngươi.";
            }
            else if (tang == 24)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ý ngươi là sao?";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zane";
                dia.text = "Thời kỳ mà các ma pháp sư bị ghét bỏ và bị săn lùng cho đến chết. Ta là một trong những kẻ may mắn được sống sót, thế nên ta chỉ trả lại cho thế giới này nỗi đau của ta mà thôi.";
            }
            else if (tang == 26)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật vô nghĩa, thời đại đó đã qua rồi, ngươi giữ thù hận trong lòng cũng có ý nghĩa gì?";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Zane";
                dia.text = "Ngươi tự hỏi bản thân của ngươi đi Vayne, ngươi có thù hận ta chứ?";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Ta...";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Zane";
                dia.text = "Dù sao cuộc trò chuyện cũng thú vị đó. Ta nên quay lại công việc của ta thôi.";
            }
            else if (tang == 30)
            {
                VayneVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Blinkkkkkkk...";
            }
            else if (tang == 31)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta sẽ không để hắn yên trong chuyện này đâu.";
            }
            else if (tang == 32)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nhất định phải cho hắn một bài học.";
            }
            else if (tang == 33)
            {
                MariaVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "Ngài Asila! Mọi người đã được di dời tới vị trí an toàn rồi, chúng tôi đến hỗ trợ ngài chiến đấu quái vật đây!";
            }
            else if (tang == 34)
            {
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ồ, cảm ơn mọi người nhưng con quái vật đã được giải quyết xong rồi.";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Thật vậy ư! Hai ngài đã giải quyết ư?";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Asila";
                dia.text = "Thực ra là nhóm nhà mạo hiểm này đã tiêu diệt con quái vật ấy.";
            }
            else if (tang == 37)
            {
                NameTagText.text = "Villager (Man)";
                dia.text = "Ba cô cậu chính là ân nhân của chúng tôi rồi!";
            }
            else if (tang == 38)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không có gì, hãy coi chúng tôi là đồng minh đáng tin cậy là được.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Asila";
                dia.text = "Tình hình thiệt hại như thế nào rồi?";
            }
            else if (tang == 40)
            {
                VayneVAR1.SetActive(false);
                NameTagText.text = "Villager (Man)";
                dia.text = "À vâng, tình hình ngôi làng chúng ta bị thiệt hại vài ngôi nhà, để khắc phục sẽ rất khó vì nguồn nguyên liệu từ xưa chúng ta phải nhập từ bên ngoài...";
            }
            else if (tang == 41)
            {
                NameTagText.text = "Asila";
                dia.text = "Như vậy thì khó thật.";
            }
            else if (tang == 42)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Nếu chúng ta mở cửa khẩu với bên ngoài từ bây giờ sẽ mất thời gian để làm quen với lối sống mới.";
            }
            else if (tang == 43)
            {
                NameTagText.text = "Asila";
                dia.text = "Nhưng ai thiệt hại nội bộ chúng ta vẫn chưa giải quyết xong. Trừ khi...";
            }
            else if (tang == 44)
            {
                NameTagText.text = "Asila";
                dia.text = "Vayne, có vẻ hơi ích kỷ nhưng...";
            }
            else if (tang == 45)
            {
                AlasaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hai ngài không cần phải ngại Vayne sẽ giúp các ngài thôi.";
            }
            else if (tang == 46)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hể? Ý tôi là có thể giúp được những gì mà tôi có thể giúp.";
            }
            else if (tang == 47)
            {
                NameTagText.text = "Asila";
                dia.text = "Cậu chỉ cần giúp dân làng giải quyết thiệt hại nội từ cuộc tấn công inferno beast vừa rồi là được. Đó sẽ giúp chúng tôi rất nhiều trong khi chúng tôi sẽ bắt đầu mở cửa khẩu với bên ngoài. Coi như chia công việc ra để trị.";
            }
            else if (tang == 48)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Sao nào Vayne? Chúng ta có kết thân với 2 ngôi làng này nếu được sự giúp đỡ của chúng ta.";
            }
            else if (tang == 49)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy cũng được, tôi sẽ dùng giả kim thuật để giúp mọi người.";
            }
            else if (tang == 50)
            {
                NameTagText.text = "Asila";
                dia.text = "Cảm ơn cậu Vayne, cậu đúng là ân nhân của chúng tôi rồi đấy, có gì cậu hãy ghé thăm dân làng để hỏi thăm tình hình thoải mái nhé!";
            }
            else if (tang == 51)
            {
                VayneVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Tôi nghĩ sẽ cần cậu giúp cho dân làng tôi nữa Vayne, thật sự cảm ơn rất nhiều.";
            }
            else if (tang == 52)
            {
                AlasaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mọi người hãy lạc quan và tin tưởng, tôi sẽ cố hết sức vì mọi người.";
            }
            else if (tang >= 53)
            {
                CutscenesController.cus111 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Alta inferno");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus111 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Alta inferno");
    }
}