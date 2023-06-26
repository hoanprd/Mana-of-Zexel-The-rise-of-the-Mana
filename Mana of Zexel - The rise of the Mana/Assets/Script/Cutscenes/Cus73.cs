using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus73 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, FOP;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, AsilaVAL1, AsilaVAR1;
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
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "In front here is the core of fire energy. Come on, Vayne, find a way to get it out safely.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Yes, count on me.";
            }
            else if (tang == 3)
            {
                AsilaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It worked!";
            }
            else if (tang == 5)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Wait, you just put something in instead.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's the head of Alasa's ice crystal, sir.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Asila";
                dia.text = "Ice crystals? Impossible, ice crystals only heat shock volcanoes, not stabilize the volcano!";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's that? Could it be that the village chief Alasa would say this helps to get the fire core safely? He said he wanted to surprise the village chief Asila.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroooommmmmmmm...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Earthquake?";
            }
            else if (tang == 11)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "No, the volcano is unstable, it will erupt.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "What is impossible!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Asila";
                dia.text = "You guys have been deceived by my brother!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Everyone we have to get out of here!";
            }
            else if (tang == 15)
            {
                AsilaVAR1.SetActive(false);
                MariaVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmm...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's not good, the path is full of lava.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "No, no, I don't want to die yet.";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                FOP.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggg...";
            }
            else if (tang == 19)
            {
                FOP.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What, Orina's flame is glowing again? No single...";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne quickly use that flame instead of the ice crystal!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaaaaaaaaaaaaaa...";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Chenggggggggggggggg...";
            }
            else if (tang == 23)
            {
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 24)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is everyone okay?";
            }
            else if (tang == 25)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "I'm fine.";
            }
            else if (tang == 26)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne! Are you okay?";
            }
            else if (tang == 27)
            {
                AsilaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm, I'm fine. Orina's fire saved our lives.";
            }
            else if (tang == 28)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "That flame, isn't it the flame from the inferno monster?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Vayne";
                dia.text = "What is an inferno monster?";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Asila";
                dia.text = "It's okay if you don't know, but that fire is only temporary, when that fire goes out, the volcano will continue to erupt.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "Then we can't get the fire core?";
            }
            else if (tang == 32)
            {
                AsilaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Surely there must be a way?";
            }
            else if (tang == 33)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Calm down we still have time to sort this out.";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Maria";
                dia.text = "Asila village chief, will you give us some time to fix this? If we can't solve it, we will return the fire core to you.";
            }
            else if (tang == 35)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "... I hope you guys really have a way, if that's the case, then I will temporarily borrow the fire core to solve this problem.";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Maria";
                dia.text = "Thank you!";
            }
            else if (tang >= 37)
            {
                CutscenesController.cus73 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.IceCrystal -= 1;
                ContainerController.FireOfPeace -= 1;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ở phía trước đây chính là lõi năng lượng lửa đấy. Nào Vayne, hãy tìm cách lấy nó ra một cách an toàn đi.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vâng, hãy trông cậy ở tôi.";
            }
            else if (tang == 3)
            {
                AsilaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thành công rồi!";
            }
            else if (tang == 5)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Khoan đã, cậu vừa đặt thứ gì vô thay thế đấy.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đó là tinh thể băng của trưởng làng Alasa đấy thưa ngài.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Asila";
                dia.text = "Tinh thể băng? Không thể nào, tinh thể băng chỉ núi lửa bị sốc nhiệt chứ không hề tạo ra sự ổn định cho núi lửa!";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Như vậy là sao? Chẳng lẻ trưởng làng Alasa sẽ nói thứ này giúp lấy lõi năng lượng lửa một cách an toàn sao? Ông ấy nói là muốn tạo bất ngờ cho trưởng làng Asila mà.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroooommmmmmmm...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Động đất ư?";
            }
            else if (tang == 11)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Không, núi lửa đang bất ổn định, nó sẽ phun trào mất.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cái gì không thể nào!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Asila";
                dia.text = "Mấy người đã bị em trai ta lừa dối rồi!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mọi người chúng ta phải chạy ra khỏi đây!";
            }
            else if (tang == 15)
            {
                AsilaVAR1.SetActive(false);
                MariaVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Rrroommmmm...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không ổn rồi, lối đi đã tràn ngập dung nham.";
            }
            else if (tang == 17)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Không, không, mình vẫn chưa muốn chết.";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                FOP.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowinggggg...";
            }
            else if (tang == 19)
            {
                FOP.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Gì thế, ngọn lửa của Orina lại phát sáng? Không lẻ nào...";
            }
            else if (tang == 20)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne mau dùng ngọn lửa đó thay thế cho tinh thể băng đi!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaaaaaaaaaaaaaa...";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Chenggggggggggggggg...";
            }
            else if (tang == 23)
            {
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 24)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mọi người vẫn ổn chứ?";
            }
            else if (tang == 25)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ta vẫn ổn.";
            }
            else if (tang == 26)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne! Cậu ổn chứ?";
            }
            else if (tang == 27)
            {
                AsilaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm, tớ không sao. Ngọn lửa của Orina đã cứu chúng ta một mạng.";
            }
            else if (tang == 28)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Ngọn lửa đó, chẳng phải là ngọn lửa từ quái vật inferno ư?";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Vayne";
                dia.text = "Quái vật inferno là gì thế?";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Asila";
                dia.text = "Nếu không biết thì thôi, nhưng ngọn lửa đó chỉ là tạm thời thôi, khi ngọn lửa đó tắt đi thì núi lửa sẽ tiếp tục phun trào.";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì chúng tôi không thể lấy được lõi năng lượng lửa ư?";
            }
            else if (tang == 32)
            {
                AsilaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Chắc hẳn sẽ phải có cách chứ?";
            }
            else if (tang == 33)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cứ bình tĩnh chúng ta vẫn còn thời gian để giải quyết chuyện này.";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Maria";
                dia.text = "Thưa trưởng làng Asila, hãy cho chúng tôi thời gian để khắc phục chuyện này được chứ? Nếu không giải quyết được chúng tôi sẽ trả lại lõi năng lượng lửa cho ngài.";
            }
            else if (tang == 35)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "... Cầu mong mấy người thực sự có cách, nếu vậy thì ta sẽ các người mượn tạm lõi năng lượng lửa để giải quyết chuyện này.";
            }
            else if (tang == 36)
            {
                NameTagText.text = "Maria";
                dia.text = "Cảm ơn ngài!";
            }
            else if (tang >= 37)
            {
                CutscenesController.cus73 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.IceCrystal -= 1;
                ContainerController.FireOfPeace -= 1;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus73 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.IceCrystal -= 1;
        ContainerController.FireOfPeace -= 1;
        SceneManager.LoadScene("InsideVolcanoCave");
    }
}