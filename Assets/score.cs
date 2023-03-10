using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Text

public class score : MonoBehaviour
{
    public int initialScore;    //初始分數
    public int addScorePerSec; //每秒增加的分數
    private int currScore; //現在的分數

    
    
    void Start()
    {
        //設定初始分數
        initialScore = 0;
        currScore = initialScore;
        addScorePerSec = 1;
        //每秒呼叫AddScoreAndDisplay()
        InvokeRepeating ("AddScoreAndDisplay", 1f, 1f);
      
    }
    
    void AddScoreAndDisplay()
    {
        //每秒增加分數
        currScore += addScorePerSec;

        //顯示(更變text的文字)
        GetComponent<Text> ().text = "Score:" + currScore.ToString();
    }

}
