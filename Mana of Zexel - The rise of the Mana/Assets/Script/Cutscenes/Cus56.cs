using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus56 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, MariaVAL1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Do you want to take a break, Vayne?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hmm...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne? Do you feel good?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oh, it's nothing! I was just thinking about how to quickly restore mana in my body for making alchemy items.";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I never thought about recovering quickly.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that mana land, I see you can use the amount of mana spreading around to restore the body.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "But our bodies can't take in direct energy quickly. It also took an entire day to absorb enough mana there.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Don't worry I just came up with a way to quickly absorb mana through something indirect.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "... I can't think of that.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "I think just create a machine that can absorb and transfer mana to the human body. Like transmitter and receiver.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "What do you mean by absorbing mana at the mana gate and using the absorbed energy to transfer it to your body quickly?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right! But it will take a lot of effort to build that machine.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Even though I don't understand anything, Vayne must have come up with something great.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Actually, it's not that big of a deal, I just want a quick mana recovery to make powerful alchemy items because they will consume a lot of my mana.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "If so, are you forcing yourself to become more pressured.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's okay, this will train myself to be stronger as well as maybe everyone including you.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "Hihi, it warms my heart to hear you say that!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Well... Well, I'll finish the machine to continue the main work.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus56 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cậu có muốn nghỉ ngơi tý không Vayne?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hừm...";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne? Cậu sao thế?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oh, à không có gì! Chỉ là tớ đang suy nghĩ tìm cách phục hồi mana trong cơ thể một cách nhanh chóng cho việc chế tạo các vật phẩm giả kim.";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị chưa từng nghĩ đến việc phục hồi nhanh hết cả.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ở vùng đất mana kia em thấy ta có thể vận dụng được lượng mana đang lan tỏ xung quanh để phục hồi cho cơ thể.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Nhưng mà cơ thể chúng ta không thể tiếp nhận nguồn năng lượng trực tiếp một cách nhanh chóng được. Cũng như cũng mất cả buổi để hấp thụ đủ lượng mana ở đó.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đừng lo em vừa nghĩ ra có cách để hấp thụ mana nhanh qua một thứ gián tiếp.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "... Chị không thể nghĩ ra ấy.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em nghĩ chỉ cần tạo một cỗ máy có thể hấp thụ và truyền mana cho cơ thể con người. Giống như máy phát và thu vậy.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Ý em sẽ hấp thụ mana ở mana gate và dùng năng lượng hấp thụ được để truyền vào cơ thể con một cách nhanh chóng?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế! Những em sẽ tốn rất nhiều sức để chế tạo cỗ máy đó.";
            }
            else if (tang == 13)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Dù mình không hiểu gì nhưng chắc Vayne đã đưa ra ý tưởng gì đó tuyệt vời.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thực ra cũng không gì to tác đâu chẳng qua tớ muốn việc phục hồi mana nhanh để chế tạo các món giả kim mạnh mẽ vì chúng sẽ tiêu hao mana của tớ rất nhiều.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "Nếu vậy cậu đang ép bản thân trở nên áp lực hơn sao.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không sao, việc này sẽ rèn luyện bản thân tớ trở nên mạnh mẽ hơn cũng như có thể mọi người kể cả cậu.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Alia";
                dia.text = "Hihi, nghe cậu nói tớ cảm thấy ấm lòng thiệt!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "À... Thôi tớ sẽ làm hoàn thành cỗ máy để tiếp tục công việc chính thôi.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus56 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus56 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}