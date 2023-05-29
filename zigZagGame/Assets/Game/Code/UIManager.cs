using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;


    [Header("UI Refs")]
    [SerializeField] private TextMeshProUGUI coinsTxt;
    [SerializeField] private TextMeshProUGUI scoreTxt;
    [SerializeField] private gameData gameValues;
    [SerializeField] private Text txt_paused;
    [SerializeField] private Text txt_coins;


    void Start()
    {
        instance = this;
    }

    public void UpdateUI()
    {
        coinsTxt.text = gameValues.coins.ToString();
        scoreTxt.text = gameValues.score.ToString();
    }

    public void ShowHidePausedTxt(bool value)
    {
        txt_paused.enabled = value;
        print("changing txt paused");
    }

    public void AddCoin(int value)
    {
        gameValues.coins += gameValues.coinValue;
        UpdateUI();
    }

    public void AddScorePoint(int value)
    {
        gameValues.score += gameValues.scoreValue;
        UpdateUI();
    }
}
