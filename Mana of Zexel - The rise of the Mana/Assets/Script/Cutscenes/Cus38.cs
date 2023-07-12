﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus38 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "We've come a long way to the north!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hummm... Look at Vayne the ground here is shallower than usual!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "That means we're near the gate area?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "It's possible, just keep going.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Vay...ne!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia? What is going on?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Heh? ...Alia! Why is your face so bad!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "I don't know! This feeling... feels like my head is spinning around!";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Let me see!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "It's not okay! Alia has been poisoned! The sting on the hand must have been caused by the scorpion monsters!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "If so, it's dangerous! We have to go back to Zexel town!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Do you have an antidote?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't have one but I have a way to find the antidote!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Okay, then let's go back to town!";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus38 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta đã đi khá xa đến phía bắc rồi!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hummm... Nhìn xem Vayne mặt đất ở chỗ này cạn hơn bình thường!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tức chúng ta đang ở gần khu vực cánh cổng ư?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Có thể lắm, chỉ cần đi tiếp là được.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Vay...ne!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia? Có chuyện gì thế?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Heh? ...Alia! Sao sắc mặt cậu tệ thế!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ không biết nữa! Cảm giác này... cảm giác như đầu tớ đang xoay lòng vòng vậy!";
            }
            else if (tang == 10)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Để chị coi thử!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Không ổn rồi! Alia đã bị nhiễm độc! Vết đốt ở tay chắc hẳn do tụi quái vật bọ cạp!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy thì nguy rồi! Chúng ta phải quay về thị trấn Zexel thôi!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Em có thuốc giải ư?";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em không có nhưng em có cách để tìm thuốc giải!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Được rồi, vậy chúng ta về lại thị trấn thôi!";
            }
            else if (tang >= 16)
            {
                CutscenesController.cus38 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 6)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus38 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}