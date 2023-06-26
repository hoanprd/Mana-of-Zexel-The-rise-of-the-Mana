using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus66 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ShanVAL1, AlasaVAR1;
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
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "They have arrived, village chief!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "So these are the people you reported to me! Only three people?";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hello! We are people from far away lands. I am an alchemist named Vayne, the other two are Alia and Maria.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "???";
                dia.text = "The girl in the coat must be from Zexel town right?";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Yes that's right!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "???";
                dia.text = "It's been a long time since someone from Zexel town came over here, not even daring to come over.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alasa";
                dia.text = "My name is Alasa, village chief in inferno ice. I've heard reports from Shan about the reason you came here.";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... If so, you already know everything... if so...";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Are you worried that I will send you back?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alasa";
                dia.text = "Don't worry, I am much more generous than my brother Asila.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is the village chief at the inferno volcano your brother?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "That's right!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Will the village chief intend to help us?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alasa";
                dia.text = "Of course I will help you! Just like you, you need ice cores in this land, right?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's true, but doing so your village...";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alasa";
                dia.text = "Don't worry, I have a solution to help you get both cores.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Really? If so, thank you!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alasa";
                dia.text = "But I need you guys to do some things for me first.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "So tell me what it is?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alasa";
                dia.text = "First help me kill the ice wolves east of inferno ice, they live in packs so be careful as they are very crowded.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "We got it.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Alasa";
                dia.text = "Shan! Take care of those three people for me, and I'm a little busy right now, when you're done, come back and report back to me.";
            }
            else if (tang == 24)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "I understand, village chief.";
            }
            else if (tang == 25)
            {
                ShanVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Doesn't this village chief appear to be more aggressive than the village chief in the inferno volcano?";
            }
            else if (tang == 26)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Looks like it! But she had a feeling she couldn't trust him somehow.";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus66 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                ShanVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Họ đã tới rồi thưa trưởng làng!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Vậy đây là những người mà ngươi đã báo cáo cho ta đó sao! Chỉ có ba người thôi ư.";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Xin chào! Chúng tôi là những người ở vùng đất xa đến. Tôi là một nhà giả kim thuật tên Vayne, hai người còn lại là Alia và Maria.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "???";
                dia.text = "Đứa gái mặc áo khoác kia chắc đến từ thị trấn Zexel đúng không?";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Vâng đúng thế!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "???";
                dia.text = "Cũng đã lâu rồi mới có người ở thị trấn Zexel qua đây, thậm chí là không dám qua.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alasa";
                dia.text = "Tên là Alasa, trưởng làng ở inferno ice. Ta đã nghe báo cáo từ Shan lý do mà các người đến đây rồi.";
            }
            else if (tang == 8)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Nếu vậy thì ngài đã biết tất cả rồi... nếu vậy...";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Các người lo là ta sẽ đuổi các người về chứ gì?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đừng lo, ta đây rộng lượng hơn anh trai ta là Asila nhiều.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trưởng làng ở inferno volcano là anh trai của ngài sao?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đúng thế!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Trưởng làng sẽ có ý định giúp chúng tôi ư?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alasa";
                dia.text = "Tất nhiên là ta sẽ giúp các ngươi rồi! Cũng như các người cũng cần lõi năng lượng băng ở vùng đất này đúng không?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng là vậy thật, nhưng làm vậy ngôi làng của ngài...";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đừng lo, ta có cách để giải giúp các người lấy được cả hai lõi năng lượng.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật vậy ư? Nếu vậy thì cảm ơn ngài!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Alasa";
                dia.text = "Tuy nhiên ta cần mấy người làm một số chuyện cho ta đã.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy xin thưa chuyện đó là chuyện gì?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Alasa";
                dia.text = "Đầu tiên hãy giúp ta tiêu diệt mấy con sói băng ở phía đông inferno ice, bọn chúng sống theo bầy đàn nên hãy cẩn thận vì chúng rất đông.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi đã hiểu.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Alasa";
                dia.text = "Shan! Hãy trông chừng ba người đó cho ta, còn ta bây giờ bận một chút việc khi nào xong hãy quay về báo cáo lại cho ta.";
            }
            else if (tang == 24)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Tôi đã hiểu thưa trưởng làng.";
            }
            else if (tang == 25)
            {
                ShanVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có vẻ trưởng làng này không hung dữ hơn ông trưởng làng ở inferno volcano nhỉ?";
            }
            else if (tang == 26)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ thế! Nhưng chị có cảm giác không được tin tưởng ông ta kiểu gì ấy.";
            }
            else if (tang >= 27)
            {
                CutscenesController.cus66 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus66 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}