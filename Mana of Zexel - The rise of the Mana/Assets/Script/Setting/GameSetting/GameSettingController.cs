using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingController : MonoBehaviour
{
    public GameObject GDLButton, GDRButton, PLLButton, PLRButton, SRLButton, SRRButton;
    public Text DifficultChooseText, PlotLangueChooseText, ScreenResolutionChooseText;

    public static int GameDiff, GameLangPlot, GameScreenResolution;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SDifficultChoose"))
        {
            GDLButton.SetActive(false);
            GameDiff = 0;
        }
        else
        {
            GameDiff = PlayerPrefs.GetInt("SDifficultChoose");
            if (GameDiff == 0)
            {
                GDLButton.SetActive(false);
            }
            else
            {
                GDRButton.SetActive(false);
            }
        }

        if (!PlayerPrefs.HasKey("SPlotLangueChoose"))
        {
            PLLButton.SetActive(false);
            GameLangPlot = 0;
        }
        else
        {
            GameLangPlot = PlayerPrefs.GetInt("SPlotLangueChoose");
            if (GameLangPlot == 0)
            {
                PLLButton.SetActive(false);
            }
            else
            {
                PLRButton.SetActive(false);
            }
        }

        if (!PlayerPrefs.HasKey("SGameResolutionChoose"))
        {
            GameScreenResolution = 1;
        }
        else
        {
            GameScreenResolution = PlayerPrefs.GetInt("SGameResolutionChoose");
            if (GameScreenResolution == 0)
            {
                SRLButton.SetActive(false);
            }
            else if (GameScreenResolution == 2)
            {
                SRRButton.SetActive(false);
            }
        }

        if (GameDiff == 0)
        {
            DifficultChooseText.text = "Normal";
        }
        else if (GameDiff == 1)
        {
            DifficultChooseText.text = "Hard";
        }

        if (GameLangPlot == 0)
        {
            PlotLangueChooseText.text = "English";
        }
        else if (GameLangPlot == 1)
        {
            PlotLangueChooseText.text = "Vietnamese";
        }

        if (GameScreenResolution == 0)
        {
            ScreenResolutionChooseText.text = "960x540";
        }
        else if (GameScreenResolution == 1)
        {
            ScreenResolutionChooseText.text = "1280x720";
        }
        else
        {
            ScreenResolutionChooseText.text = "1920x1080";
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (GameDiff == 0)
        {
            DifficultChooseText.text = "Normal";
        }
        else if (GameDiff == 1)
        {
            DifficultChooseText.text = "Hard";
        }

        if (GameLangPlot == 0)
        {
            PlotLangueChooseText.text = "English";
        }
        else if (GameLangPlot == 1)
        {
            PlotLangueChooseText.text = "Vietnamese";
        }*/
    }

    public void GameDiffucltL()
    {
        GDLButton.SetActive(false);
        GDRButton.SetActive(true);
        GameDiff = 0;
        PlayerPrefs.SetInt("SDifficultChoose", GameDiff);

        if (GameDiff == 0)
        {
            DifficultChooseText.text = "Normal";
        }
        else if (GameDiff == 1)
        {
            DifficultChooseText.text = "Hard";
        }
    }

    public void GameDiffucltR()
    {
        GDRButton.SetActive(false);
        GDLButton.SetActive(true);
        GameDiff = 1;
        PlayerPrefs.SetInt("SDifficultChoose", GameDiff);

        if (GameDiff == 0)
        {
            DifficultChooseText.text = "Normal";
        }
        else if (GameDiff == 1)
        {
            DifficultChooseText.text = "Hard";
        }
    }

    public void GamePlotLangueL()
    {
        PLLButton.SetActive(false);
        PLRButton.SetActive(true);
        GameLangPlot = 0;
        PlayerPrefs.SetInt("SPlotLangueChoose", GameLangPlot);

        if (GameLangPlot == 0)
        {
            PlotLangueChooseText.text = "English";
        }
        else if (GameLangPlot == 1)
        {
            PlotLangueChooseText.text = "Vietnamese";
        }
    }

    public void GamePlotLangueR()
    {
        PLRButton.SetActive(false);
        PLLButton.SetActive(true);
        GameLangPlot = 1;
        PlayerPrefs.SetInt("SPlotLangueChoose", GameLangPlot);

        if (GameLangPlot == 0)
        {
            PlotLangueChooseText.text = "English";
        }
        else if (GameLangPlot == 1)
        {
            PlotLangueChooseText.text = "Vietnamese";
        }
    }

    public void GameScreenResolutionL()
    {
        if (GameScreenResolution == 1)
        {
            SRLButton.SetActive(false);
            GameScreenResolution = 0;
            ScreenResolutionChooseText.text = "960x540";
        }
        else if (GameScreenResolution == 2)
        {
            SRRButton.SetActive(true);
            GameScreenResolution = 1;
            ScreenResolutionChooseText.text = "1280x720";
        }

        PlayerPrefs.SetInt("SGameResolutionChoose", GameScreenResolution);
    }

    public void GameScreenResolutionR()
    {
        if (GameScreenResolution == 0)
        {
            SRLButton.SetActive(true);
            GameScreenResolution = 1;
            ScreenResolutionChooseText.text = "1280x720";
        }
        else if (GameScreenResolution == 1)
        {
            SRRButton.SetActive(false);
            GameScreenResolution = 2;
            ScreenResolutionChooseText.text = "1920x1080";
        }

        PlayerPrefs.SetInt("SGameResolutionChoose", GameScreenResolution);
    }
}
