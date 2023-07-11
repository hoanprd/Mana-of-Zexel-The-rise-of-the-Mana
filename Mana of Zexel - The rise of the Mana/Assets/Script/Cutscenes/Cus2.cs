using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus2 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAL1, AliaVAR1;
    public GameObject NameTag;
    private int tang, TuTang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        TuTang = 0;
        StartCoroutine(DelayBGM());
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Thief";
                dia.text = "You're stronger than I thought, kid.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Don't look down on a alchemist like me.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Thief";
                dia.text = "Alchemist? Like I'm sacred? My comrades help me!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "!!!";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "I don't think so. Hya!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Thief";
                dia.text = "Oh no, that brat again. Retreat!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "What?";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "That's right, run and find another job to do.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... Thanks for helping me there.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "???";
                dia.text = "You welcome! By the way who are you?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Oh! My name is Vayne. I'm a alchemist from the southwest of the land of Zorth.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Nice to meet you Vayne! I'm Alia.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Why is a girl like you in such a dangerous desolate place?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "... Well, I like to travel around Zexel town as well as help people like you.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Did you just say Zexel town? Do you know which direction I need to go?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Yeah it's on the west side of this hill.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ok! Thanks very much.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Alia";
                dia.text = "Hey! Can I go with you? I can help you the way there.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yeah, sure! It's my pleaser.";
            }
            else if (tang == 20)
            {
                NameTag.SetActive(false);
                dia.text = "Alia join the team.";
            }
            else if (tang >= 21)
            {
                TutorialPanel.SetActive(true);
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Thief";
                dia.text = "Ngươi mạnh hơn ta nghĩ đấy nhóc.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đừng có mà coi thường một giả kim thuật như ta.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Thief";
                dia.text = "Nhà giả kim ư? Nhìn như ta sợ lắm ư? Đệ của ta đâu ra đây mà giúp ta nào!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "!!!";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Ta không nghĩ thế. Hya!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Thief";
                dia.text = "Lại nữa rồi, là con nhãi đó. Rút quân thôi!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cái quái gì thế?";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Đúng thế, chạy và tìm thứ gì khác mà làm đi.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm... Cảm ơn đã giúp tôi nha.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "???";
                dia.text = "Không sao đâu! Mà cậu là ai thế?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "À! Mình tên là Vayne. Một nhà giả kim đến từ phía đông của vùng đất Zorth.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Rất vui được gặp cậu Vayne! Tớ là Alia.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tại sao một cô gái như cậu lại ở một nơi hoang vắng nguy hiểm như này?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "... Thì, mình cũng phiêu lưu xung quanh thị trấn Zexel để giúp đỡ những người như cậu đó.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu vừa nhắc đến thị trấn Zexel ư? Cậu có biết nên đi hướng nào không?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Ừ thì nó ở phía tây nam của khu đồi này.";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ok! Cảm ơn rất nhiều nha.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Alia";
                dia.text = "Này! Tớ có thể đi với cậu chứ? Biết đâu tớ có thể giúp được gì trên đường đi sao.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm, tất nhiên rồi! Cảm ơn nhiều nhé.";
            }
            else if (tang == 20)
            {
                NameTag.SetActive(false);
                dia.text = "Alia đã tham gia vào đội hình";
            }
            else if (tang >= 21)
            {
                TutorialPanel.SetActive(true);
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 20)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 21)
        {
            cc.BGMCutscenes(4, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        TutorialPanel.SetActive(true);
    }

    public void PressLTutorialButton()
    {
        if (TuTang > 0)
        {
            cc.FXCutscenes(0);
            TuTang -= 1;
        }

        CheckTutorialStatus();
    }

    public void PressRTutorialButton()
    {
        cc.FXCutscenes(0);

        TuTang += 1;

        if (TuTang > 2)
        {
            CutscenesController.cus2 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Wishing hill");
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

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}
