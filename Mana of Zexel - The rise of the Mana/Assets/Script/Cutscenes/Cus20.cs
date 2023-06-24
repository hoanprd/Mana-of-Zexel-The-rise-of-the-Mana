using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus20 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, KlenerVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I think this is enough!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Golemn";
                dia.text = "Grahh...";
            }
            else if (tang == 3)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Watch out for Vayne!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Klener";
                dia.text = "Ahhh...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Klenerr...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "I'm fine, let's finish that golemn quickly.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaa...";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Are you okay? I'm sorry I carelessly caused you to get hurt for me.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Klener";
                dia.text = "No, just a light scratch.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Your shield is broken.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "For a bodyguard like me, this is normal.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, enough for today! Let's go back to town.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus20 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mình nghĩ nhiêu đây là đủ rồi!";
            }
            else if (tang == 2)
            {
                NameTagText.text = "Golemn";
                dia.text = "Grahh...";
            }
            else if (tang == 3)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Coi chừng Vayne!";
            }
            else if (tang == 4)
            {
                KlenerVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                NameTagText.text = "Klener";
                dia.text = "Ahhh...";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Klenerr...";
            }
            else if (tang == 7)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Mình không sao hãy mau dứt điểm con golemn đó đi.";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                KlenerVAR1.SetActive(false);
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaa...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cậu không sao chứ? Xin lỗi mình đã bất cẩn khiến cậu phải bị thương dùm mình.";
            }
            else if (tang == 10)
            {
                KlenerVAR1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Không chỉ là chầy xước nhẹ.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Khiên của cậu đã bị vỡ.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Klener";
                dia.text = "Đối với vệ sĩ như tớ chuyện này bình thường thôi.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi ngày hôm nay là quá đủ rồi! Chúng ta trở về thị trấn thôi.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus20 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Wishing forest");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus20 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Wishing forest");
    }
}