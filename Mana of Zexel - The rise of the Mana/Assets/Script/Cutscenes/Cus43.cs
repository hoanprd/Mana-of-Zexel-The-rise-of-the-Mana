using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus43 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAR1, OrinaVAR1;
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
                dia.text = "Orina! Is you at home?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Where is she going again?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Heh? Ahhhh... There are ghosts!!!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Hey, it's me! Am I a ghost?";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Calm down Alia. Hey Orina, why do you like snooping behind people's backs?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Snooping behind? That's right, what if I like standing here?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that case, your customer will run away!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "I don't care, let's go collect some poisonous tails of scorpions in the inferno desert, then I'll show you how to open the Zexel portal.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Go get some dangerous stuff for you again, Orina?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "Do I want to help for free? In your dream! Anyway, Vayne said that if I want to collect anything, I can just ask Vayne to help me, right?";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ehh... That is.. hehe.";
            }
            else if (tang == 12)
            {
                OrinaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "It seems troublesome.";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey Orina, don't take advantage of people's kindness!";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Taking advantage? Do you not want me to help you open the Zexel portal?";
            }
            else if (tang == 15)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alright! We'll go get the scorpion venom tail, as long as you promise to help us.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "That's right! Hurry up and go if you don't want to waste time.";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's true that the stingy woman is evil.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Orina";
                dia.text = "Heh? You want to fight, kid?";
            }
            else if (tang == 19)
            {
                OrinaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "All right, Alia! Let's go out of here.";
            }
            else if (tang >= 20)
            {
                CutscenesController.cus43 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Orina! Cô có ở nhà không?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cô ta lại đi đâu nữa à?";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Heh? Ahhhh... Có ma!!!";
            }
            else if (tang == 4)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Này, là tôi đây! Bộ tôi là ma à?";
            }
            else if (tang == 5)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Bình tĩnh đi Alia. Này Orina, sao cô thích rình mò sau lưng người khác thé?";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Orina";
                dia.text = "Rình mò sau lưng? Đúng là, tôi thích đứng chỗ này đấy thì sao?";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu thế khách hàng của cô sẽ chạy mất đấy!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Tôi không quan tâm, nào hãy đi thu thập vài cái đuôi độc của bọ cạp ở inferno desert đi, rồi tôi sẽ cho mấy người biết cách mở cánh cổng Zexel.";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Lại đi lấy mấy cái đồ nguy hiểm dùm cô nữa hả Orina?";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "Bộ tôi muốn giúp miễn phí hả? Có mà mơ đi! Dù sao thì Vayne từng nói là nếu tôi muốn thu thập gì thì cứ bảo Vayne giúp là được mà đúng không?";
            }
            else if (tang == 11)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Ehh... Chuyện đó thì.. hehe.";
            }
            else if (tang == 12)
            {
                OrinaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có vẻ phiền phức rồi đấy.";
            }
            else if (tang == 13)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Orina, cô đừng có lợi dụng lòng tốt người ta thế chứ!";
            }
            else if (tang == 14)
            {
                MariaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Lợi dụng? Bộ không muốn tôi giúp cách mở cổng Zexel ư?";
            }
            else if (tang == 15)
            {
                AliaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Được rồi! Chúng tôi sẽ đi lấy đuôi nọc độc bọ cạp về, miễn sao cô hứa là giúp chúng tôi là được.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "Phải vậy chứ! Nào nhanh chân lên đường đi nếu không muốn phí phạm thời gian.";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Đúng là ả đàn bà keo kiệt lại còn xấu xa.";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Orina";
                dia.text = "Heh? Muốn gây chiến hả con nhóc kia?";
            }
            else if (tang == 19)
            {
                OrinaVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Được rồi đấy Alia! Chúng ta mau đi thôi.";
            }
            else if (tang >= 20)
            {
                CutscenesController.cus43 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus43 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}