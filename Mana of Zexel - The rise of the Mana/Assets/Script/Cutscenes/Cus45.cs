using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus45 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, OrinaVAR1;
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
                dia.text = "Hey Orina! We've got a bunch of scorpion tails! Are you satisfied?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Hey, don't raise your voice like that!";
            }
            else if (tang == 3)
            {
                OrinaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, stop being like that, give her some respect.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hum... I hate seeing it.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "It's not bad, you guys admit it's good.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "If so, tell us how to open the gate to Orina.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Orina";
                dia.text = "Alright! Actually...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "I really don't know how to open that gate.";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "What... what?";
            }
            else if (tang == 10)
            {
                OrinaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Are you kidding me?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "It's true that I don't know how to open the gate. But I know someone who can show you that gate. Those are the mana gods.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Are you serious, Orina? We risked our lives bringing these back not to listen to such false instructions.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Orina";
                dia.text = "I'm serious! The gods are real, they created the barrier of the gate as well as the key and only they can open it.";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "So if the gods are real, where should we find them?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "It's going to be hard for you for the first time!";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Hey don't go around, we're impatient!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Orina";
                dia.text = "Calm down, there's a mana-filled patch of land south of the inferno desert, if Vayne or Maria would have sensed it if they got close to it!";
            }
            else if (tang == 19)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Are the gods really in that land?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Orina";
                dia.text = "No way! That land is just a place to get to the space of mana gods, whether you can find it or not depends on you.";
            }
            else if (tang == 21)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... That sounds vague. From the existence of a mana god to another dimension.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Orina";
                dia.text = "Believe it or not, go there and check it out, I'm sure they'll know more interesting things than I do.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay, if there's nothing else, we'll go.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Uhm, good luck.";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus45 = 1;
                ContainerController.LoadingOpen = true;
                SceneManager.LoadScene("GroceryStore");
            }
        }
        else
        {
            if (tang == 1)
            {
                AliaVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này Orina! Chúng tôi mang một đống đuôi bọ cạp rồi đấy! Cô hài lòng chứ?";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Này, đừng có lớn giọng như thế chứ!";
            }
            else if (tang == 3)
            {
                OrinaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia, đừng có như vậy nữa, tôn trọng cô ấy chút đi.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Alia";
                dia.text = "Hum... Nhìn mà thấy ghét.";
            }
            else if (tang == 5)
            {
                VayneVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Cũng không tệ, mấy người công nhận cũng giỏi đấy.";
            }
            else if (tang == 6)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Nếu vậy thì hãy cho chúng tôi biết cách để mở cổng đi Orina.";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Orina";
                dia.text = "Được thôi! Thật ra thì...";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Tôi thật sự không biết mở cánh cổng ấy đâu.";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cái... cái gì?";
            }
            else if (tang == 10)
            {
                OrinaVAR1.SetActive(false);
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Cô đang đùa tôi à?";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                AliaVAR1.SetActive(false);
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Đúng là tôi không biết cách mở cổng thiệt. Nhưng mà tôi biết người có thể chỉ cho các người mở cánh cổng ấy. Đó chính là các vị thần mana.";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Cô nghiêm túc đấy chứ Orina? Chúng tôi mạo hiểm tính mạng mang mấy thứ này về không phải để nghe lời chỉ dẫn sai lệch như thế đâu.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Orina";
                dia.text = "Tôi nghiêm túc đấy! Các vị thần là có thật, chính họ đã tạo kết giới của cánh cổng cũng như chìa khóa và chỉ có họ mới mở được nó.";
            }
            else if (tang == 15)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Vậy thì nếu các vị thần có thật thì chúng tôi phải tìm họ ở đâu?";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Orina";
                dia.text = "Đối với các người chắc sẽ hơi khó cho lần đầu đấy!";
            }
            else if (tang == 17)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Này đừng vòng vo nữa, chúng tôi sốt ruột lắm rồi đấy!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Orina";
                dia.text = "Bình tĩnh đi, có một mảnh đất chứa đầy mana ở phía nam của inferno desert, nếu như Vayne hay Maria chắc sẽ cảm nhận được nếu đến gần đấy!";
            }
            else if (tang == 19)
            {
                AliaVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Các vị thần thực sự ở mảnh đất đấy ư?";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Orina";
                dia.text = "Không đâu! Mảnh đất ấy chỉ là nơi để đến được không gian của các vị thần mana, còn tìm được hay không phụ thuộc vào mấy người đấy.";
            }
            else if (tang == 21)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "... Nghe có vẻ mơ hồ thật. Từ việc vị thần mana có tồn tại đến việc chiều không gian khác.";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Orina";
                dia.text = "Tin hay không thì hãy đến đó mà kiểm chứng đi, tôi đảm bảo họ sẽ biết nhiều thứ thú vị hơn tôi đấy.";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi, nếu không có gì nữa thì chúng tôi xin quay về.";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Orina";
                dia.text = "Uhm, chúc may mắn.";
            }
            else if (tang >= 25)
            {
                CutscenesController.cus45 = 1;
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
        CutscenesController.cus45 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}