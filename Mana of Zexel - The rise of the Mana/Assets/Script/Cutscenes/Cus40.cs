using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus40 : MonoBehaviour
{
    CutscenesController cc;

    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, VayneVAR1, AliaVAL1, AliaVAR1, MariaVAL1, MariaVAR1, MrLanceVAR1;
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
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia! The antidote has been prepared!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Really!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Are you sure it will work?";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "I haven't tried it yet, but I believe...";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "I trust you Vayne!";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Are you sure Alia? We can still make more antidotes. If it fails this time, the medicine may backfire!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "I believe in Vayne! You can see Vayne's determination too, right?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "... That's right, if you say so then I believe in Vayne too. Anyway, he's such a wonderful person!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thank you, Alia! Don't worry you won't die from this stupid poison!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Of course it is!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Drink slowly! Usually these are hard to swallow!";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Haaaaa... It's okay! The bitter pill is fake, and I feel so much better!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "It will take time for the potion to work! So you should rest!";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Everyone looks tense, doesn't it? It's hard to just explore a new continent and be attacked by monsters like that.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Or let me treat you to a hearty meal!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thank you very much! Granted, the outside world is scary, but that doesn't mean you'll give up!";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "That's what men deserve!";
            }
            else if (tang == 19)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 20)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Woah so good! Heh? What a sweet smell!";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Are you awake, Alia?";
            }
            else if (tang == 22)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is the antidote working?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Alia";
                dia.text = "That's right! Yes! Yes! I feel much better now! Thank you so much Vayne! You saved my life already!";
            }
            else if (tang == 24)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Hey! Don't hug me so tight, okay? It's normal to save lives!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Alia";
                dia.text = "I have to repay you by hugging you tight!";
            }
            else if (tang == 26)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! Looks fun, doesn't it, Vayne?";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Stop it! Mr. Lance brought out the food!!";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Alia";
                dia.text = "Is it time to eat! Okay, have a good meal everyone!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus40 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.VenomKiller -= 1;
                SceneManager.LoadScene("Save room");
            }
        }
        else
        {
            if (tang == 1)
            {
                VayneVAL1.SetActive(true);
                NameTag.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Alia! Thuốc giải đã điều chế xong rồi!";
            }
            else if (tang == 2)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Thật vậy ư!";
            }
            else if (tang == 3)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Em có chắc là sẽ hiệu nghiệm chứ?";
            }
            else if (tang == 4)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Em chưa thử, nhưng em tin là...";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Alia";
                dia.text = "Mình tin cậu Vayne!";
            }
            else if (tang == 6)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "... Em chắc chứ Alia? Chúng ta vẫn có thể làm thêm thuốc giải. Nếu lần này thất bại thì thuốc có thể phản tác dụng đấy!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Alia";
                dia.text = "Em tin vào Vayne! Chị cũng thấy được sự kiên quyết của Vayne mà đúng không?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Maria";
                dia.text = "... Đúng là vậy, nếu em nói vậy thì chị cũng tin tưởng ở Vayne. Dù sao cậu ấy đúng là con người kỳ diệu thật!";
            }
            else if (tang == 9)
            {
                MariaVAL1.SetActive(false);
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn cậu Alia! Đừng lo cậu sẽ không chết trước chất độc vớ vẩn này đâu!";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Tất nhiên là vậy rồi!";
            }
            else if (tang == 11)
            {
                VayneVAL1.SetActive(false);
                AliaVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 12)
            {
                VayneVAL1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Uống từ từ thôi! Thường mấy thứ này khó nuốt lắm!";
            }
            else if (tang == 13)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Haaaaa... Không sao đâu! Thuốc đắng giả tật, còn tớ thì cảm thấy tốt hơn nhiều rồi!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Sẽ mất thời gian để thuốc phát huy hiệu quả đấy! Nên cậu hãy nghỉ ngơi đi!";
            }
            else if (tang == 15)
            {
                AliaVAR1.SetActive(false);
                MrLanceVAR1.SetActive(true);
                NameTagText.text = "Mr. Lance";
                dia.text = "Mọi người trông có vẻ căng thẳng nhỉ? Mới ra khám quá lục địa mới mà đã bị quái vật tấn công như vậy thì khó thật.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Mr. Lance";
                dia.text = "Hay là để ta đãi mấy cháu một bữa thịnh soạn nhé!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Vayne";
                dia.text = "Cảm ơn chú nhiều! Công nhận thế giới bên ngoài rất đáng sợ nhưng điều đó không có nghĩa cháu sẽ bỏ cuộc đâu!";
            }
            else if (tang == 18)
            {
                VayneVAL1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Như vậy mới đáng mặt đàn ông đấy!";
            }
            else if (tang == 19)
            {
                MariaVAL1.SetActive(false);
                MrLanceVAR1.SetActive(false);
                NameTagText.text = "";
                dia.text = "...";
            }
            else if (tang == 20)
            {
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Woah khỏe quá! Heh? Có mùi gì thơm thế!";
            }
            else if (tang == 21)
            {
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Cậu dậy rồi sao Alia?";
            }
            else if (tang == 22)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Thuốc giải hiệu nghiệm rồi ư?";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Alia";
                dia.text = "Đúng thế! Đúng thế! Đúng thế! Mình thấy khỏe hơn nhiều rồi! Cảm ơn nhiều nhé Vayne! Cậu đã cứu tớ một mạng rồi!";
            }
            else if (tang == 24)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Này! Đừng ôm tớ chặt thế chứ? Chuyện cứu người là lẽ thường tình rồi!";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Alia";
                dia.text = "Tớ phải trả ơn bằng cách ôm cậu thật chặt chứ!";
            }
            else if (tang == 26)
            {
                VayneVAR1.SetActive(false);
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Hehe! Trông vui ghê nhỉ Vayne?";
            }
            else if (tang == 27)
            {
                MariaVAR1.SetActive(false);
                VayneVAR1.SetActive(true);
                NameTagText.text = "Vayne";
                dia.text = "Thôi kìa! Mr. Lance đã mang đồ ăn ra rồi kìa!";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Alia";
                dia.text = "Đến giờ ăn rồi sao! Được, mời mọi người ăn tối!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus40 = 1;
                ContainerController.LoadingOpen = true;
                ContainerController.VenomKiller -= 1;
                SceneManager.LoadScene("Save room");
            }
        }
    }

    public void Pressnext()
    {
        cc.FXCutscenes(1);

        tang += 1;

        if (tang == 13)
        {
            cc.BGMCutscenes(2, false);
        }
        if (tang == 20)
        {
            cc.BGMCutscenes(0, false);
        }
    }

    public void Pressskip()
    {
        cc.FXCutscenes(1);
        CutscenesController.cus40 = 1;
        ContainerController.LoadingOpen = true;
        ContainerController.VenomKiller -= 1;
        SceneManager.LoadScene("Save room");
    }
}