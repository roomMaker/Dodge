using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestTime : MonoBehaviour
{
    public TextMeshProUGUI _bestTimeUI;

    public void UpdateBestTime(int bestTime)
    {
        _bestTimeUI.text = $"�ְ��� {PlayerPrefs.GetInt("�ְ�")}��";
    }
}
