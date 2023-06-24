using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus33 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAR1, MariaVAL1, OrinaVAR1;
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
                dia.text = "We've already gathered what you asked for, Orina!";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Okay! Let me check it out!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Orina";
                dia.text = "Looks good! Not bad, we can see that you guys are strong enough to survive in the wishing forest.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "So you're using us to gather resources in such a dangerous place?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Orina";
                dia.text = "What else! Did I go there and get attacked by golems!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe... I'm sorry! I just can't wait to hear from you about the temple of Zexel!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Orina";
                dia.text = "Usually the village guards help me with the gathering of ingredients, but the products I sell in the shop aren't suitable for the townspeople! Can the guards also feel useless when trading items with me so they abandoned me too!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "That makes it harder for me to find resources! So I took the opportunity to ask your team for help.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "What a big deal! If you told me before then I would have collected more.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "I thought this was wasting your time. Anyway, did I promise to tell you about the Zexel temple and how to get there?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Yes, please help!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "The temple of Zexel has been abandoned for a long time since the great alchemist Zexel was buried there!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Orina";
                dia.text = "To get to the temple, you have to go through a gate, that gate is called Zexel gate. And that gate is the boundary between the inferno desert and the temple! Just pass through the gate to reach the temple.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "So where's the gate? Like we can easily pass through the gate?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "That gate is in the north of the desert, I don't know if you can pass the gate or not.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "In that case, only going there will find out!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "That's right! But do you have a problem with that temple? No one has ever put themselves in danger because it's full of monsters!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Indeed, I am also from a faraway land who came here just to find my father's whereabouts! Since my father wanted to go to the Zexel temple, I had to go there!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Is that so! People who want to go to the temple usually have a different reason than you!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "What do you mean?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "Well, never mind, anyway, thanks to everyone who joined me in this exciting transaction! See you again!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                OrinaVAR1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Is she really helping us...";
            }
            else if (tang == 23)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "I don't know either...";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus33 = 1;
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
                dia.text = "Chúng tôi đã thu thập những gì chị yêu cầu rồi đấy Orina!";
            }
            else if (tang == 2)
            {
                OrinaVAR1.SetActive(true);
                NameTagText.text = "Orina";
                dia.text = "Được! Để tôi kiểm tra qua!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Orina";
                dia.text = "Có vẻ được đấy! Không tệ nhỉ, ta có thể thấy mấy cô cậu cũng đủ mạnh để sống sót ở khu rừng wishing.";
            }
            else if (tang == 4)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy cô sử dụng chúng tôi để thu thập các nguồn nguyên liệu ở nơi nguy hiểm vậy sao?";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Orina";
                dia.text = "Chứ còn gì nữa! Bộ tôi đi đến rồi bị bọn golems tấn công à!";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Vayne";
                dia.text = "Hehe... Tôi xin lỗi! Chẳng qua là tôi nóng lòng để nghe cô kể về ngôi đền Zexel quá!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Orina";
                dia.text = "Thường thì các vệ sĩ trong làng thường giúp tôi trong việc thu thập nguyên liệu nhưng các sản phẩm tôi bán trong cửa hàng lại không hợp với người dân trong thị trấn! Nến các vệ sĩ cũng cảm thấy vô ích khi giao dịch vật phẩm với tôi nên họ cũng bỏ rơi tôi!";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Orina";
                dia.text = "Điều đó khiến tôi khó kiếm các nguồn nguyên liệu hơn! Nên tôi nhân cơ hội nhờ nhóm của cậu giúp đỡ một phen.";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Vayne";
                dia.text = "Tưởng chuyện gì lớn! Nếu cô nói trước thế thì tôi đã thu thập nhiều hơn rồi.";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Orina";
                dia.text = "Tôi tưởng là chuyện này đang làm tốn thời gian của cậu chăng. Dù sao thì tôi đã hứa là kể về ngôi đền Zexel cũng như cách đến đó đúng không?";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Vayne";
                dia.text = "Đúng thế mong cô giúp đỡ!";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Orina";
                dia.text = "Ngôi đền Zexel vốn đã bỏ hoang rất lâu rồi kể từ khi nhà giả kim vĩ đại Zexel được chôn cất ở đấy!";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Orina";
                dia.text = "Để đến được ngôi đền thì phải băng qua một cánh cổng, cánh cổng ấy gọi là Zexel gate. Và cánh cổng ấy là ranh giới giữa inferno desert và ngồi đền! Chỉ cần vượt qua cánh cổng là đến được ngôi đền.";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Vayne";
                dia.text = "Vậy cánh cổng ở đâu thế? Cũng như là chúng tôi sẽ dễ dàng đi qua cánh cổng ấy chứ?";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Orina";
                dia.text = "Cánh cổng ấy nằm ở phía bắc sa mạc, còn việc qua được cánh cổng hay không thì tôi không biết.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Vayne";
                dia.text = "Nếu vậy chỉ có đi đến đó mới biết được hết!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Orina";
                dia.text = "Đúng thế! Mà cậu có vấn đề gì cần đến ngôi đền đó ư? Chưa từng ai lại đưa bản thân vào nguy hiểm cả vì ở đó đầy rẫy quái vật!";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Vayne";
                dia.text = "Thật thì tôi cũng là người ở miền đất xa đến đây chỉ để tìm tung tích của cha tôi! Vì cha tôi muốn đến ngôi đền Zexel nên tôi phải đến đó!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Orina";
                dia.text = "Vậy ư! Những người muốn đến ngôi đền thường họ sẽ có lý do khác với cậu đấy!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Vayne";
                dia.text = "Ý cô là sao?";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Orina";
                dia.text = "À mà thôi đừng để tâm, dù sao cảm ơn mấy người đã cùng tôi có màn giao dịch thú vị này! Hẹn gặp lại sau nhé!";
            }
            else if (tang == 22)
            {
                VayneVAL1.SetActive(false);
                OrinaVAR1.SetActive(false);
                MariaVAL1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Có thật là cô ta đang giúp chúng ta không đấy...";
            }
            else if (tang == 23)
            {
                AliaVAR1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Em cũng chẳng biết nữa...";
            }
            else if (tang >= 24)
            {
                CutscenesController.cus33 = 1;
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
        CutscenesController.cus33 = 1;
        ContainerController.LoadingOpen = true;
        SceneManager.LoadScene("GroceryStore");
    }
}