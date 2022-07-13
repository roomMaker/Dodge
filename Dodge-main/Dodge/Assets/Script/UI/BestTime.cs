using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BestTime : MonoBehaviour
{
    public TextMeshProUGUI _bestTimeUI;

    public void UpdateBestTime(int bestTime)
    {
        _bestTimeUI.text = $"최고기록 {PlayerPrefs.GetInt("최고")}초";
    }
}
