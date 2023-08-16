using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int attackScore;
    public int bestScore;
    public int destroyScore;

    public TMP_Text attackScoreTxt;
    public TMP_Text bestScoreTxt;
    public TMP_Text destroyScoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        // 목적3: 점수 UI의 Text를 0으로 초기화 해준다.
        attackScoreTxt.text = "0";
        destroyScoreTxt.text = "0";
        bestScore = PlayerPrefs.GetInt("Best Score");
        bestScoreTxt.text = bestScore.ToString();
    }
}
