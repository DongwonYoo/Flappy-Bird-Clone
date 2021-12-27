using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //GameOverのとき現在Score//
        GetComponent<Text>().text = "Score: " + Score.score.ToString();
    }

}
