using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus67 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1, ShanVAL1, AlasaVAR1;
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
                dia.text = "Chief Alasa, the three of them have killed all the wolves at your request!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Is that so! The three of you are good too! However, that is just the start.";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "So what do we do next?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alasa";
                dia.text = "Your next mission is to enter the ice cave in the south of this village, which contains frozen crystals, it seems you are an alchemist right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's right!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "If so, you can use mana to prevent the crystal from freezing.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alasa";
                dia.text = "After you find the ice crystals, bring them back here. I will help you get the fire core without damage to the village in the inferno volcano.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Really! If so, we will try our best.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Shan! Please you to follow them.";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "I got it!";
            }
            else if (tang == 11)
            {
                ShanVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Looks like this village chief likes to put us in danger.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "May he have no ill will towards us.";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Hey, you two, stop talking bad about the village chief and finish the quest first.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "There's no need to be grumpy Shan, we're just wondering.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Are you a resident of inferno ice? Because I see you wearing the same outfit as the village chief Alasa.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Shan";
                dia.text = "That's right, I'm from this inferno ice village, don't talk too much and focus on entering the ice cave.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Okay.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus67 = 1;
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
                dia.text = "Thưa trưởng làng Alasa, ba người họ đã hạ hết đám sói theo yêu cầu của ngài rồi!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Vậy ư! Ba người cũng giỏi đấy! Tuy nhiên đó chỉ là khởi động thôi.";
            }
            else if (tang == 3)
            {
                ShanVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy tiếp theo chúng tôi sẽ làm gì?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alasa";
                dia.text = "Nhiệm vụ kế tiếp của các người hãy tiến vào hang băng ở phía nam ngôi làng này, nơi đó chứa đựng tinh thể đóng băng, có vẻ cậu là nhà giả kim thuật đúng không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alasa";
                dia.text = "Nếu vậy cậu có thể sử dụng mana để kiềm chế không bị tinh thể ấy đóng băng.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alasa";
                dia.text = "Sau khi mấy người tìm được tinh thể đóng băng thì hãy mang về đây. Ta sẽ giúp các ngươi lấy được lõi năng lượng lửa mà không bị hư hại gì cho ngôi làng ở inferno volcano.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật vậy ư! Nếu vậy chúng tôi sẽ cố gắng hết sức.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alasa";
                dia.text = "Shan! Ta phiền ngươi hãy theo họ.";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Tôi đã hiểu!";
            }
            else if (tang == 11)
            {
                ShanVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có vẻ trưởng làng này thích đẩy chúng ta vào nguy hiểm thật.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cầu mong ông ấy không có ác ý gì với chúng ta.";
            }
            else if (tang == 13)
            {
                AliaVAL1.SetActive(false);
                ShanVAL1.SetActive(true);
                NameTagText.text = "Shan";
                dia.text = "Này hai người đừng nói xấu trưởng làng nữa mà hãy hoàn thành nhiệm vụ trước đi.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không cần phải gắt gỏng đâu Shan, chúng tôi chỉ hơi thắc mắc thôi.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "À mà cậu là người dân ở inferno ice à? Do tôi thấy cậu mặc đồng phục khá giống với trưởng làng Alasa.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Shan";
                dia.text = "Đúng thế, tôi là người ở làng inferno ice này, đừng nói nhiều nữa hãy tập trung tiến vào hang băng đi.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Được thôi.";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus67 = 1;
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
        CutscenesController.cus67 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }
}