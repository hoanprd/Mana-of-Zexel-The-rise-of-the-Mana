using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus99 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAR1, MariaVAL1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We've come a long way and still haven't met any dragons.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Anyway, I'll keep looking, I'm sure I'll find it.";
            }
            else if (tang == 3)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "??? Something just flew by.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Something, it's very loud.";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mana dragon";
                dia.text = "Gruhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It looks like a real cow inside.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hey dragon! We don't want to hurt you, we just want one of your scales okay?";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mana dragon";
                dia.text = "Gruhhhhhhhhhhhhhhh...";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, not all dragons understand and are friendly with humans.";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "If that's the case, then we'll have to use force.";
            }
            else if (tang >= 12)
            {
                CutscenesController.cus99 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta đã tiến khá sâu rồi mà vẫn chưa gặp con rồng nào.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Dù thế thì em sẽ tiếp tục tìm kiếm, nhất định sẽ tìm thấy.";
            }
            else if (tang == 3)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "??? Vừa rồi có gì đó vừa bay qua.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có gì đó, nó rất to.";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mana dragon";
                dia.text = "Gruhhhhhhhhhhhhhhhhhh...";
            }
            else if (tang == 7)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ trong nó giống con bò thật.";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này rồng ơi! Bọn ta không muốn làm hại mi, bọn ta chỉ muốn một chiếc vảy của ngươi thôi được chứ?";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "Mana dragon";
                dia.text = "Gruhhhhhhhhhhhhhhh...";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vayne, không phải loài rồng nào cũng hiểu và thân thiện với con người đâu.";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy thì đành phải dùng đến vũ lực thôi.";
            }
            else if (tang >= 12)
            {
                CutscenesController.cus99 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 3)
        {
            cc.FXCutscenes(13);
        }
        else if (tang == 4)
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

        if (tang == 9)
        {
            cc.FXCutscenes(14);
        }
        else if (tang == 10)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 4)
        {
            cc.BGMCutscenes(0, true);
        }
        if (tang == 4)
        {
            cc.BGMCutscenes(5, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus99 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}