using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus140 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, AliaVAR1, MrLanceVAL1, KlenerVAL1;
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
                NameTagText.text = "Klener";
                dia.text = "Vayne, Alia you two are back!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm...";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Where's Maria? What is she busy with?";
            }
            else if (tang == 5)
            {
                KlenerVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria! She doesn't come back with us?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Maria did... she sacrificed herself for us...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "No... Maria you promised to come back!";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance please calm down... she made no senseless sacrifices, she saved the world... we will never forget her.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "I see, I need... a quiet place just me...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 11)
            {
                MrLanceVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia I'm leaving town tomorrow morning, tomorrow morning we'll talk.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm... Good night.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus140 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                KlenerVAL1.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Vayne, Alia hai người đã trở về rồi à!";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uhm...";
            }
            else if (tang == 3)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Klener";
                dia.text = "Chị Maria đâu rồi? Chị ấy bận gì rồi sao.";
            }
            else if (tang == 5)
            {
                KlenerVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Maria! Con bé không trở về cùng tụi con sao?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Chị Maria đã... chị ấy đã hy sinh vì bọn con...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Không... Maria con đã hứa sẽ quay trở về mà!";
            }
            else if (tang == 8)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mr. Lance chú hãy bình tĩnh... chị ấy không hề hy sinh vô nghĩa, chị ấy đã cứu thế giới này... bọn con sẽ không bao giờ quên chị ấy.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Ta hiểu, ta cần... một không yên tĩnh chỉ một mình ta...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "...";
            }
            else if (tang == 11)
            {
                MrLanceVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Alia ngày mai anh sẽ rời khỏi thị trấn có gì sáng sớm ngày mai chúng ta sẽ nói chuyện với nhau.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm... Chúc anh ngủ ngon.";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus140 = 1;
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
        CutscenesController.cus140 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}