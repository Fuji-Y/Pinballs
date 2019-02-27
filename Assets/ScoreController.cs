using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    Material myMaterial;
    public int score = 0;

    //スコアを表示するテキスト
    private GameObject scoretext;
    // Start is called before the first frame update
    void Start()
    {
        //シーン中のScoreControllerオブジェクトの取得
        this.scoretext = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update()
    {
        this.scoretext.GetComponent<Text>().text = score + "点";
    }
}
