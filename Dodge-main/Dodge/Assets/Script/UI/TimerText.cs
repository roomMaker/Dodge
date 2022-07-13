using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public float SurvivalTime { get; private set; }
    public bool IsOn { get; set; }  
    private TextMeshProUGUI _ui;
    private float _elapsedTime;
    void Start()
    {
        IsOn = true;
        _ui = GetComponent<TextMeshProUGUI>();  
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOn)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= 1f)
            {
                SurvivalTime += _elapsedTime;
                _elapsedTime = 0f;
                _ui.text = $"�ð� : {(int)SurvivalTime}��";
            }
        }
    }

}
