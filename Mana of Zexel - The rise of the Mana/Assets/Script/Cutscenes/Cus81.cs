using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus81 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ManaWaterVAL1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "We've gone through most of this forest and still nothing...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Looks like the legend is just a rumor. It seems that reviving the land for the two village chiefs seems to be difficult.";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... This place...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Does Maria have something to worry about?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "... It's just that I find it a bit bleak here.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Looking back, we rarely go to this place, right?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I feel very comfortable for a place to stay. Not only that, there are no monsters here, so there's nothing to worry about.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "In the past, my mother used to take me to this place on weekends just to enjoy the fresh air of nature. It's a memory, isn't it?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Don't tell me you want to stay in this forest because it contains a lot of your mother's memories?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right, hahaha, it's fun to think back on, the moments when I went to pick medicine with my mother that day were great.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "What should we do... the situation is really confusing right now.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Hmm, ... you guys are quite noisy!";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Huh? Just now... is there anyone around here?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "???";
                dia.text = "Looks like I have an uninvited guest.";
            }
            else if (tang == 15)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What's under the water?";
            }
            else if (tang == 16)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Fate seems inevitable, doesn't it?";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This person looks similar to the mana gods we meet.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "???";
                dia.text = "Mana god? So you went to meet the mana god?";
            }
            else if (tang == 19)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Who are you? Why did he appear at the lake like this?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Mana water";
                dia.text = "Alright! Looks like you're not a bad person, my hunch tells me so. I am mana water, a mana that lived in the lake long ago.";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Could it be that you are the mana mentioned in the purifying water legend?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mana water";
                dia.text = "Hmm, that's been a while, hasn't it? Since the war with the magicians ended. Yes, I am the creator and guardian of this lake of purification.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "It's strange, how come the people who frequent here like me have never met you mana water?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mana water";
                dia.text = "You don't know me but I know you every time I pass by the lake, it's just that I don't want to show up, like I said before we met by fate.";
            }
            else if (tang == 25)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Fate again? Mana god told us the same!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Mana water";
                dia.text = "Unfortunately I'm not exactly a mana god, just a mana living in a remote place.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Mana water";
                dia.text = "All I know is that you will visit this place and it is my duty to answer your questions.";
            }
            else if (tang == 28)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "How did you know these things would happen?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Mana water";
                dia.text = "It's best not to talk about it because it's very complicated. Just as I know you will aim for this lake of purification!";
            }
            else if (tang == 30)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Then we won't have to explain at length as well as can you help us about the water of purification?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Mana water";
                dia.text = "Hahaha, this is naive, do you think you can get whatever you want after meeting me?";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Mana water";
                dia.text = "Purifying water is an extremely difficult result and takes time to prepare. I always keep it with me just in case. Therefore, we will need a request to exchange.";
            }
            else if (tang == 33)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "And what is that request?";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Mana water";
                dia.text = "Simple alchemist, I need you guys to give me a special medicine for my backache.";
            }
            else if (tang == 35)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Huh? Are you serious?";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Mana water";
                dia.text = "Purifying water can't cure diseases, you should know that, just like I'm old because I'm not a mana god so my lifespan is limited.";
            }
            else if (tang == 37)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You know I'm an alchemist? How could it...";
            }
            else if (tang == 38)
            {
                NameTagText.text = "Mana water";
                dia.text = "I told you it would be complicated and it's unnecessary to tell you about it, young man!";
            }
            else if (tang == 39)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, we should focus on the main issue. We really need cleansing water, don't we?";
            }
            else if (tang == 40)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Okay in that case we'll give you the best back pain medicine I've ever made. But you must keep your promise to exchange purifying water with us.";
            }
            else if (tang == 41)
            {
                NameTagText.text = "Mana water";
                dia.text = "Of course. You cannot lie to fate.";
            }
            else if (tang == 42)
            {
                ManaWaterVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Haizz, it's fate that these mana are so fond of mysterious puzzles.";
            }
            else if (tang >= 43)
            {
                CutscenesController.cus81 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chúng ta đã đi gần hết khu rừng này rồi mà vẫn không có gì...";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ là truyền thuyết cũng chỉ là tin đồn qua loa thôi. Có vẻ việc hồi sinh mảnh đất cho hai trưởng làng có vẻ sẽ khó đây.";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Nơi này...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Chị Maria có chuyện gì đáng bận tâm sao?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "... Chỉ là chị thấy hơi ảm đạm ở chỗ này.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nhìn lại thì chỗ này chúng ta ít khi đến nhỉ?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tớ cảm thấy rất dễ chịu cho một nơi nghỉ chân đấy. Không chỉ thế nơi đây không có quái vật nên cũng chẳng phải lo lắng gì cả.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Hồi trước mẹ chị cũng hay dẫn chị ra chỗ này vào cuối tuần chỉ để hóng không khí trong lành của thiên nhiên. Thật là kỷ niệm nhỉ?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đừng nói là chị muốn ở khu rừng này vì nơi đây chứa nhiều kỷ niệm của mẹ chị ư?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế, hahaha, nghĩ lại thì rất vui, những khoảng khắc đi hái thuốc với mẹ của chị ngày ấy rất tuyệt vời.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta nên làm gì đây nhỉ... tình hình giờ thực sự khá bí tắc.";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Hừm, ... bọn người các ngươi khá ồn ào đấy!";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hể? Vừa rồi... có tiếng ai ở quanh đây à?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "???";
                dia.text = "Có vẻ như ta có khách không mời mà đến.";
            }
            else if (tang == 15)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có thứ gì dưới mặt nước hồ?";
            }
            else if (tang == 16)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                VayneVAL1.SetActive(false);
                ManaWaterVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Định mệnh có vẻ là thứ khó tránh khỏi nhỉ?";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Người này có vẻ trông giống với các mana god mà chúng ta gặp.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "???";
                dia.text = "Mana god? Vậy các người đã đi gặp mana god rồi sao?";
            }
            else if (tang == 19)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ông là ai? Tại sao ông lại xuất hiện ở mặt hồ như thế này?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Mana water";
                dia.text = "Được thôi! Có vẻ các người không phải người xấu, linh cảm mắc bảo ta như thế. Ta là mana water, một mana đã sinh sống ở hồ nước rất lâu về trước.";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Không lẽ nào ông là mana được nhắc trong truyền thuyết nước thanh tẩy?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Mana water";
                dia.text = "Hừm, chuyện đó cũng khá lâu rồi nhỉ? Kể từ khi cuộc chiến với các ma pháp sư kết thúc. Đúng thế ta chính là người tạo ra và canh giữ hồ nước thanh tẩy này đây.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "Thật kỳ lạ, tại sao những dân hay qua lại nơi đây cũng như tôi lại chưa từng gặp ông bao giờ thế mana water?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Mana water";
                dia.text = "Các người không biết ta nhưng ta biết các người mỗi khi ghé qua hồ nước đấy, chẳng qua là ta không muốn lộ diện, như ta đã nói trước đó chúng ta gặp nhau là do định mệnh.";
            }
            else if (tang == 25)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Lại định mệnh nữa sao? Mana god cũng nói với chúng tôi như thế!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Mana water";
                dia.text = "Tiếc là ta không hẳn là một mana god chỉ là một mana sống ở một nơi hẻo lánh thôi.";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Mana water";
                dia.text = "Những gì ta biết là các người sẽ ghé thăm chỗ này và ta có nhiệm vụ giải đáp thắc mắc của mấy người.";
            }
            else if (tang == 28)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Sao ông lại biết những điều này sẽ xảy ra?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Mana water";
                dia.text = "Chuyện đó tốt nhất ta không nên nói ra vì nó rất phức tạp. Cũng như ta biết các người sẽ nhắm tới hồ nước thanh tẩy này!";
            }
            else if (tang == 30)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy thì chúng tôi đỡ phải giải thích dài dòng cũng như là ông có thể giúp chúng tôi về nước thanh tẩy?";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Mana water";
                dia.text = "Hahaha, thật là ngây thơ, mấy người nghĩ là muốn gì được nấy sau khi gặp ta à?";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Mana water";
                dia.text = "Nước thanh tẩy là thành quả vô cùng khó khăn cũng như là cần thời gian để điều chế. Ta luôn giữ nó bên mình để đề phòng trường hợp xảy ra. Chính vì thế ta sẽ cần có một yêu cầu để trao đổi.";
            }
            else if (tang == 33)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Và yêu cầu đó là gì thế?";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Mana water";
                dia.text = "Đơn giản thôi nhà giả kim, ta cần mấy người đưa cho ta loại thuốc trị đau lưng thật đặc biệt.";
            }
            else if (tang == 35)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hể? Ông nghiêm túc đó chứ?";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Mana water";
                dia.text = "Nước thanh tẩy không thể chữa bệnh được, các người nên biết điều đó, cũng như ta đã già rồi vì không phải mana god nên tuổi thọ của ta có hạn.";
            }
            else if (tang == 37)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ông biết tôi là nhà giả kim ư? Làm sao mà...";
            }
            else if (tang == 38)
            {
                NameTagText.text = "Mana water";
                dia.text = "Ta bảo rồi sẽ rất phức tạp cũng như là không cần thiết cho cậu biết vấn đề đó chàng trai trẻ ạ!";
            }
            else if (tang == 39)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, chúng ta nên tập trung vào vấn đề chính thôi. Chúng ta thật sự cần nước thanh tẩy mà đúng không?";
            }
            else if (tang == 40)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Được thôi nếu vậy chúng tôi sẽ đưa cho ông loại thuốc đau lưng tốt nhất mà tôi từng tạo ra. Nhưng ông phải giữ lời hứa trao đổi nước thanh tẩy với chúng tôi đấy.";
            }
            else if (tang == 41)
            {
                NameTagText.text = "Mana water";
                dia.text = "Đương nhiên rồi. Ta không thể nói dối trước định mệnh được.";
            }
            else if (tang == 42)
            {
                ManaWaterVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Haizz, lại định mệnh rốt cuộc sao những mana này thích đánh đố kỳ bí thế.";
            }
            else if (tang >= 43)
            {
                CutscenesController.cus81 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
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
        CutscenesController.cus81 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}