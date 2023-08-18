using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus93 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1, ZaneVAL1, ZaneVAR1;
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
                dia.text = "Is this the temple of Zexel? I feel...";
            }
            else if (tang == 2)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Alia... Alia... Where are you?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Mommy!!!";
            }
            else if (tang == 4)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "(What is this, just now...)";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is something wrong, Alia?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Ah... it's nothing!";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "The air around here feels suffocating.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Should we split up, Vayne?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "It seems so...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Krakkkk... Krakkkk...";
            }
            else if (tang == 11)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Oh, I can't believe anyone can get in here!";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Who is that? This source of power...";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I can feel the dark mana energy like Shan's. What the hell.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "???";
                dia.text = "This kid and that red-haired girl, you two are magicians, why do you have so much mana in them.";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We are alchemists named Vayne and Maria, the other is our friend Alia.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "I'm a bit rude, aren't I? My name is Zane and I am a magician.";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane? That was the name of the magician Shan had mentioned.";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!! It turned out that he was the guy who lured Shan to destroy two villages inferno volcano and inferno ice.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Zane";
                dia.text = "Destroy? That has nothing to do with us. The girl named Alia looks familiar, doesn't she?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Then you know the man named Dante?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Zane";
                dia.text = "Dante? Oh... you mean the gentle guy I mutilated him a year ago?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "!!! What did you just say? My father was taken by you...";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zane";
                dia.text = "He's already dead. But what does he have to do with you?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "I am his son!!!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zane";
                dia.text = "So? That's right, don't remind me he has a son. Looks like we got to meet that kid right here.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bastard!!! I will not forgive you!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Zane";
                dia.text = "Hey don't be so hasty, okay?";
            }
            else if (tang == 28)
            {
                ZaneVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaa...";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Zane";
                dia.text = "You're too young, kid! Shield!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Zane";
                dia.text = "Sengggggggggg....";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "I can't get through him.";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Zane";
                dia.text = "Die you brat with a milky mouth.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Alia";
                dia.text = "Vayne! Watch...";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia!";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Alia";
                dia.text = "Ahhhhhhhhh...";
            }
            else if (tang == 36)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Aliaaaaaa!";
            }
            else if (tang == 37)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "You're lucky that girl died for you. I'm busy with my own business, see you later.";
            }
            else if (tang == 38)
            {
                ZaneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alia! It's not okay, that attack is a critical hit.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm sorry... Alia...";
            }
            else if (tang == 40)
            {
                NameTagText.text = "Maria";
                dia.text = "Quickly bring her back to Mr. Lance go. She won't be able to withstand this attack for long.";
            }
            else if (tang >= 41)
            {
                CutscenesController.cus93 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đây là đền thờ Zexel ư? Mình cảm giác...";
            }
            else if (tang == 2)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Alia... Alia... Con đang ở đâu?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Mẹ ơi!!!";
            }
            else if (tang == 4)
            {
                va2.SetActive(false);
                va1.SetActive(true);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "(Gì thế này, vừa rồi là...)";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có chuyện gì không ổn ư Alia?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "À... không có gì đâu!";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không khí quanh đây cảm thấy ngột ngạt thật.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Chúng ta nên tách ra chứ Vayne?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có vẻ thế...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Krakkkk... Krakkkk...";
            }
            else if (tang == 11)
            {
                ZaneVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Ồ, thật không thể tin được lại có người có thể vô được đây đấy!";
            }
            else if (tang == 12)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ai thế? Nguồn sức mạnh này...";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mình có thể cảm nhận được nguồn năng lượng mana hắc ám như của Shan. Cái quái gì thế.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "???";
                dia.text = "Thằng nhóc này với con nhỏ tóc đỏ kia, hai đứa là pháp sư à sao lại có mana khá lớn trong người đó.";
            }
            else if (tang == 15)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng tôi là nhà giả kim thuật tên là Vayne và Maria, người kia là Alia bạn của chúng tôi.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Zane";
                dia.text = "Có vẻ ta hơi vô lễ nhỉ? Tên ta là Zane là một ma pháp sư.";
            }
            else if (tang == 17)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Zane ư? Đó là tên của ma pháp sư mà Shan đã nhắc tới.";
            }
            else if (tang == 18)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "!!! Thì ra ông chính là tên đã dụ dỗ Shan phá hủy hai ngôi làng inferno volcano và inferno ice.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Zane";
                dia.text = "Phá hủy? Chuyện đó không liên quan đến ta. Mà con nhỏ tên Alia kia có vẻ quen nhỉ?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì ông biết người đàn ông tên Dante chứ?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Zane";
                dia.text = "Dante? Ồ... ý ngươi là cái tên hiền từ mà ta đã phanh thây hắn một năm trước ư?";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "!!! Ngươi vừa nói cái gì? Cha ta đã bị ngươi...";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Zane";
                dia.text = "Hắn đã chết rồi. Mà hắn có liên quan gì đến ngươi à?";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ta chính là con trai của ông ấy!!!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Zane";
                dia.text = "Vậy ư? Đúng rồi nhỉ, hắn đừng nhắc ta là hắn có một đứa con trai. Có vẻ ta đã được gặp thằng nhóc đó ngay tại đây rồi.";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tên khốn!!! Ta sẽ không tha cho ngươi đâu!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Zane";
                dia.text = "Này đừng nóng vội thế chứ?";
            }
            else if (tang == 28)
            {
                ZaneVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaa...";
            }
            else if (tang == 29)
            {
                NameTagText.text = "Zane";
                dia.text = "Ngươi còn non lắm nhóc! Lá chắn!";
            }
            else if (tang == 30)
            {
                NameTagText.text = "Zane";
                dia.text = "Sengggggggggg....";
            }
            else if (tang == 31)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mình không thể đánh xuyên hắn được.";
            }
            else if (tang == 32)
            {
                NameTagText.text = "Zane";
                dia.text = "Chết đi tên nhóc miệng còn hôi sữa.";
            }
            else if (tang == 33)
            {
                NameTagText.text = "Alia";
                dia.text = "Vayne! Coi chừng...";
            }
            else if (tang == 34)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia!";
            }
            else if (tang == 35)
            {
                NameTagText.text = "Alia";
                dia.text = "Ahhhhhhhhh...";
            }
            else if (tang == 36)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Aliaaaaaa!";
            }
            else if (tang == 37)
            {
                ZaneVAR1.SetActive(true);
                NameTagText.text = "Zane";
                dia.text = "May cho ngươi là con nhỏ đó chịu chết thay ngươi đó. Ta cũng bận chuyện riêng của ta rồi, hẹn gặp lại sau.";
            }
            else if (tang == 38)
            {
                ZaneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Alia! Không ổn rồi, đòn tấn công đó là một đòn chí mạng.";
            }
            else if (tang == 39)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ xin lỗi... Alia...";
            }
            else if (tang == 40)
            {
                NameTagText.text = "Maria";
                dia.text = "Mau đưa cô ấy về chỗ Mr. Lance đi. Đòn tấn công này cô ấy sẽ không chịu được lâu đâu.";
            }
            else if (tang >= 41)
            {
                CutscenesController.cus93 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel temple");
            }
        }
        
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 10)
        {
            cc.FXCutscenes(12);
        }
        else if (tang == 11)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 28)
        {
            cc.FXCutscenes(11);
        }
        else if (tang == 29)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 30)
        {
            cc.FXCutscenes(10);
        }
        else if (tang == 31)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 35)
        {
            cc.FXCutscenes(10);
        }
        else if (tang == 36)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 37)
        {
            cc.FXCutscenes(12);
        }
        else if (tang == 38)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 18)
        {
            cc.BGMCutscenes(5, false);
        }
        if (tang == 34)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus93 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel temple");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(1, false);
    }
}