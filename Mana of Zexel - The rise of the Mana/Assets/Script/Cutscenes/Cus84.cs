using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus84 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1, AlasaVAL1, AlasaVAR1, AsilaVAL1, AsilaVAR1;
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
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Alasa! It's been a while since we met like this!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Hum... Don't think I'm here for you. I came to see if this kid Vayne can do what he says?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Asila";
                dia.text = "... Vayne, are you ready?";
            }
            else if (tang == 4)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm ready, now let's get started.";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowing...";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "The land... is green again.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This land used to contain mana too? I can feel its inherent mana mixed with Vayne's mana.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "What a land that is coming back to life...";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Is this true?";
            }
            else if (tang == 11)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Now, I've done what needed to be done, do you have any questions?";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Alasa, I... I...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "Even so, I still don't trust you.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Asila";
                dia.text = "... I know it's hard but anyway, the land that our parents believed in has come back to life, with this we will combine the two villages into one and...";
            }
            else if (tang == 15)
            {
                AsilaVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Crackkkkk... crackkkkkkkkk...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What is it?";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "There's something on that hill!";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Crackkkkkkkkkkkkkkkkkkk...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "";
                dia.text = "Gruuuuuuuuuuuuuuuuuuuuuuuuhhhhhhhhhhh...";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What is that! A monster!";
            }
            else if (tang == 21)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "It can't be... Inferno beast!!!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Isn't that thing sealed a long time ago? How come it got out!";
            }
            else if (tang == 23)
            {
                AlasaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "This monster, this place has a conflict that needs to be resolved, this is not a place for you to mess around.";
            }
            else if (tang == 24)
            {
                AsilaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chief Asila and Alasa stay back we'll deal with it.";
            }
            else if (tang == 25)
            {
                AliaVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Where's the goddamn Shan gone! Just when we need him.";
            }
            else if (tang == 26)
            {
                VayneVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Be careful, that monster is an ancient monster so it's very strong.";
            }
            else if (tang == 27)
            {
                AlasaVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Rest assured we are not weak. Come on up, everyone!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus84 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.PurifyingPotion -= 1;
                HPMPBarController.EIndex = 22;
                SceneManager.LoadScene("BSInfernoBeast 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                AsilaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Alasa! Lâu rồi ta mới được gặp nhau như này!";
            }
            else if (tang == 2)
            {
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Hum... Đừng tưởng ta đến đây vì ngươi. Ta đến đây để xem thằng nhóc Vayne này có làm được lời nó nói không?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Asila";
                dia.text = "... Vayne, cậu đã chuẩn bị xong rồi chứ?";
            }
            else if (tang == 4)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tôi đã chuẩn bị xong, giờ thì bắt đầu thôi.";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 6)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "Glowing...";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mảnh đất... đanh xanh trở lại.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vùng đất này cũng từng chứa mana ư? Mình có thể cảm nhận mana vốn có của nó trộn lẫn mana của Vayne vào.";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Thật là mảnh đất đang hồi sinh trở lại...";
            }
            else if (tang == 10)
            {
                MariaVAR1.SetActive(false);
                AlasaVAR1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Điều này là thật ư?";
            }
            else if (tang == 11)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nào, tôi đã làm những gì cần làm rồi, hai người còn thắc mắc gì không?";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Alasa, ta... ta...";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alasa";
                dia.text = "Dù thế thì ta vẫn chưa tin tưởng ở ông đâu.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Asila";
                dia.text = "... Ta biết chuyện này khó nhưng dù sao, mảnh đất mà cha mẹ chúng ta tin tưởng đã hồi sinh trở lại, với việc này chúng ta sẽ gộp chung hai ngôi làng làm một và...";
            }
            else if (tang == 15)
            {
                AsilaVAL1.SetActive(false);
                AlasaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Crackkkkk... crackkkkkkkkk...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chuyện gì thế?";
            }
            else if (tang == 17)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ở ngọn đồi kia có thứ gì đó!";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Crackkkkkkkkkkkkkkkkkkk...";
            }
            else if (tang == 19)
            {
                NameTagText.text = "";
                dia.text = "Gruuuuuuuuuuuuuuuuuuuuuuuuhhhhhhhhhhh...";
            }
            else if (tang == 20)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cái gì thế! Một con quái vật!";
            }
            else if (tang == 21)
            {
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Không thể nào đó là... Inferno beast!!!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Thứ đó chẳng lẻ bị phong ấn từ lâu rồi mà? Sao nó lại thoát ra rồi!";
            }
            else if (tang == 23)
            {
                AlasaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Con quái vật này, chỗ này đang có vấn đề mâu thuẫn cần giải quyết không phải là nơi cho ngươi phá đám đâu.";
            }
            else if (tang == 24)
            {
                AsilaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Trưởng làng Asila và Alasa hãy lùi lại chúng tôi sẽ giải quyết nó.";
            }
            else if (tang == 25)
            {
                AliaVAL1.SetActive(false);
                AlasaVAL1.SetActive(true);
                NameTagText.text = "Alasa";
                dia.text = "Tên Shan chết tiệt đi đâu mất rồi! Đúng lúc ta lại cần hắn.";
            }
            else if (tang == 26)
            {
                VayneVAR1.SetActive(false);
                AsilaVAR1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Hãy cẩn thận, con quái vật đó là một quái vật cổ xưa nên nó rất mạnh.";
            }
            else if (tang == 27)
            {
                AlasaVAL1.SetActive(false);
                AsilaVAR1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hãy yên tâm chúng tôi không có yếu đâu. Lên thôi mọi người!";
            }
            else if (tang >= 28)
            {
                CutscenesController.cus84 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.PurifyingPotion -= 1;
                HPMPBarController.EIndex = 22;
                SceneManager.LoadScene("BSInfernoBeast 1");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 6)
        {
            cc.FXCutscenes(2);
        }
        else if (tang == 7)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 15)
        {
            cc.FXCutscenes(2);
        }
        else if (tang == 16)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 18)
        {
            cc.FXCutscenes(5);
        }
        else if (tang == 19)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 19)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 20)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 15)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 18)
        {
            cc.BGMCutscenes(5, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus84 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.PurifyingPotion -= 1;
        HPMPBarController.EIndex = 22;
        SceneManager.LoadScene("BSInfernoBeast 1");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}