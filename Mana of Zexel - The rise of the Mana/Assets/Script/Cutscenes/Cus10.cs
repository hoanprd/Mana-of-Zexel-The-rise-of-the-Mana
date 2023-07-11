﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus10 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1;
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
                dia.text = "Looks like this journey will be long, right?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That's right! But I will never give up!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "... Hey Vayne, how do you feel about me?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "How is it? I don't quite understand.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Like I'm useful or annoying! More specifically, what kind of person am I in your eyes from personality to attitude... for example.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "... I don't even know how to be specific. But I see that you are a very good person, without you, I would have lost my way.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "... Is that all?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "That's basically it. Anyway, I'm only allowed to relax when I find my dad's whereabouts.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm...";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus10 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có vẻ chuyến đi này sẽ dài nhỉ?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đúng vậy! Nhưng tớ sẽ không bỏ cuộc đâu!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "... Này Vayne, cậu cảm thấy tớ như thế nào vậy?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "How is it? I don't quite understand. Ý cậu là sao? Tớ vẫn chưa hiểu.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Kiểu như tớ có ích với cậu hay gây rối. Cụ thể hơn là trong mắt cậu tớ là người như thế nào từ tính cách đến thái độ... ví dụ vậy á.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Tớ không biết phải mô tả như thế nào. Nhưng đối với tớ cậu là một người tốt, dễ tính nếu như không có cậu có vẻ tớ còn đang lạc đường đây.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Chỉ vật thôi ư?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cơ bản là vậy. Dù sao thì tớ không thể thư giãn khi chưa tìm ra tung tích cha của tớ đâu.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm...";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus10 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
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
        CutscenesController.cus10 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}
