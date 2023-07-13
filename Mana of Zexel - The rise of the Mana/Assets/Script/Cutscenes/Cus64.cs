using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus64 : MonoBehaviour
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
                dia.text = "Unbelievable... It's awfully cold in here.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... I... I... I'm... cold to the bone... here!!!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Let's try! We need to find a village around here before we all freeze.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay... we... let's go...";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I think we should... hug each other... hug each other Vayne...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Stop joking around Alia... we need to focus on moving forward.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "These guys...";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus64 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật không thể tin nổi... Ở đây lại lạnh kinh khủng.";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "... Mình... Mình... lạnh muốn thấu xương... luôn đây!!!";
            }
            else if (tang == 3)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cố gắng nào! Chúng ta cần kiếm một ngôi làng quanh đây trước khi cả đám bị đóng băng mất.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được thôi... chúng ta... chúng ta đi thôi...";
            }
            else if (tang == 5)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tớ nghĩ chúng ta nên... ôm nhau... ôm nhau đi Vayne...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Bớt giỡn đi Alia... chúng ta cần tập trung về phía trước.";
            }
            else if (tang == 7)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Mấy đứa này... đúng là...";
            }
            else if (tang >= 8)
            {
                CutscenesController.cus64 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno ice");
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
        CutscenesController.cus64 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno ice");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}