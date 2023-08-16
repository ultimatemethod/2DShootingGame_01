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
        // ����3: ���� UI�� Text�� 0���� �ʱ�ȭ ���ش�.
        attackScoreTxt.text = "0";
        destroyScoreTxt.text = "0";
        bestScore = PlayerPrefs.GetInt("Best Score");
        bestScoreTxt.text = bestScore.ToString();
    }
}
