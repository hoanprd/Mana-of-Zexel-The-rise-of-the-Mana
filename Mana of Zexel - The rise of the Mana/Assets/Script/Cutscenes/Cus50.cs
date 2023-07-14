using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus50 : MonoBehaviour
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
                dia.text = "This is... the land of mana?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This place is full of mana, I feel it very well.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Everything around is strange, like we are in the fairy forest.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "But I still feel something is not right about the color of this land.";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You mean everything around has to be green right?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, the mana nature will bring life to the surroundings but this place is like a dead land, the ground is purple.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's like there's no life in this place.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "What... what are those?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "... That's...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Ergggggg";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's a slime.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Slime? This is the first time I've encountered them, I've only seen them in books until now.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Usually they gather in places with mana like this, because their bodies need mana to sustain life.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "So should we fight?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "No need, they won't hurt us if we don't touch them.";
            }
            else if (tang == 16)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey... Hey don't come near me... you look slimy, disgusting!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Let's just dodge them and move on.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Looks like Orina isn't joking around with this.)";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus50 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana gate");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đây là... vùng đất của mana ư?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nơi này chứa đầy mana, chị cảm nhận nó rất rõ.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mọi thứ xung quanh lạ thật, giống như ta đang ở khu rừng cổ tích vậy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nhưng mà em vẫn cảm nhận gì đó không đúng đối với màu sắc của vùng đất này.";
            }
            else if (tang == 5)
            {
                AliaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ý em là mọi thứ xung quanh phải xanh tươi đúng không?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, bản chất mana sẽ mang lại sự sống cho xung quanh nhưng nơi đây như một vùng đất chết, mặt đất thì màu tím.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nơi này như không có sự sống vậy.";
            }
            else if (tang == 8)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Mấy... mấy cái kia là gì thế?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Đó là...";
            }
            else if (tang == 10)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "???";
                dia.text = "Ergggggg";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đó là một con slime.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Slime ư? Đây là lần đầu chị gặp phải đấy, hồi giờ chị chỉ thấy chúng trong sách thôi.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thường bọn chúng tụ tập tại những nơi có mana như này, vì cơ thể chúng cần mana để duy trì sự sống.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Maria";
                dia.text = "Ra là thế chúng ta nên chiến đấu chứ?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không cần đâu, bọn chúng sẽ không làm hại chúng ta nếu không động vào chúng.";
            }
            else if (tang == 16)
            {
                MariaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này... Này đừng có lại gần ta... trông nhớt nhát, tởm thật!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta cứ né chúng và đi tiếp thôi.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "(Có vẻ Orina không hề đùa giỡn mấy chuyện này rồi)";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus50 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Mana gate");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 10)
        {
            cc.FXCutscenes(9);
        }
        else if (tang == 11)
        {
            cc.FXCutscenesStop();
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus50 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Mana gate");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}