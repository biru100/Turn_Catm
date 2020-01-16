using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int Score;

    [SerializeField]
    private Text ScoreUI;

    private void Start()
    {
        Score = 0;
    }

    private void LateUpdate()
    {
        ScoreUI.text = "Score : " + Score;
    }
}
