using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus49 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, MariaVAR1, KlenerVAL1;
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
                KlenerVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Alright! With this amount I think it's enough to be the antidote for our team.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm! If successfully expanding the territory, the villagers will live more peacefully.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Klener";
                dia.text = "Anyway, thanks to everyone who helped me, I'll definitely return the favor!";
            }
            else if (tang == 4)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "No need to be so serious Klener, we're friends, it's normal to help each other.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Did you start learning the truth from Vayne, Alia?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh? What's so strange about the set?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Nothing, you sound a bit like Vayne.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Really?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "I'm going back the town, see you guys soon.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus49 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                KlenerVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Được rồi! Với số lượng này tớ nghĩ đủ để làm thuốc giải cho đội của chúng tớ.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm! Nếu như thành công mở rộng lãnh thổ thì dân làng sẽ sống yên ổn hơn rồi.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Klener";
                dia.text = "Dù sao thì cảm ơn mọi người đã giúp đỡ tớ, nhất định tớ sẽ báo đáp!";
            }
            else if (tang == 4)
            {
                KlenerVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Không cần phải nghiêm trọng thế đâu Klener, chúng ta là bạn bè mà, giúp đỡ nhau là bình thường.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em bắt đầu học chân lý từ Vayne đó à Alia?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh? Bộ có gì lạ lắm à?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "Không có gì, em nói hơi giống Vayne thôi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Thật vậy ư?";
            }
            else if (tang == 9)
            {
                AliaVAL1.SetActive(false);
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Tớ về trước đây, hẹn gặp lại.";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus49 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus49 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }
}