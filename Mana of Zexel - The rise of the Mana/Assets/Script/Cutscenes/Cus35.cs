using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus35 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, JescaVAR1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Damn hot!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You're the coolest, Alia! When I only carry armor on your body instead of a coat like you.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Come on, don't lie to me like that!";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "The desert here is like hell fire! Looks like this inferno makes this desert so hot!!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "We just need to go north and follow the cliffs and we won't get lost!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Ahhhhhhhhhhhhhhhh... Someone please save me!";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Whose cry for help is that?";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Over there!";
            }
            else if (tang == 9)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "A girl! The scorpion monsters are trying to attack that girl!";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(false);
                JescaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Someone save me!!!";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaa! Girl, step back and let me handle this!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "???";
                dia.text = "Yes!";
            }
            else if (tang == 13)
            {
                JescaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Dare to bully people in this desert? I will not forgive!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Be careful! These monsters are not like the monsters we met before!";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus35 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 4;
                SceneManager.LoadScene("BSInfernoScorpion 1");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Nóng chết đi được!";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em là người mát nhất đấy Alia! Khi em chỉ mang theo bộ giáp trong người thay vì cái áo khoác như chị.";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Thôi nào đừng nói xỏ em như thế!";
            }
            else if (tang == 4)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Công nhận sa mạc ở đây như lửa địa ngục vậy! Có vẻ cái tên inferno này khiến cho sa mạc này nóng không ngừng vậy!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Chúng ta chỉ cần tiến về phía bắc là được cứ đi theo các vách núi là sẽ không bị lạc!";
            }
            else if (tang == 6)
            {
                MariaVAR1.SetActive(false);
                VayneVAL1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Ahhhhhhhhhhhhhhhhh... Xin ai đó hãy cứu tôi!";
            }
            else if (tang == 7)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Có tiếng kêu cứu của ai thế?";
            }
            else if (tang == 8)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ở đằng kia!";
            }
            else if (tang == 9)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Một đứa bé gái! Nguy rồi bọn quái vật bọ cạp đang muốn ăn thịt cô bé đó!";
            }
            else if (tang == 10)
            {
                VayneVAR1.SetActive(false);
                JescaVAR1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Ai đó hãy cứu tôi!!!";
            }
            else if (tang == 11)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hyaaaaaa! Cô bé hãy lùi lại đi để anh giải quyết chuyện này!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "???";
                dia.text = "Vâng ạ!";
            }
            else if (tang == 13)
            {
                JescaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Dám ăn hiếp con người ta giữa trời sa mạc này ư? Ta sẽ không tha!";
            }
            else if (tang == 14)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hãy cẩn thận! Bọn quái vật này không như những quái vật trước đó mà chúng ta gặp đâu!";
            }
            else if (tang >= 15)
            {
                CutscenesController.cus35 = 1;
                ContainerController.LoadingOpen = true;
                HPMPBarController.EIndex = 4;
                SceneManager.LoadScene("BSInfernoScorpion 1");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus35 = 1;
        ContainerController.LoadingOpen = true;
        HPMPBarController.EIndex = 4;
        SceneManager.LoadScene("BSInfernoScorpion 1");
    }
}