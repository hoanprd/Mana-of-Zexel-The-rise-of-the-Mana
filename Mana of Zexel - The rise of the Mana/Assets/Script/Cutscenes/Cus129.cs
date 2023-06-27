using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus129 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAR1, JescaVAL1, JescaVAR1;
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
                dia.text = "It's dangerous, these monsters are not ordinary.";
            }
            else if (tang == 2)
            {
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Thank you for saving me again.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'm glad that you are fine! May you go back to the village, Mrs. Meru is worried about you!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Jesca";
                dia.text = "Yes! And what's going on in the world, suddenly there's an earthquake and the monsters become more ferocious.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't know, but this means something bad is about to happen.";
            }
            else if (tang == 6)
            {
                JescaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "We should return to Zexel town as soon as possible, I hope there are no problems there.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "You think it was Zane's doing?";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "That's Zane! It must be because of him, if he didn't plot evil things, everyone would still live in peace.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Only when we meet him will we know the truth, we don't have much time to have fun anymore!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus129 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Nguy hiểm thật, bọn quái vật này quả là không tầm thường.";
            }
            else if (tang == 2)
            {
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Cảm ơn anh chị đã cứu em lần nữa.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em không sao là tốt rồi! May quay về làng đi, bà Meru đang lo lắng cho em đấy!";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Jesca";
                dia.text = "Vâng ạ! Mà thế giới đang xảy ra chuyện gì thế, tự nhiên lại có trận động đất rồi mấy con quái vật lại trở nên hung dữ hơn.";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Anh không biết nữa nhưng điều này chứng tỏ có điềm gì đó không hay sắp xảy ra.";
            }
            else if (tang == 6)
            {
                JescaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chúng ta nên quay về Zexel town càng sớm càng tốt đi, cầu mong ở đó không có vấn đề gì.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chị nghĩ rằng là do tên Zane làm ư?";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tên Zane đó! Nhất định do hắn rồi, nếu như hắn không âm mưu những thứ xấu xa gì đó thì mọi người vẫn sống bình yên.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Chỉ khi gặp hắn chúng ta mới biết sự thật, chúng ta cũng không còn nhiều thời gian để vui chơi nữa đâu!";
            }
            else if (tang >= 10)
            {
                CutscenesController.cus129 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana cliff");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus129 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana cliff");
    }
}