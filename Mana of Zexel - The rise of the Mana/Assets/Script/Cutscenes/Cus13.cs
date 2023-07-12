using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus13 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang = 0;

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
                dia.text = "Heh? Do we owe any golems? Why are they gathered here?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "That one looks like a leader! Do they remember our faces for equating them?";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It's not like they look so weird as if they just lost something.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Then they want revenge on us!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Not really, but prepare yourself.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Golemn";
                dia.text = "Graaaa...";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Maria if you don't mind then...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "It's okay I can fight, I'll be of little help to you guys especially in terms of recovery.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus13 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSGolemn 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Heh? Bộ tụi mình có nợ gì với tụi golemn à? Sao chúng lại tụ tập ở đây thế?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Con kia trông như con đầu đàn vậy! Bộ chúng nhớ mặt chúng ta vì đã đánh đồng loại chúng ư?";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Không phải đâu trông chúng rất kỳ lạ như vừa mất mát gì vậy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Vậy thì chúng muốn trả thù chúng ta rồi!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Không hẳn thế nhưng hãy chuẩn bị tinh thần đi.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Golemn";
                dia.text = "Graaaa...";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chị Maria nếu không phiền thì...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Không sao chị chiến đấu được, chị sẽ giúp ít được cho các em đấy nhất là về hồi phục.";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus13 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("BSGolemn 1");
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
        CutscenesController.cus13 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("BSGolemn 1");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(4, false);
    }
}