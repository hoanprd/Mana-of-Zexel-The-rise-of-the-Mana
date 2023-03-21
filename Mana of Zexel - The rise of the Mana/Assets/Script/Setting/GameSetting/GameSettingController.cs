using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettingController : MonoBehaviour
{
    public Text DifficultChooseText, PlotLangueChooseText;

    public static int GameDiff, GameLangPlot;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("SDifficultChoose"))
        {
            GameDiff = 0;
        }
        else
        {
            GameDiff = PlayerPrefs.GetInt("SDifficultChoose");
        }

        if (!PlayerPrefs.HasKey("SPlotLangueChoose"))
        {
            GameLangPlot = 0;
        }
        else
        {
            GameLangPlot = PlayerPrefs.GetInt("SPlotLangueChoose");
        }
    }

    // Update is called once per frame
    void Update()
    {
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
    }

    public void GameDiffucltL()
    {
        GameDiff = 0;
        PlayerPrefs.SetInt("SDifficultChoose", GameDiff);
    }

    public void GameDiffucltR()
    {
        GameDiff = 1;
        PlayerPrefs.SetInt("SDifficultChoose", GameDiff);
    }

    public void GamePlotLangueL()
    {
        GameLangPlot = 0;
        PlayerPrefs.SetInt("SPlotLangueChoose", GameLangPlot);
    }

    public void GamePlotLangueR()
    {
        GameLangPlot = 1;
        PlayerPrefs.SetInt("SPlotLangueChoose", GameLangPlot);
    }
}
