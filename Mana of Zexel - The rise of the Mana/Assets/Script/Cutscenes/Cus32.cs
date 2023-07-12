using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus32 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAL1, MariaVAR1, OrinaVAR1;
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
                dia.text = "Hello! Is any body here?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is the store empty?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Maybe the shop owner went out?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "If the shop owner goes out, they should leave the notice board and lock the door!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Boring! And looking around, isn't this a grocery store! The items here look so creepy!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Her shop is always like that, that's why a lot of people think she's eccentric!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Eccentric? Did you guys come here to speak ill of people?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ahhh... We're sorry, we were just curious!";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! We're just joking! Please... ignore!";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ehhhh... Is she the owner of the shop?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Orina";
                dia.text = "That's right! My name is Orina and I'm the owner of your eccentric grocery store!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "What are you guys doing here! I hope you guys don't come here to harass me!";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Actually, we heard that you know a lot of things like the history and places around this town! So...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "We wanted to ask you if you know anything about Zexel temple and how to get there!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "Temple of Zexel? Hmm... Okay then I know that!";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "If so, please help us!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "Huh? Help? Do you think that if you come to my shop and say bad things, I will help you guys? In your dream.";
            }
            else if (tang == 18)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We're really sorry! But please help us! Please!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Hmm! Really hate it! I thought it would be something cool instead of a bunch of people coming in just to make you mad! Okay, if you feel guilty, then atone for it!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "We're ready to redeem!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "Hey Vayne! Don't be so weak! If she asks for something impossible, it's no use!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "I know but without outside help we can hardly continue the journey! Anyway we are the ones to blame!";
            }
            else if (tang == 23)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Okay! If you don't mind, we are willing to listen to your request, Orina!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Then you can hear better! What we want is simple! Bring me some materials after Mana string, Iron and Wood. Each ingredient will need 5 of those!";
            }
            else if (tang == 25)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "No problem! But please keep your promise to help us!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Orina";
                dia.text = "Of course! I swear on my honor!";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus32 = 1;
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
                dia.text = "Xin chào! Có ai ở đây không?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cửa tiệm không có ai ư?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Chắc là chủ tiệm đã đi ra ngoài ư?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Nếu chủ tiệm ra ngoài thì phải để bảng thông báo cũng như là khóa cửa lại chứ!";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chán thật! Mà nhìn xung quanh thì đây có phải cửa hàng tạp hóa không thế! Các vật phẩm ở đây trông ghê rợn quá!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Cửa tiệm cô ta luôn vậy mà, đó là lý do nhiều người nghĩ cô ta là lập dị đấy!";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Hể lập dị ư? Bộ mấy người đến đây để nói xấu người ta hả?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ahhh... Chúng tôi xin lỗi, chẳng qua chúng tôi hơi tò mò thôi!";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! Chúng tôi chỉ đùa thôi! Mong cô... bỏ qua!";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Ehhhh... Cô ấy là chủ tiệm đấy ư?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Orina";
                dia.text = "Đúng thế! Ta tên là Orina là chủ tiệm cửa hàng tạp hóa lập dị của mấy người đây!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "Mấy người đến đây làm gì! Cầu mong mấy người đến đây không phải để quấy rối đấy nha!";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật ra thì chúng tôi nghe rằng cô biết rất nhiều thứ như lịch sử cũng như địa điểm xung quanh thị trấn này! Cho nên...";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi muốn hỏi cô rằng có biết gì về ngôi đền Zexel cũng như cách đến đó!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "Ngôi đền Zexel ư? Hừm... Được thôi mấy cái đó thì ta biết!";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nếu vậy thì phiền cô giúp đỡ ạ!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "Hể? Giúp đỡ? Các người nghĩ vô tiệm của tôi nói xấu thì tôi sẽ giúp mấy người ư? Mơ đi.";
            }
            else if (tang == 18)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi thật sự xin lỗi! Nhưng xin cô hãy giúp chúng tôi đi! Làm ơn!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Hừm! Thấy ghét thật! Tôi nghĩ rằng sẽ được cái gì đó hay ho thay vì một nhóm người đến chỉ khiến ta tức điên! Được thôi nếu các người cảm thấy có lỗi thì chuộc lỗi đi!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi sẵn sàng để chuộc lỗi!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "Này Vayne! Đừng có nhu nhược đến thế! Nếu cô ta yêu cầu mấy thứ bất khả thi thì vô ích thôi!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em biết nhưng nếu không có sự giúp đỡ bên ngoài chúng ta khó mà tiếp tục cuộc hành trình! Dù sao chúng ta là người có lỗi!";
            }
            else if (tang == 23)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Được thôi! Nếu không phiền thì chúng tôi sẵn sàng nghe theo yêu cầu của cô đấy Orina!";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Vậy thì nghe được hơn rồi đó! Những gì ta muốn đơn giản thôi! Hãy mang cho ta một số nguyên liệu sau Mana string, Iron và Wood. Mỗi nguyên liệu sẽ cần 5 cái đó!";
            }
            else if (tang == 25)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không vấn đề gì! Nhưng mong cô hãy giữ lời hứa sẽ giúp chúng tôi nhé!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Orina";
                dia.text = "Tất nhiên rồi! Ta xin thề dưới danh dự của Orina này!";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus32 = 1;
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
        CutscenesController.cus32 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}