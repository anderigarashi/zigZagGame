using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;


    [Header("UI Refs")]
    [SerializeField] private TextMeshProUGUI coinsTxt;
    [SerializeField] private TextMeshProUGUI scoreTxt;
    [SerializeField] private gameData gameValues;


    void Start()
    {
        instance = this;
    }

    public void UpdateUI()
    {
        coinsTxt.text = gameValues.coins.ToString();
        scoreTxt.text = gameValues.score.ToString();
    }


}
