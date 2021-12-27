using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; //変数宣言
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Rigidbody2dというComponentをもってきて　rbに入れる
    }

    // Update is called once per frame
    void Update() //Frameごとに
    {
        if (Input.GetMouseButtonDown(0))//マウスクリックした時(タッチと一緒) 0は左
        {
            rb.velocity = Vector2.up * jumpPower;//(0,jumpPowe) Vector = 2次元座標   x,y 　velocityはRigidbodyのスピードスピード属性 y方に3分力をまらう
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
        
    }
}
