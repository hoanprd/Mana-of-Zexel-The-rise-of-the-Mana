using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus72 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAR1, MariaVAL1, AsilaVAL1;
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
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It's hotter than outside, we won't be able to stay long in here.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Okay, as long as there's nothing in the way we can easily get into the depths of the volcano.";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "It's not that easy, this is where slimes gather.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Heh? Another slime? Why so much.";
            }
            else if (tang == 5)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(In that case, the ice cave last time, I found the ice energy core.)";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Wow, where did Shan go?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "He's not coming with us?";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Shan told me he had business in inferno ice so he left first, so please protect me this time!";
            }
            else if (tang == 9)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "In that case, I'll clear the way for these slimes!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "... It's true that God has no eyes on me...";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus72 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
        else
        {
            if (tang == 1)
            {
                MariaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nơi đây nóng hơn cả bên ngoài, chúng ta khó mà trụ được trong này lâu.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được thôi, chỉ cần không có gì cản trở chúng ta có thể dễ dàng tiến vào sâu bên trong núi lửa.";
            }
            else if (tang == 3)
            {
                MariaVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Mọi chuyện không dễ vậy đâu, ở đây là nơi tụ tập slime đấy.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Heh? Lại là slime nữa ư? Sao mà nhiều thế.";
            }
            else if (tang == 5)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "(Nếu vậy thì hang động băng lần trước, mình đã tìm thấy lõi năng lượng băng rồi.)";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "Ủa, Shan đi đâu rồi?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu ấy không đi cùng chúng ta ư?";
            }
            else if (tang == 8)
            {
                VayneVAL1.SetActive(false);
                AsilaVAL1.SetActive(true);
                NameTagText.text = "Asila";
                dia.text = "Shan nói với ta là có công chuyện ở inferno ice nên đã về trước, nhờ mấy người bảo vệ ta lần này nhé!";
            }
            else if (tang == 9)
            {
                AsilaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vâng, tôi sẽ dọn đường đám slime này!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "... Đúng là ông trời không có mắt với mình rồi...";
            }
            else if (tang >= 11)
            {
                CutscenesController.cus72 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("InsideVolcanoCave");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus72 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("InsideVolcanoCave");
    }
}