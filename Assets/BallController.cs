using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    public GameObject scoreController;
    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }
    void OnCollisionEnter(Collision other) //衝突時に呼ばれる関数
    {
        if (other.gameObject.tag == "SmallStarTag")
        {
            scoreController.GetComponent<ScoreController>().score += 5;
        }
        else if (other.gameObject.tag == "LargeStarTag")
        {
            scoreController.GetComponent<ScoreController>().score += 10;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
            scoreController.GetComponent<ScoreController>().score += 15;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            scoreController.GetComponent<ScoreController>().score += 20;
        }
        scoreController.GetComponent<Text>().text = scoreController.GetComponent<ScoreController>().score.ToString();
    } 
}

