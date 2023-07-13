using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus134 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAR1, MariaVAR1, ManaElfVAL1, ManaRockVAL1, ManaLightVAL1;
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
                ManaElfVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Thanks everyone for coming, maybe we don't have much time left.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Looks like this has something to do with the magician Zane.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mana elf";
                dia.text = "That's right, he's trying to break the seal of Sicxalon. If Sicxalon was released, once again everyone and humans and mana would be in danger.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Then we'll go to the temple and give him a lesson.";
            }
            else if (tang == 5)
            {
                ManaElfVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Wait young lady, we called you come to give this.";
            }
            else if (tang == 6)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "This is the key to unlock the secret that you all need to know is that girl Alia.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mana elf";
                dia.text = "This is also Zexel's last wish to wish everyone good luck.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Are you gods already know the end result of this war?";
            }
            else if (tang == 9)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Looks like it is, but we won't tell you in advance though.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... So all of this is well known to you?";
            }
            else if (tang == 11)
            {
                ManaRockVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "We have our own reasons for doing that. Please forgive us.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's just us and Zexel who are chosen to protect this peace?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Not really, before Zexel's generation there was another chosen one. However, that time has not yet come.";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You mean someone else got here before Zexel.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mana elf";
                dia.text = "That's right, that person was the first mortal to come into contact with the gods, the first alchemist of this world.";
            }
            else if (tang == 16)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "The world's first alchemít is nothing more than a myth. Does that person really exist?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Mana elf";
                dia.text = "History is only partially true, the rest only people of that era know the truth. However, your immediate task is to prevent Zane from resurrecting Sicxalon.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "We got it.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus134 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                ManaElfVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Cảm ơn mọi người đã đến, có lẽ như chúng ta không còn nhiều thời gian nữa.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ như chuyện này có liên quan đến tên ma pháp sư Zane.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Đúng là thế, hắn ta đang cố gắng phá phong ấn Sicxalon. Nếu Sicxalon được giải phóng, một lần nữa mọi người lẫn con người và mana sẽ gặp nguy hiểm.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy chúng tôi sẽ đến ngôi đền và cho hắn một bài học.";
            }
            else if (tang == 5)
            {
                ManaElfVAL1.SetActive(false);
                ManaLightVAL1.SetActive(true);
                NameTagText.text = "Mana light";
                dia.text = "Khoan đã cô gái trẻ, bọn ta kêu các người đến để đưa thứ này.";
            }
            else if (tang == 6)
            {
                ManaLightVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Đây chính là chìa khóa để mở khóa những bí mật mà các người cần biết nhất là cô gái Alia kia.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Đây cũng là di nguyện cuối cùng của Zexel đã để lại chúc mọi người may mắn.";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có phải các vị thần mấy người sẽ kết cục của cuộc chiến này phải không?";
            }
            else if (tang == 9)
            {
                ManaElfVAL1.SetActive(false);
                ManaRockVAL1.SetActive(true);
                NameTagText.text = "Mana rock";
                dia.text = "Có vẻ thế nhưng dù vậy bọn ta sẽ không cho biết trước đâu.";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Vậy là mọi chuyện này đều được mấy người nắm rõ hết ư?";
            }
            else if (tang == 11)
            {
                ManaRockVAL1.SetActive(false);
                ManaElfVAL1.SetActive(true);
                NameTagText.text = "Mana elf";
                dia.text = "Bọn ta có lý do riêng để làm vậy. Hãy thông cảm cho chúng ta.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chỉ có bọn tôi và Zexel là những người được chọn để bảo vệ sự hòa bình này ư?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Không hẳn thế, trước thế hệ của Zexel đã có một người được chọn khác. Tuy nhiên thời đại đó vẫn chưa đến.";
            }
            else if (tang == 14)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ý mấy người là có một người khác đã đến đây trước cả Zexel.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Đúng thế, người đó là người phàm trần đầu tiên tiếp xúc với các vị thần, nhà giả kim đầu tiên của thế giới này.";
            }
            else if (tang == 16)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nhà giả kim đầu tiên của thế giới chẳng lẻ chỉ là một thần thoại thôi mà. Người đó thật sự tồn tại sao.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Mana elf";
                dia.text = "Lịch sử chỉ đúng một phần, phần còn lại chỉ có người ở thời đại đó mới biết được sự thật. Tuy nhiên nhiệm vụ trước mắt của mấy người phải ngăn chặn Zane hồi sinh lại Sicxalon.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bọn tôi đã hiểu.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus134 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana temple");
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
        CutscenesController.cus134 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}