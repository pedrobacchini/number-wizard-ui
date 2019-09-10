using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI guessText = null;

    [SerializeField] private int max;
    [SerializeField] private int min;
    private int _guess;

    private void Start()
    {
        NextGuest();
    }

    public void OnPressHigher()
    {
        min = Math.Min(_guess + 1, max);
        NextGuest();
    }

    public void OnPressLower()
    {
        max = Math.Max(_guess - 1, min);
        NextGuest();
    }

    private void NextGuest()
    {
//        Include min e exclude max
        _guess = Random.Range(min, max + 1);
        guessText.text = _guess.ToString();
    }
}