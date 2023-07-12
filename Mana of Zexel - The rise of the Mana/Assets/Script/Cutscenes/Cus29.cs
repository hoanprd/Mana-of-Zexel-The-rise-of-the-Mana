using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus29 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAR1, OrinaVAL1;
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
                OrinaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Are the kids still in there?";
            }
            else if (tang == 2)
            {
                NameTagText.text = "???";
                dia.text = "!!!";
            }
            else if (tang == 3)
            {
                OrinaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Heh? Who's that!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "???";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What's wrong, Vayne?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Just now I felt someone watching us and passing like a shadow!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Following us? But we have nothing for others to follow!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't know, but it's strange how did you feel just now?";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If there's nothing, we'll just keep going, if someone is following us, we'll lose our tail if we just follow us.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus29 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                OrinaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Bọn nhóc vẫn còn trong đó ư?";
            }
            else if (tang == 2)
            {
                NameTagText.text = "???";
                dia.text = "!!!";
            }
            else if (tang == 3)
            {
                OrinaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Heh? Ai đó!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "???";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có chuyện gì thế Vayne?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vừa rồi mình cảm nhận được người nào đó vừa theo dõi chúng ta và vụt qua như bóng đen!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Theo dõi chúng ta ư? Mà chúng ta có gì đâu cho người khác theo dõi thế!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Mình không biết nhưng lạ thật cảm giác vừa nãy là sao nhỉ?";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu không có gì thì chúng ta đi tiếp thôi, nếu có người theo dõi thì cũng sẽ lòi đuôi nếu cứ bám theo chúng ta thôi.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Uhm!";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus29 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
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
        CutscenesController.cus29 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}