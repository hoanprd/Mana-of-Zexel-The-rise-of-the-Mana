﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus4 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MrLanceVAR1;
    public GameObject NameTag;
    private int tang = 0, TuTang = 0;

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
                dia.text = "Hey Mr. Lance, I'm back.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Oh, it's Alia, what a fun day today.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Today I rescued a person from bandits.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Well done! So, is that the guy you're with with you?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "That's right! He also has combat skills.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hello! My name is Vayne, and I am an alchemist from Zorth.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "I came here to find my father who has been away from home for over a year. My father said he would stop by the town of Zexel.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Is your father an adventurer too?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right, I hope you can remember my dad's been here before. His name is Dante, about 40 years old, wearing an adventure suit with a brown brimmed hat.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Okay let me check my lottery, the adventurers who come here often go on quests to earn extra income. Maybe your father is too.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thank you Mr. Lance!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "In the meantime can you do a little quest for me?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "What kind a quest?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "You said you were an alchemist right?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "That right!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I need you to synthesize a heal potion, is that okay?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, I accept. But I need a cauldron to synthesize.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Don't worry, Alia, take this boy to your room, there's a big cauldron there.";
            }
            else if (tang == 19)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Yeah, okay Vayne, my room's on the right front door.";
            }
            else if (tang >= 20)
            {
                TutorialPanel.SetActive(true);
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này chú Lance, cháu quay lại rồi đây.";
            }
            else if (tang == 2)
            {
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Này, là Alia đó ư, trông như cháu có một ngày vui vẻ nhỉ.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Hôm nay cháu giải cứu một người khỏi bọn cướp đấy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Làm tốt lắm! Vậy đó là chàng trai đang đi cùng cháu đó ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Đúng thế! Cậu ấy cũng có vài kỹ năng chiến đấu đó.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Xin chào! Tên cháu là Vayne và là một nhà giả kim đến từ Zorth.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cháu đến đây để tìm tung tích cha cháu, người đã xa nhà hơn một năm. Cha cháu từng nói là sẽ phiêu lưu ghé qua thị trấn Zexel.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Cha cháu là một nhà phiêu lưu ư?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, cháu mong chú có thể nhớ được gì đó. Ông ấy tên là Dante, một người đàn ông trạc tuổi 40 với mái tóc màu nâu mặc bộ đồ thám hiểm với một cái mũ bệt.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Được rồi để ta tra xem những cuốn sổ ghi danh, những nhà phiêu lưu thường xuyên nhận nhiệm vụ từ đây để kiếm thêm thu nhập. Có thể cha của cháu cũng vậy.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn chú Lance!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Trong thời gian đó cháu có thể làm nhiệm vụ nhỏ cho ta được chứ?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhiệm vụ như thế nào ạ?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Cháu nói cháu là một nhà giả kim đúng không?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy!";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Chú cần cháu tổng hợp một số thứ đó là bình hồi máu được chứ?";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vâng, cháu chấp nhận được. Nhưng cháu sẽ cần một cái vạc cho việc tổng hợp.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Đừng lo lắng, Alia, hãy dắt cậu trai trẻ này về phòng con đi.";
            }
            else if (tang == 19)
            {
                MrLanceVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vâng, được rồi Vayne phòng tớ ở ngay trước cánh cửa này.";
            }
            else if (tang >= 20)
            {
                TutorialPanel.SetActive(true);
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        TutorialPanel.SetActive(true);
    }

    public void PressLTutorialButton()
    {
        if (TuTang > 0)
            TuTang -= 1;

        CheckTutorialStatus();
    }

    public void PressRTutorialButton()
    {
        TuTang += 1;

        if (TuTang > 0)
        {
            CutscenesController.cus4 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Tavern");
        }

        CheckTutorialStatus();
    }

    public void CheckTutorialStatus()
    {
        for (int i = 0; i < TutorialImage.Length; i++)
        {
            if (i == TuTang)
            {
                TutorialImage[i].SetActive(true);
            }
            else
            {
                TutorialImage[i].SetActive(false);
            }
        }
    }
}
