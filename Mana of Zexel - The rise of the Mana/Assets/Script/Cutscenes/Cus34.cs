﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus34 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAL1, MariaVAR1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is everyone ready? Ahead is the inferno desert full of dangers!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I've been ready from the moment I came to this town!";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I'm ready too! It's so exciting to be with a group of people like this!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's weird too! I think when I get to town everything will be as normal as I will be alone on this journey!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "But looking back, things are different! Not only have comrades like Maria and Alia, but also know many people in this town!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! You mean like it was fate that we met?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's right! If it wasn't for fate, I'd be lying at home now, bored to death because I couldn't explore the world around me!";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You guys are so... Anyway thank you all for letting me have this precious experience!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Come on, let's go!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "All";
                dia.text = "Let's go!";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus34 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mọi người đã chuẩn bị chứ? Phía trước là inferno desert với đầy rẫy nguy hiểm đấy!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em luôn sẵn sàng từ lúc đến thị trấn này rồi!";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Em cũng sẵn sàng rồi! Thật hứng khởi khi đồng hành một nhóm người như thế này đấy!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cũng kỳ lạ thật! Mình nghĩ khi đến thị trấn mọi chuyện sẽ theo bình thường như mình sẽ cô đơn trên hành trình này!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà nhìn lại thì mọi chuyện khác thật! Không chỉ có đồng đội như chị Maria và Alia mà còn quen biết nhiều người trong thị trấn này nữa!";
            }
            else if (tang == 6)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! Ý em như việc chúng ta gặp nhau là định mệnh ư?";
            }
            else if (tang == 7)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đúng thế! Nếu không phải định mệnh thì giờ mình đang nằm trong nhà chán chết đi được vì không được đi khám phá thế giới xung quanh!";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mọi người thật là... Dù sao cũng cảm ơn mọi người đã cho mình có trải nghiệm quý giá này!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nào chúng ta đi thôi!";
            }
            else if (tang == 10)
            {
                AliaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "All";
                dia.text = "Đi thôi!";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus34 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus34 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}