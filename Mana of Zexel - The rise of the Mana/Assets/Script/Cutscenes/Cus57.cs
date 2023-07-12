using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus57 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay, just put it here.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay! Done!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Doesn't it seem to work? She didn't feel any mana in the machine.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "No, look at how much time it took for the machine to absorb a lot of mana through its gauge.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Did you cover the barrier? But do that for what?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Of course, avoid the slimes and other creatures that attack the machine. Because the creatures here often gather in places with a lot of mana.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "I see, you're so wise.";
            }
            else if (tang == 9)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "So does this mean this is our safe place? If so, I don't have to worry about those tough slimes anymore.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Not really, they can sense our presence. So we should just leave the machine alone and only get close to it when it's in use!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Then... I still can't get rid of the slimes.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's okay, you just need to limit coming here.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Okay, okay, let's go back to town.";
            }
            else if (tang >= 14)
            {
                TutorialPanel.SetActive(true);
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được rồi chỉ cần đặt ở đây là xong.";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ok! Xong rồi!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ nó không hoạt động nhỉ? Chị không cảm nhận được lượng mana nào trong cỗ máy.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không đâu, chị nhìn đi mới một tý thời gian mà cỗ máy đã hấp thụ khá nhiều mana thông qua mức đo trên máy.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Em đã bao phủ kết giới ư? Nhưng làm vậy để làm gì?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tất nhiên là tránh lũ slime cũng như các sinh vật khác tấn công vào cỗ máy. Vì các sinh vật nơi đây thường tụ tập những chỗ có nhiều mana.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Ra là vậy, em thật là sáng suốt.";
            }
            else if (tang == 9)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vậy điều này có nghĩa chỗ này là chỗ an toàn của chúng ta ư? Nếu vậy mình không phải lo tụi slime khó ưu kia nữa.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cũng không hẳn, chúng có thể cảm nhận sự hiện diện của chúng ta đấy. Thế nên ta chỉ nên để cỗ máy yên một mình và chỉ đến gần khi dùng thôi!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Vậy thì... tớ vẫn không thoát khỏi tụi slime ư.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không sao đâu, cậu chỉ cần hạn chế đến đây là được.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Được rồi, được rồi, chúng ta mau quay về thị trấn thôi.";
            }
            else if (tang >= 14)
            {
                TutorialPanel.SetActive(true);
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
        TutorialPanel.SetActive(true);
    }

    public void PressLTutorialButton()
    {
        if (TuTang > 1)
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

        if (TuTang > 1)
        {
            CutscenesController.cus57 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana gate");
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