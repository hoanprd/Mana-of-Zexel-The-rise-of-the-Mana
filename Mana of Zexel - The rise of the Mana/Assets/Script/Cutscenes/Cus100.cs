using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus100 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, MariaVAR1;
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
                NameTag.SetActive(true);
                NameTagText.text = "Mana dragon";
                dia.text = "Grahhhhhhhhhhh...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ha... ha... ha... Maria hold that dragon back!";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Come on Vayne!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaaa...";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Senggggggggggggg...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana dragon";
                dia.text = "Grahhhhhhhh...";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It flew away...";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hehe... Luckily I got the dragon scales in time.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Well done Vayne, with this we can Alia.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay! We're going to... um... huh... hump...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne! Are you alright?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Maybe I tried too hard.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "I'm tired too but we still have a few things to deal with.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm fine, Alia is waiting for us.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus100 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Mana dragon";
                dia.text = "Grahhhhhhhhhhh...";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hà... hà... hà... Chị Maria hãy giữ chân nó lại!";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Tiến lên đi Vayne!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaaaa...";
            }
            else if (tang == 5)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Senggggggggggggg...";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mana dragon";
                dia.text = "Grahhhhhhhh...";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nó bay đi rồi...";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hehe... May thật mình đã kịp lấy vảy rồng rồi.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Hay lắm Vayne, với thứ này chúng ta có thể Alia rồi.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được! Chúng ta về... ự... hộc... hộc...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne! Em không sao chứ?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có lẽ em đã cố quá sức rồi.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị cũng cảm thấy mệt nhưng chúng ta vẫn còn vài thứ để giải quyết nữa.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em ổn rồi, Alia đang đợi chúng ta đó.";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus100 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 1)
        {
            cc.FXCutscenes(14);
        }
        else if (tang == 2)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 5)
        {
            cc.FXCutscenes(11);
        }
        else if (tang == 6)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 6)
        {
            cc.FXCutscenes(14);
        }
        else if (tang == 7)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 10)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus100 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(4, false);
    }
}