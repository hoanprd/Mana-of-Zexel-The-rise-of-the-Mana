using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus95 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1, va2;
    public GameObject VayneVAL1, VayneVAR1, MariaVAL1, MariaVAR1, JescaVAL1, JescaVAR1, MeruVAL1;
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
                dia.text = "Damn where is that doctor? I searched and couldn't find it.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Try asking the villagers around?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Hey, what little girl? Let me ask you...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Huh? Was it Vayne and Maria?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "So it's you, Jesca? You still good there.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Jesca";
                dia.text = "I'm fine! Are anything okay? And where is Alia, isn't she going with you two?";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Sister Alia is seriously injured by dark magic, I'm looking for a magic healer somewhere in this village. Do you know that person?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Jesca";
                dia.text = "The doctor? In this village there is only one doctor and that is my grandmother!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that case, can you take me to your grandmother's place?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Jesca";
                dia.text = "Of course! Follow me!";
            }
            else if (tang == 11)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                JescaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                MeruVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Oh, so this is the group that rescued your grandson from those inferno scorpions? That is a pleasure.";
            }
            else if (tang == 13)
            {
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Everyone, this is Meru, she is my grandmother, the only and talented doctor in this village!";
            }
            else if (tang == 14)
            {
                JescaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ma'am, can you follow me back to Zexel town and help me heal my friend who got hit by a magician's attack?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Meru";
                dia.text = "Magician? Looks serious. All right, I'm grateful to you anyway, so I'll treat your friend. However, in terms of cost...";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Hey grandma, their friend is the only benefactor in my life!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Meru";
                dia.text = "Oh okay, I'll treat it for free! Now take me there to see what the situation is.";
            }
            else if (tang == 18)
            {
                JescaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you very much!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus95 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chết tiệt vị thầy thuốc đó ở đâu mới được? Mình tìm mãi cũng không thấy.";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hãy thử hỏi dân làng xung quanh xem sao?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "... Này cô bé gì đó ơi? Cho anh hỏi...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                JescaVAL1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Hể? Là anh Vayne và chị Maria đó sao?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Ra là em à Jesca? Em vẫn khỏe chứ?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Jesca";
                dia.text = "Em vẫn khỏe? Còn anh chị thì sao? Mà chị Alia đâu rồi, chị ấy không đi cùng hai người sao?";
            }
            else if (tang == 7)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chị Alia đang bị trọng thương nặng bởi ma thuật hắc ám, anh đang tìm một vị thầy thuốc chữa trị bằng ma pháp đâu đó ở ngôi làng này. Em có biết người đó không?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Jesca";
                dia.text = "Vị thầy thuốc ư? Trong ngôi làng này chỉ có một vị thầy thuốc duy nhất thôi và đó là bà nội của em đó!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu thế thì em có thể dẫn anh đến chỗ bà nội nội em chứ?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Jesca";
                dia.text = "Tất nhiên rồi! Đi theo em!";
            }
            else if (tang == 11)
            {
                va1.SetActive(false);
                va2.SetActive(true);
                JescaVAL1.SetActive(false);
                VayneVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                MeruVAL1.SetActive(true);
                NameTagText.text = "???";
                dia.text = "Ồ ra đây là nhóm người đã giải cứu cháu nội của bà khỏi đám quái vật bò cạp inferno đó sao? Thật vinh dự.";
            }
            else if (tang == 13)
            {
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Mọi người, đây chính là bà nội của em Meru, vị thầy thuốc tài giỏi và duy nhất của ngôi làng này!";
            }
            else if (tang == 14)
            {
                JescaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thưa bà, bà có thể đi theo cháu về thị trấn Zexel giúp cháu chữa trị cho bạn của cháu bị dính phải đòn tấn công của một ma pháp sư được không ạ?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Meru";
                dia.text = "Ma pháp sư ư? Có vẻ nghiêm trọng. Được thôi dù sao ta cũng mang ơn với tụi cháu nên ta sẽ chữa trị cho bạn của cháu. Tuy nhiên về kinh phí thì...";
            }
            else if (tang == 16)
            {
                VayneVAR1.SetActive(false);
                JescaVAR1.SetActive(true);
                NameTagText.text = "Jesca";
                dia.text = "Này bà ơi, bạn của họ chính là ân nhân duy nhất đời cháu đó!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Meru";
                dia.text = "À được rồi, ta sẽ chữa trị miễn phí được chứ! Nào hãy dẫn ta đến đó để xem xét tình hình nào.";
            }
            else if (tang == 18)
            {
                JescaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cháu cảm ơn bà nhiều!";
            }
            else if (tang >= 19)
            {
                CutscenesController.cus95 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Inferno desert");
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
        CutscenesController.cus95 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Inferno desert");
    }

    IEnumerator DelayBGM()
    {
        yield return new WaitForSeconds(2f);
        cc.BGMCutscenes(2, false);
    }
}