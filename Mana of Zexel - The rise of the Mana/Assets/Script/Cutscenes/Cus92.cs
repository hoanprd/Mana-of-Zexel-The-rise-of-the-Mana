using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus92 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2, va3;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, ZaneVAL1;
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
                dia.text = "We just need to put two mana cores like this?";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Still no response?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Heh? Two energy cores flying towards the door scene?";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggg...";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "Rammmmmmmmmmmmmmm...";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "The door is open!";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Can we go in already?";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Come on, maybe your father is waiting there, Vayne.";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Take it easy, be careful of traps and monsters around.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "What a passionate youth.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                ZaneVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "I just felt something coming.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "???";
                dia.text = "That's annoying, it seems the Sicxalon revival has been put on hold. But that's okay, everything happened faster than I expected hahahahahaaa...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus92 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta chỉ cần đưa hai lõi năng lượng mana như thế này thôi ư?";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vẫn chưa có phản ứng gì sao?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Heh? Hai lõi năng lượng đang bay vào phía cảnh cửa à?";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "Glowinggggggggggggg...";
            }
            else if (tang == 5)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                NameTagText.text = "";
                dia.text = "Rammmmmmmmmmmmmmm...";
            }
            else if (tang == 6)
            {
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cánh cửa đã mở ra rồi!";
            }
            else if (tang == 7)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta đã có thể tiến vào rồi ư?";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nào đi thôi, biết đâu cha của cậu đang đợi trong đó đấy Vayne.";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Từ từ thôi, cẩn thận bẫy và quái vật xung quanh đấy.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Maria";
                dia.text = "Đúng là tuổi trẻ nhiệt huyết thật.";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                va2.SetActive(false);
                va3.SetActive(true);
                ZaneVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Mình vừa cảm nhận có thứ gì đó đang tới đây.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "???";
                dia.text = "Thật phiền phức, có vẻ việc hồi sinh Sicxalon phải tạm hoãn rồi. Nhưng mà không sao mọi chuyện đã diễn ra nhanh hơn so với dự tính của mình hahahahahaaa...";
            }
            else if (tang >= 14)
            {
                CutscenesController.cus92 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel gate");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 4)
        {
            cc.FXCutscenes(3);
        }
        else if (tang == 5)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 5)
        {
            cc.FXCutscenes(2);
        }
        else if (tang == 6)
        {
            cc.FXCutscenesStop();
        }

        if (tang == 11)
        {
            cc.BGMCutscenes(0, true);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus92 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel gate");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}