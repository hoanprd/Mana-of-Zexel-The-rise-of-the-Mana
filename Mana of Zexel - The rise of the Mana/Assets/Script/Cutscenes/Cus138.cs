using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus138 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "You guys are a lot stronger than last time, aren't you? You're surprised.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Of course! You think we'll come here unprepared?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Zane";
                dia.text = "That doesn't matter either...";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane! I want to ask you one more question?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zane";
                dia.text = "Say it brat.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "What do you plan to do after ruling this world?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zane";
                dia.text = "... What the hell are you asking?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "What you do and your thoughts are completely separate. I know that you're in this mess because of your personal feelings. Although we didn't know each other before, you know that loneliness will follow you for the rest of your life along with the ambition of revenge.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zane";
                dia.text = "Shut up! Sicxalon show me your strength.";
            }
            if (tang == 10)
            {
                ZaneVAL1.SetActive(true);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Sicxalon";
                dia.text = "Gruuhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That monster's mana is terrible, did Zexel ever fight with this thing!";
            }
            else if (tang == 12)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "What, kill them quickly, what are you waiting for!";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "Sicxalon";
                dia.text = "Hmm.........";
            }
            else if (tang == 14)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "No way... I've clearly mastered the sealing power... why can't I control it!";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane! Danger stay away from that monster!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "!!!";
            }
            else if (tang == 17)
            {
                ZaneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Sengggggggggggggg...";
            }
            else if (tang == 18)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "There's no way... I was killed by the monster itself!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's what you get you villain.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Zane";
                dia.text = "Damn... let's see how you guys deal with that monster.";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We'll reincarnate it for you. Step aside and observe, we fight not for our selfishness but for our loved ones.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Come on everyone, the final battle must be won!";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus138 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSSicxalon 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Các ngươi mạnh hơn lần trước rất nhiều nhỉ? Ta ngạc nhiên đấy.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tất nhiên rồi! Ngươi nghĩ bọn ta sẽ đến đây mà không có phòng bị ư?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Zane";
                dia.text = "Điều đó cũng không quan trọng...";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane! Ta muốn hỏi ngươi một câu hỏi nữa?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Zane";
                dia.text = "Nói đi nhãi con.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Ngươi tính làm gì sau khi thống trị thế giới này?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Zane";
                dia.text = "... Ngươi hỏi cái quái gì thế hả?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Những gì ngươi làm và suy nghĩ của ngươi hoàn toàn cách biệt nhau. Ta biết rằng ngươi chỉ vì cảm xúc cá nhân mới thành ra nông nỗi này. Dù chúng ta không biết nhau từ trước nhưng ngươi biết rằng nỗi cô độc sẽ theo bám người suốt đời cùng với nỗi tham vọng là trả thù.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Zane";
                dia.text = "Im lặng! Sicxalon cho ta thấy sức mạnh của ngươi nào.";
            }
            if (tang == 10)
            {
                ZaneVAL1.SetActive(true);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Sicxalon";
                dia.text = "Gruuhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mana của con quái vật đó thật khủng khiếp, Zexel đã từng đánh nhau với thứ này sao!";
            }
            else if (tang == 12)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Gì thế, mau giết bọn chúng đi, ngươi còn chần chừ gì thế!";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                ZaneVAR1.SetActive(false);
                NameTagText.text = "Sicxalon";
                dia.text = "Hmm.........";
            }
            else if (tang == 14)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Không thể nào... rõ ràng ta đã nắm chủ sức mạnh phong ấn... sao ta lại không thể điều khiển nó!";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane! Nguy hiểm mau tránh xa con quái vật đó ra!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "!!!";
            }
            else if (tang == 17)
            {
                ZaneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Sengggggggggggggg...";
            }
            else if (tang == 18)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "Không thể nào... ta lại bị chính con quái vật giết ư!";
            }
            else if (tang == 19)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đó là những gì ngươi nhận được đấy tên xấu xa.";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Zane";
                dia.text = "Khốn khiếp... để xem bọn ngươi sẽ giải quyết con quái vật đó ra sao.";
            }
            else if (tang == 21)
            {
                AliaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Bọn ta sẽ hóa kiếp nó cho ngươi xem. Hãy tránh ra mà quan sát đi, bọn ta chiến đấu không vì lòng ích kỷ của bản thân mà là vì những người thân của ta.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Lên nào mọi người, trận đánh cuối cùng nhất định chúng ta phải thắng!";
            }
            else if (tang >= 23)
            {
                CutscenesController.cus138 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSSicxalon 1");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 10)
        {
            cc.FXCutscenes(7);
        }
        else if (tang == 11)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 13)
        {
            cc.FXCutscenes(8);
        }
        else if (tang == 14)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 17)
        {
            cc.FXCutscenes(16);
        }
        else if (tang == 18)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 19)
        {
            cc.BGMCutscenes(3, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus138 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSSicxalon 1");
    }
}