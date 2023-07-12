using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus53 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject[] TutorialImage;
    public GameObject va1, TutorialPanel;
    public GameObject VayneVAR1, AliaVAL1, MariaVAR1;
    public GameObject NameTag;
    private int tang, TuTang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
        TuTang = 0;
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
                dia.text = "What a tired feeling!... It's annoying.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, what the matter? Is the poison just recurring?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "I feel like my muscles are pinched inside.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "You mean your body is upset inside, right?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Yes, my heart beat faster than usual.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Maybe it's because I can't stand mana in this world.";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mana? That's right, Maria and I both have the ability to withstand a large amount of mana and Alia can't.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "If that's the case, how can you endure the same amount of mana as the two of you? I remember correctly, Vayne's porridge contains mana, how can I still stand it?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Perhaps the mana here is coming from everywhere, that is, your body is absorbing mana continuously, destabilizing the body's mana flow.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Do I have to wait outside until you guys finish meeting the gods? That's not fair at all!";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It seems so.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "It's okay, I have a way, just create something that can suppress Alia's mana flow.";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Well, I never thought of that.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "However, making it won't be as easy as it used to be because it will hurt your mana flow.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "Damage to your mana flow? You still don't understand.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Let's go back to Zexel town then I'll explain better.";
            }
            else if (tang >= 17)
            {
                TutorialPanel.SetActive(true);
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cảm giác mệt mỏi gì thế này!... Thật khó chịu.";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, cậu sao thế? Chẳng lẻ chất độc tái phát ư?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ cảm thấy như cơ tớ bị chèn ép vào bên trong.";
            }
            else if (tang == 4)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Ý em là cơ thể của em có gì đó đảo lộn bên trong khó chịu đúng không?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Đúng thế, nhịp tim em đập nhanh hơn so với bình thường nữa.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Maria";
                dia.text = "Có thể là do em không chịu được mana ở thế giới này.";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Mana ư? Đúng rồi nhỉ, mình và Maria đều có khả năng chịu được nguồn mana lớn tác động vào còn Alia thì không.";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Nếu vậy làm sao em có thể chịu đựng được lượng mana như hai người thế? Em nhớ không lầm, món cháo của Vayne chứa mana thì sao em vẫn chịu được?";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Có lẻ lượng mana ở đây xuất phát từ khắp nơi, tức cơ thể cậu đang hấp thụ mana liên tục gây bất ổn định dòng chảy mana của cơ thể.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Chẳng lẻ tớ phải ở ngoài chờ các cậu gặp xong các vị thần à? Như thế không công bằng tý nào!";
            }
            else if (tang == 11)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ là thế.";
            }
            else if (tang == 12)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Không sao đâu, tớ có cách rồi, chỉ cần tạo một thứ có khả năng trấn áp dòng chảy mana của Alia lại là được.";
            }
            else if (tang == 13)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Vậy ư, chị chưa từng nghĩ tới vụ đó đấy.";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tuy nhiên việc chế tạo nó sẽ không dễ dàng như trước vì việc này sẽ thương tổn đến dòng chảy mana của em.";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Alia";
                dia.text = "Tổn hại đến dòng chảy mana của em ư? Chị vẫn chưa hiểu.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Chúng ta hãy quay về thị trấn Zexel đi khi ấy em sẽ giải thích rõ hơn.";
            }
            else if (tang >= 17)
            {
                TutorialPanel.SetActive(true);
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
        TutorialPanel.SetActive(true);
    }

    public void PressLTutorialButton()
    {
        if (TuTang > 0)
        {
            cc.FXCutscenes(0);
            TuTang -= 1;
        }

        CheckTutorialStatus();
    }

    public void PressRTutorialButton()
    {
        cc.FXCutscenes(0);
        TuTang += 1;

        if (TuTang > 1)
        {
            CutscenesController.cus53 = 1;
            ContainerController.LoadingOpen = true;
            SceneManager.LoadScene("Mana dimension");
        }

        CheckTutorialStatus();
    }

    public void CheckTutorialStatus()
    {
        for (int i = 0; i < TutorialImage.Length; i++)
        {
            if (i == TuTang)
            {
                TutorialImage[i].SetActive(true);
            }
            else
            {
                TutorialImage[i].SetActive(false);
            }
        }
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}