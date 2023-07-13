using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus94 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, MariaVAL1, MariaVAR1, MrLanceVAL1, OrinaVAR1;
    public GameObject NameTag;
    private int tang;

    // Start is called before the first frame update
    void Start()
    {
        cc = FindObjectOfType<CutscenesController>();
        tang = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameSettingController.GameLangPlot == 0)
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Uhhhh....";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Wait a minute, I'll create a cure.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Come on Alia...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "What happened?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Alia dealt the fatal blow of the magician who had followed Vayne's father.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Let's see...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "... It's not good, I've never seen such a serious injury.";
            }
            else if (tang == 8)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, hurry and drink!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Ahhh...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "It's not okay, the wound is still spreading... why is that!";
            }
            else if (tang == 13)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "This is a corrosive attack on the body, only magic can remove it from the body.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "No way, mana doesn't work either?";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "Vayne...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I'm sorry... I was so angry... Damn, there must be a way!";
            }
            else if (tang == 17)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "... This dark magic, must be that Zane guy.";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Orina? What is she doing here?";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "I saw you guys rushing back to town, so I stopped by to check it out. It seems that Alia's situation is not good at all.";
            }
            else if (tang == 20)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Damn... it's my fault...";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Hey Vayne! Instead of sitting here whining, go to the southwest of the inferno desert. There is a magic healer in that small village.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Really?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Orina";
                dia.text = "She's tough! Try to convince her to come here.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, I'll go to that doctor! Alia, wait for me!";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus94 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("Tavern");
            }
        }
        else
        {
            if (tang == 1)
            {
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Uhhhh....";
            }
            else if (tang == 2)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Đợi tớ tý, tớ sẽ tạo thuốc chữa.";
            }
            else if (tang == 3)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Cố lên Alia...";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                MrLanceVAL1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Đã có chuyện gì xảy ra thế?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Alia đã chúng đòn chí mạng của tên ma pháp sư từng đi theo cha của Vayne.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Để ta xem sao...";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "... Không ổn rồi, ta chưa thấy vết thương nào nặng đến vậy.";
            }
            else if (tang == 8)
            {
                MrLanceVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 9)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, hãy mau uống đi!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Uhm...";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Alia";
                dia.text = "Ahhh...";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không ổn rồi, vết thương vẫn lan rộng ra... tại sao lại thế!";
            }
            else if (tang == 13)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Đây là đòn tấn công ăn mòn vào cơ thể, chỉ có ma pháp mới có thể loại bỏ nó ra khỏi cơ thể.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Không thể nào, mana cũng không ăn thua ư?";
            }
            else if (tang == 15)
            {
                VayneVAL1.SetActive(false);
                MariaVAR1.SetActive(false);
                NameTagText.text = "Alia";
                dia.text = "Vayne...";
            }
            else if (tang == 16)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Tớ xin lỗi... là do tớ đã quá nóng giận... Chết tiệt, phải có cách nào đó chứ!";
            }
            else if (tang == 17)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "... Ma thuật hắc ám này, chắc là của tên Zane đó rồi.";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Orina? Cô làm gì ở đây thế.";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Ta thấy mấy người chạy gấp về thị trấn nên ta mới ghé qua xem thử thôi. Có vẻ tình hình của Alia không ổn tý nào.";
            }
            else if (tang == 20)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Chết tiệt... là lỗi của mình...";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Này Vayne! Thay vì ngồi đây than vãn thì hay đến phía tây nam của inferno desert đi. Có một vị thầy thuốc chữa trị bằng ma pháp ở ngôi làng nhỏ đó đấy.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật vậy ư?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Orina";
                dia.text = "Bà ta khó tính lắm đấy! Cố gắng mà thuyết phục được bà ta về đây đi.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi, tôi sẽ tới chỗ vị thầy thuốc đó! Alia, hãy đợi tớ!";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus94 = 1;
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
        CutscenesController.cus94 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("Tavern");
    }
}