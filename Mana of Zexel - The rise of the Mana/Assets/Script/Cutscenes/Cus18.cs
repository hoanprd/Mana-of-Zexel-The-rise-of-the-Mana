using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus18 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAR1, KlenerVAL1;
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
                KlenerVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Vayne! If you don't mind, could you help me with something?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What's your problem, Klener?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Klener";
                dia.text = "I just wanted you to make some healing potions and mana shields for me.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "I'll do it easily when it comes to recovery, but the mana shield is the same as Maria?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Klener";
                dia.text = "Is that shield made by Maria? Maybe I asked the wrong person, sorry!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "No problem, I just learned the recipe and wanted to try it out. You can trust me!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "So? If so, then I'm bothering you!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Wait a minute, I'll be right in!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus18 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
        else
        {
            if (tang == 1)
            {
                KlenerVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Klener";
                dia.text = "Vayne này! Nếu không phiền thì cậu có thể giúp tôi một số thứ được không?";
            }
            else if (tang == 2)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cậu gặp chuyện gì khó khăn ư Klener?";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Klener";
                dia.text = "Chỉ là mình muốn cậu chế tạo giúp tớ vài bình hồi máu và lá chắn mana.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Bình hồi máu thì tớ làm dễ còn lá chắn mana tức giống màn chắn của Maria ư?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Klener";
                dia.text = "Tấm chắn đó của chị Maria làm ư? Có lẽ tớ đã yêu cầu nhầm người rồi, xin lỗi cậu!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không sao tớ cũng mới học được công thức mà muốn thử nghiệm đây. Cậu có thể tin ở tôi!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Klener";
                dia.text = "Vậy ư? nếu vậy thì làm phiền cậu rồi!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cậu hãy đợi tôi tý, tôi sẽ vào làm ngay đây!";
            }
            else if (tang >= 9)
            {
                CutscenesController.cus18 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Zexel town");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus18 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Zexel town");
    }
}