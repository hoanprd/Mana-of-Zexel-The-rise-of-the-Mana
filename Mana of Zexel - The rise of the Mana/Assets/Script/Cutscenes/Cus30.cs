using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cus30 : MonoBehaviour
{
    public Text NameTagText;
    public Text dia;
    public GameObject va1;
    public GameObject VayneVAL1, AliaVAL1, MariaVAR1;
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
                dia.text = "Maria! What do you need to craft?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Just adding bombs is enough!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Okay then let's make some potions with bombs! Please sit down and wait for a while.";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "It's good to admit that alchemy is good too! Can make potions, weapons and even food!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "I remember you said you hated alchemy at first, Alia.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "... Ehhhhh, I must have been doing boring things at that time, so you must be bored!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "... What a quick change of nature! Is it true that seeing a handsome man changes your personality?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Nope! No. of course!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Really, every time I mention him, it's...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Me and Vayne are just friends!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Huh? Did you mention Vayne?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "But who else?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Who knows? But you don't have to hide it from me! What a sad day when you were with me! When meeting Vayne, it's like a monkey jumping to Vayne!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "Hey... Come on, don't embarrass me!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "All right! I won't tease you anymore.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Never mind, I'm mad at you!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = "... Come on, I'm just joking, are you angry?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "It's not funny at all!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "... Hehe I'm happy enough!!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Alia";
                dia.text = "Such a wicked you are!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "I promise to make up for a meal!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Alia";
                dia.text = "Your meal was never as good as Vayne's!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh...";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "Oh, I really like Vayne!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Alia";
                dia.text = "... Why do you like to press me like that!!!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Don't be angry, don't be angry.";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Alia";
                dia.text = "Stop talking to me!!!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus30 = 1;
                ContainerController.LoadingOpen = true;
                MapController.TavernToSaveRoom = true;
                MapController.ZexelTownToTavern = false;
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
                dia.text = "Chị Maria! Chị cần chế tạo gì chứ?";
            }
            else if (tang == 2)
            {
                MariaVAR1.SetActive(true);
                NameTagText.text = "Maria";
                dia.text = "Chỉ cần thêm bom là đủ rồi!";
            }
            else if (tang == 3)
            {
                NameTagText.text = "Vayne";
                dia.text = "Được rồi vậy em chế tạo một vài dược phẩm với bom nhé! Phiền hai người ngồi đợi một tý.";
            }
            else if (tang == 4)
            {
                VayneVAL1.SetActive(false);
                AliaVAL1.SetActive(true);
                NameTagText.text = "Alia";
                dia.text = "Công nhận giả kim thuật cũng hay nhỉ! Có thể chế tạo dược phẩm, vũ khí và cả đồ ăn nữa!";
            }
            else if (tang == 5)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị nhớ ban đầu em bảo là ghét giả kim thuật mà Alia.";
            }
            else if (tang == 6)
            {
                NameTagText.text = "Alia";
                dia.text = "... Ehhhhh, chắc lúc đó chị toàn làm những thứ chán òm nên chắc em thấy chán thôi!";
            }
            else if (tang == 7)
            {
                NameTagText.text = "Maria";
                dia.text = "... Đúng là bản tính đổi nhanh thật! Có phải là thấy trai đẹp là đổi tính không đấy?";
            }
            else if (tang == 8)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh... Không có nha! Chắc chắn là không!";
            }
            else if (tang == 9)
            {
                NameTagText.text = "Maria";
                dia.text = "Thật chứ mỗi lần nhắc đến cậu ấy là...";
            }
            else if (tang == 10)
            {
                NameTagText.text = "Alia";
                dia.text = "Em với Vayne chỉ là bạn bình thường thôi nha!";
            }
            else if (tang == 11)
            {
                NameTagText.text = "Maria";
                dia.text = "Hể? Chị có nhắc đến Vayne à?";
            }
            else if (tang == 12)
            {
                NameTagText.text = "Alia";
                dia.text = "Chứ còn ai khác đâu?";
            }
            else if (tang == 13)
            {
                NameTagText.text = "Maria";
                dia.text = "Ai biết được nhỉ? Mà thôi em không cần phải giấu chị đâu! Cả ngày qua chị đi cùng em thì buồn như gì! Khi gặp Vayne thì lại như con khỉ nhảy dựng đến Vayne vậy!";
            }
            else if (tang == 14)
            {
                NameTagText.text = "Alia";
                dia.text = "Hể... Thôi nào đừng làm em khó xử mà!";
            }
            else if (tang == 15)
            {
                NameTagText.text = "Maria";
                dia.text = "Thôi được rồi! Chị không chọc em nữa đâu.";
            }
            else if (tang == 16)
            {
                NameTagText.text = "Alia";
                dia.text = "Thôi không cần, em giận chị luôn!";
            }
            else if (tang == 17)
            {
                NameTagText.text = "Maria";
                dia.text = "... Thôi nào chị chỉ đùa tý mà giận luôn à?";
            }
            else if (tang == 18)
            {
                NameTagText.text = "Maria";
                dia.text = "Đùa không vui tý nào!";
            }
            else if (tang == 19)
            {
                NameTagText.text = "Maria";
                dia.text = "... Hehe chị vui là được rồi!";
            }
            else if (tang == 20)
            {
                NameTagText.text = "Alia";
                dia.text = "Đồ ác độc!";
            }
            else if (tang == 21)
            {
                NameTagText.text = "Maria";
                dia.text = "Chị hứa sẽ đền bù một bữa ăn cho!";
            }
            else if (tang == 22)
            {
                NameTagText.text = "Alia";
                dia.text = "Bữa ăn của chị không bao giờ ngon bằng Vayne đâu!";
            }
            else if (tang == 23)
            {
                NameTagText.text = "Maria";
                dia.text = "...";
            }
            else if (tang == 24)
            {
                NameTagText.text = "Alia";
                dia.text = "Heh...";
            }
            else if (tang == 25)
            {
                NameTagText.text = "Maria";
                dia.text = "Ồ vậy em thích Vayne thật rồi!";
            }
            else if (tang == 26)
            {
                NameTagText.text = "Alia";
                dia.text = "... Sao chị cứ thích chèn ép em thế!!!";
            }
            else if (tang == 27)
            {
                NameTagText.text = "Maria";
                dia.text = "Đừng giận mà, đừng giận mà.";
            }
            else if (tang == 28)
            {
                NameTagText.text = "Alia";
                dia.text = "Đừng hòng nói chuyện với em nữa nha!!!";
            }
            else if (tang >= 29)
            {
                CutscenesController.cus30 = 1;
                ContainerController.LoadingOpen = true;
                MapController.TavernToSaveRoom = true;
                MapController.ZexelTownToTavern = false;
                SceneManager.LoadScene("Save room");
            }
        }
    }
    public void Pressnext()
    {
        tang += 1;
    }
    public void Pressskip()
    {
        CutscenesController.cus30 = 1;
        ContainerController.LoadingOpen = true;
        MapController.TavernToSaveRoom = true;
        MapController.ZexelTownToTavern = false;
        SceneManager.LoadScene("Save room");
    }
}