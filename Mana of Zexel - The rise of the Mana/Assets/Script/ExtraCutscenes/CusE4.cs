using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CusE4 : MonoBehaviour
{
    ExtraCutscenesController ecc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, AliaVAR1, MariaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        ecc = FindObjectOfType<ExtraCutscenesController>();
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
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "The scenery here is so cool!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is this what the sea breeze feels like? The smell of steam is very strong.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "You haven't seen the sea yet?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Of course! I think if Zexel town, besides the river and the forest, there is no sea?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Right? My hometown also has a sea but it is a beach.";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "The beach? How does it look?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "There will be long sandy beach. People there will go there to sunbathe and rest.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Really? I also want to try it out!";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Sounds like a place to travel, doesn't it?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Unfortunately, this place is deep so there is no beach to play.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Usually the beach will have girls wearing clothes...";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What clothes?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ah... Nothing... Nothing at all...";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Are you hiding something?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's okay, let's get back to the main business.";
            }
            else if (tang >= 16)
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Khung cảnh nơi đây mát thật!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cảm giác gió biển là như thế này ư? Mùi hơi nước rất nồng nặc.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hai người vẫn chưa thấy biển ư?";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Tất nhiên rồi! Em nghĩ thử thị trấn Zexel ngoài sông với rừng ra thì có biển đâu?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng nhỉ? Quê nhà em cũng có biển tuy nhiên là một bãi biển.";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bãi biển ư? Trông như thế nào vậy?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nơi đấy sẽ có cát phủ dài bờ biển đấy. Người dân ở đó sẽ ra đó để tắm nắng và nghỉ ngơi.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Thật vậy ư? Tớ cũng muốn trải nghiệm thử!";
            }
            else if (tang == 9)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nghe có vẻ như một nơi để du lịch nhỉ?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tiếc là nơi đây là vực sâu nên không có bãi biển để vui chơi.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thường thì bãi biển sẽ có cô gái mặc những bộ đồ...";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Bộ đồ gì cơ?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Á... Không có gì... Không có gì cả...";
            }
            else if (tang == 14)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em đang giấu điều gì đó đúng không?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không gì đâu, chúng ta mau quay lại công việc chính thôi.";
            }
            else if (tang >= 16)
            {
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
    }

    public void Pressnext()
    {
        ecc.FXCutscenes(1);

        tang += 1;
    }

    public void Pressskip()
    {
        ecc.FXCutscenes(1);
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        ecc.BGMCutscenes(2, false);
    }
}
