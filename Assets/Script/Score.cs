using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;

public class Score : MonoBehaviour
{
    public static Score Instance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _hightScoreText;

    private int _score;

    // Update is called once per frame
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _currentScoreText.text = _score.ToString();
        _hightScoreText.text = PlayerPrefs.GetInt("HightScore", 0).ToString();
        UpdateHightScore();
    }

    private void UpdateHightScore()
    {
        if (_score > PlayerPrefs.GetInt("HightScore"))
        {
            PlayerPrefs.SetInt("HightScore", _score);
            _hightScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHightScore();
    }
}
