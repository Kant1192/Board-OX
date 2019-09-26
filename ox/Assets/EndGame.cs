using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Text Sum, t11,t12,t13,t21,t22,t23,t31,t32,t33,FinishText;
    private string[,] res = new string[3, 3];
    public Button RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.gameObject.SetActive(false); //ボタン隠す
        FinishText.gameObject.SetActive(false); //Textも
    }

    // Update is called once per frame
    void Update()
    {
        res[0, 0] = t11.text;
        res[0, 1] = t12.text;
        res[0, 2] = t13.text;

        res[1, 0] = t21.text;
        res[1, 1] = t22.text;
        res[1, 2] = t23.text;
        

        res[2, 0] = t31.text;
        res[2, 1] = t32.text;
        res[2, 2] = t33.text;
        if (Sum.text == "9")
        {
            FinishText.text = "引き分け";
            //Debug.Log("Check Ok");
            RestartButton.gameObject.SetActive(true); //RestartButtonを表示
            FinishText.gameObject.SetActive(true);
            //Debug.Log(FinishText);
            //FinishText.text = "Finish";
            if (res[0, 0] != "" && res[0, 0] == res[1, 1] && res[1, 1] == res[2, 2])
            {
                if (res[0, 0] == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else if (res[0, 0] == "X")
                {
                    FinishText.text = "後攻の勝ち！";
                }
            }
            else if (res[0, 2] != "" && res[0, 2] == res[1, 1] && res[1, 1] == res[2, 0])
            {
                if (res[0, 2] == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else if (res[0, 2] == "X")
                {
                    FinishText.text = "後攻の勝ち！";
                }
            }
            else 
            {
                for (int i = 0; i < 3; i++)
                {
                    if (res[i,0] != "" && res[i, 0] == res[i, 1] && res[i, 1] == res[i, 2])
                    {
                        if (res[i, 0] == "O")
                        {
                            FinishText.text = "先攻の勝ち！";
                        }
                        else if (res[i, 0] == "X")
                        {
                            FinishText.text = "後攻の勝ち！";
                        }
                        break;
                    }
                    else if (res[0, i] != "" && res[0, i] == res[1, i] && res[1, i] == res[2, i])
                    {
                        if (res[0, i] == "O")
                        {
                            FinishText.text = "先攻の勝ち！";
                        }
                        else if (res[0, i] == "X")
                        {
                            FinishText.text = "後攻の勝ち！";
                        }
                        break;
                    } 
                }
            }
        }
    }
    public void OnclickRestartButton()
    {
        Sum.text = "0";
        SceneManager.LoadScene(0);
        /*
        if (Sum.text == "9")
        {
            t11.text = "";
            t12.text = "";
            t13.text = "";

            t21.text = "";
            t22.text = "";
            t23.text = "";

            t31.text = "";
            t32.text = "";
            t33.text = "";

            Sum.text = "0";
            RestartButton.gameObject.SetActive(false); //ボタン隠す
            FinishText.gameObject.SetActive(false); //

        }
        */
    }
}
