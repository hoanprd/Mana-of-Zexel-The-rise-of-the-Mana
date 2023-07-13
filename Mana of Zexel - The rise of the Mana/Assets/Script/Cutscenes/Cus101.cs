﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus101 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, MariaVAR1, MrLanceVAL1, MrLanceVAR1, MeruVAR1;
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
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Are you two back? Alia is much better now.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Well then, we brought back the dragon scales.";
            }
            else if (tang == 3)
            {
                MrLanceVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mrs. Meru, we're counting on you.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Unexpectedly, these are real mana dragon scales. Okay, it will take quite a while to make the antidote.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Is there anything we can do to help?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "No need, only me is enough. And you should also look at yourself, don't carry so much responsibility that destroys your body.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "... I see...";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We should go out for a while and rest, Vayne. Alia will definitely be fine.";
            }
            else if (tang == 9)
            {
                MeruVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Then let me make dinner for everyone.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus101 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                MrLanceVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Hai đứa về rồi à? Alia cũng đỡ hơn nhiều rồi đấy.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy thì tốt rồi vì bọn con đã mang vảy rồng về.";
            }
            else if (tang == 3)
            {
                MrLanceVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Bà Meru, tụi cháu trông cậy vào bà.";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                MeruVAR1.SetActive(true);
                NameTagText.text = "Meru";
                dia.text = "Thật bất ngờ, đây đúng là vảy rồng mana thật. Được rồi sẽ mất kha khá thời gian để điều chế thuốc giải đấy.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bọn cháu có thể giúp được gì không?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Meru";
                dia.text = "Không cần đâu, một mình ta là đủ rồi. Mà cháu cũng nên nhìn lại bản thân đi, đừng quá mang nặng trọng trách như thế mà tàn phá cơ thể của mình.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Cháu hiểu rồi...";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta nên ra ngoài dạo tý và nghỉ ngơi đi Vayne. Alia nhất định sẽ ổn thôi.";
            }
            else if (tang == 9)
            {
                MeruVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Vậy thì để ta làm sẵn đồ ăn tối cho mọi người nhé.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus101 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
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
        CutscenesController.cus101 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}