using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus74 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, AliaVAL1, MariaVAL1;
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
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne, do you have a way to deal with this? But I don't know anything then.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm really confused too.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "I think there's a way to deal with that volcano.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne, you mentioned the element of mana before, right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, mana also has elements and in total there are five basic elements of mana. Consists of fire, ice, wind, earth and thunder.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "In that case, can you create an energy core containing fire energy?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "I don't know. If there was a prototype like this, I would make a copy but contain my mana instead of Zexel's.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "As long as the volcano is stable, it doesn't matter whose mana. The important thing is that we need Zexel's power core to open the portal.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, I'll do my best! This time will be like the first time I do something important that I have never encountered.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I believe you will succeed, Vayne, as long as you have the heart, everything will go well.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "The problem is that I only see my mother using elemental mana to craft. So I'm not sure I'll succeed the first time. If it fails, Zexel's energy core will also be destroyed.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "I only have one chance. Certain! Definitely not fail!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus74 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Vayne, cậu có cách nào giải quyết chuyện này không? Chứ tớ thì không biết gì rồi đó.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thật sự tớ cũng rối lắm đây.";
            }
            else if (tang == 3)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chị nghĩ là có cách giải quyết được ngọn núi lửa đó đấy.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Maria";
                dia.text = "Vayne, em đã nhắc tới nguyên tố của mana trước đó đúng không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế, mana cũng có nguyên tố và tổng cộng có năm nguyên tố cơ bản của mana. Bao gồm lửa, băng, gió, đất và sấm sét";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy thì em có thể tạo một lõi năng lượng chứa năng lượng lửa chứ?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Em không biết nữa. Nếu như đã có bản mẫu như này thì em sẽ tạo một bản sao chép nhưng chứa mana của em thay vì của Zexel.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "Chỉ cần duy trì lại ổn định của núi lửa thì mana của ai không quan trọng. Điều quan trọng là chúng ta cần lõi năng lượng của Zexel để mở cánh cổng.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được em sẽ cố gắng hết sức! Lần này sẽ coi như là lần đầu em làm một thứ quan trọng mà em chưa từng bao giờ gặp phải.";
            }
            else if (tang == 10)
            {
                MariaVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Tớ tin cậu sẽ thành công mà Vayne, chỉ cần có tâm huyết thì mọi thứ sẽ diễn ra tốt đẹp.";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vấn đề là mình chỉ thấy mẹ mình sử dụng nguyên tố mana để chế tạo thôi. Nên tớ không chắc là sẽ thành công lần đầu. Nếu thất bại lõi năng lượng của Zexel cũng sẽ bị phá hủy.";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tớ chỉ có một cơ hội duy nhất. Nhất định! Nhất định không được thất bại!";
            }
            else if (tang >= 13)
            {
                CutscenesController.cus74 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
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
        CutscenesController.cus74 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}