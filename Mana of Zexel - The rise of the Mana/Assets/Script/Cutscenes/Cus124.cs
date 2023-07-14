using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus124 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, ManaDetecBroken;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Finally back in this house!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I think you've only been adventuring with us for less than a month, but you already miss your old home.";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Come on, stop teasing each other. We have to find the mana detector as soon as posible.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Honestly, it will take a bit of time because I often leave things in the house so it will take time to find them.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Oh my god... okay let us help you find it.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Don't touch my sensitive things.";
            }
            else if (tang == 7)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 8)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Admittedly, Maria's room is full of books.";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I find it very messy.";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Where is it? Do you remember where it is...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "What is this? Diary of...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Hey don't touch my private stuff!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "I'm sorry, I'm just curious!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Phew... That diary is really important to me so I have to keep it safe.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "Are these your memories with your mother?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Yes, I and my mother lived a simple life in this forest. The mana detector was a product that I created to find ingredients for my mother's potions as well as for alchemy.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = "Even though I'm not a doctor like my mother, I've tried my best in being helpful to everyone I know.";
            }
            else if (tang == 18)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                ManaDetecBroken.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hey Maria, is this round device?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "That's right, that's it!";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It looks very old.";
            }
            else if (tang == 21)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I think it doesn't work anymore.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "It seems so, can't blame the device for being old.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Interesting isn't it? I didn't expect you to be able to make such a useful item since I was a child when I only know how to make potions.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anyway, I think this device can be repaired. Let's go get the cauldron and fix it with your alchemy.";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus124 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cuối cùng cũng được quay trở về lại ngôi nhà này!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Em nghĩ chị chỉ cùng tụi em phiêu lưu chưa đến một tháng mà đã nhớ nhà cũ rồi.";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thôi nào đừng châm chọc nhau nữa chúng ta phải tìm thiết bị dò tìm mana càng sớm càng tốt.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Thiệt thì sẽ hơi mất thời gian vì đồ dùng trong nhà này chị thường hay để lung tung nên sẽ mất thời gian tìm kiếm đây.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Thiệt hả trời... được rồi để bọn em tìm kiếm giúp chị.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Đừng động vào những thứ nhạy cảm của chị là được.";
            }
            else if (tang == 7)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 8)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận phòng chị Maria nhiều sách thật.";
            }
            else if (tang == 9)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tớ thì thấy rất lộn xộn nữa.";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đâu rồi nhỉ? Chị nhớ nó đâu đây mà...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Gì đây nhỉ? Nhật ký của...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Maria";
                dia.text = "Này đừng có động vào mấy thứ riêng tư của chị chứ!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Em xin lỗi, em chỉ hơi tò mò thôi!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Phù... Cuốn nhật ký đó thực sự rất quan trọng với chị nên chị phải cất nó thật kỹ càng.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "Có phải đây là những ký ức của chị với mẹ của chị đúng không?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng thế, chị và mẹ chị đã sống một cuộc sống giản dị ở khu rừng này. Thiết bị dò tìm mana là một sản phẩm mà chị tạo ra để tìm nguyên liệu cho việc làm thuốc của mẹ chị cũng như cho giả kim thuật nữa.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = " Dù chị không phải là một bác sĩ như mẹ chị nhưng chị đã cố gắng hết sức trong việc tỏ ra mình hữu ích cho mọi người mà chị biết.";
            }
            else if (tang == 18)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                ManaDetecBroken.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này chị Maria, có phải cái thiết bị tròn tròn như này à?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng rồi đấy, chính là nó!";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Trông nó có vẻ rất cũ rồi.";
            }
            else if (tang == 21)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em nghĩ nó không còn hoạt động nữa.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Maria";
                dia.text = "Có vẻ thế, cũng không thể trách được thiết bị này đã cũ rồi.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thú vị nhỉ? Em không ngờ chị có thể tạo một món đồ hữu ích này từ khi còn nhỏ trong khi đó em chỉ biết chế tạo thuốc thôi.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mà dù sao thì em nghĩ có thể sửa chữa được thiết bị này. Nào hãy đi kiếm cái vạc và sửa chữa nó bằng giả kim thuật của em nào.";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus124 = 1;
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
        CutscenesController.cus124 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}