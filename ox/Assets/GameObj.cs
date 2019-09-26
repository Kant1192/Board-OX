using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameObj : MonoBehaviour
{
    // Start is called before the first frame update

    //public Button[,] buttons = new Button[3,3];
    public Text[,] texts = new Text[3,3];
    private bool[,] AlreadyTouched = new bool[3,3];

    //private int score = 0;
   
    private int[,] num = new int[3, 3];
    public Text Sum;
    public Button RestartButton;
    public Text FinishText,t11,t12,t13,t21,t22,t23,t31,t32,t33;


    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                num[i, j] = 0;
                AlreadyTouched[i, j] = false;
                //texts[i, j] = buttons[i, j].GetComponentInChildren<Text>();
            }
        }
        //Sum.text = "0";
        //RestartButton.gameObject.SetActive(false); //RestartButtonを表示
        //FinishText.gameObject.SetActive(false);
    }
    private void FinishBool()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                AlreadyTouched[i, j] = true;
            }
        }
    }

    //num[] = 1 -> 丸, num[] = 2 -> X, num[] = 0 -> transparent;
    public void Onclick11()
    {
        Text t = this.GetComponent<Text>();
        int cnt = int.Parse(Sum.text);
        if (!AlreadyTouched[0,0] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t11.text = "O";
                num[0,0] = 1;
            } else
            {
                t11.text = "X";
                num[0,0] = 2;
            }
            cnt += 1;
            Sum.text = cnt.ToString();
            //cnt += 1;
            //Debug.Log(cnt);
            AlreadyTouched[0, 0] = true;
            if ((t11.text != "" && t11.text == t12.text && t12.text == t13.text) || (t11.text != "" && t11.text == t21.text && t11.text == t31.text) || (t11.text != ""  && t11.text == t22.text && t22.text == t33.text))
            {
                if (t11.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                } else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
           
        }
    }

    public void Onclick12()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[0, 1] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t12.text = "O";
                num[0,1] = 1;
            }
            else
            {
                t12.text = "X";
                num[0,1] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[0, 1] = true;
            if ((t12.text != "" && t12.text == t22.text && t22.text == t32.text) || (t12.text != "" && t12.text == t11.text && t11.text == t13.text))
            {
                if (t12.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick13()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[0, 2] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t13.text = "O";
                num[0,2] = 1;
            }
            else
            {
                t13.text = "X";
                num[0,2] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[0, 2] = true;
            if ((t13.text != "" && t13.text == t12.text && t13.text == t11.text) || (t13.text != "" && t13.text == t23.text && t13.text == t33.text) || (t13.text != "" && t13.text == t22.text && t13.text == t31.text))
            {
                if (t13.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick21()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[1, 0] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t21.text = "O";
                num[1,0] = 1;
            }
            else
            {
                t21.text = "X";
                num[1,0] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[1, 0] = true;
            if ((t21.text != "" && t21.text == t22.text && t22.text == t23.text) || (t21.text != ""&& t21.text == t11.text && t11.text == t31.text))
            {
                if (t21.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick22()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[1, 1] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t22.text = "O";
                num[1,1] = 1;
            }
            else
            {
                t22.text = "X";
                num[1,1] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[1, 1] = true;
            if ((t22.text != "" && t22.text == t12.text && t12.text == t32.text) || (t22.text != "" && t22.text == t21.text && t21.text == t23.text) || (t22.text == "" && t22.text == t11.text && t22.text == t33.text) || (t22.text != "" && t31.text == t22.text && t22.text == t13.text))
            {
                if (t22.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick23()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[1, 2] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t23.text = "O";
                num[1,2] = 1;
            }
            else
            {
                t23.text = "X";
                num[1,2] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[1, 2] = true;
            if ((t23.text != "" && t23.text == t21.text && t23.text == t22.text) || (t23.text != "" && t13.text == t23.text && t23.text == t33.text))
            {
                if (t23.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick31()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[2, 0] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t31.text = "O";
                num[2,0] = 1;
            }
            else
            {
                t31.text = "X";
                num[2,0] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[2, 0] = true;
            if ((t31.text != "" && t31.text == t32.text && t32.text == t33.text) || (t31.text != "" && t31.text == t21.text && t31.text == t11.text) || (t31.text != "" && t22.text == t31.text && t31.text == t13.text))
            {
                if (t31.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick32()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[2, 1] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t32.text = "O";
                num[2,1] = 1;
            }
            else
            {
                t32.text = "X";
                num[2,1] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[2, 1] = true;
            if ((t32.text != "" && t32.text == t12.text && t12.text == t22.text) || (t32.text != "" && t32.text == t31.text && t33.text == t31.text))
            {
                if (t32.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void Onclick33()
    {
        Text t = this.GetComponent<Text>();
        int cnt = Convert.ToInt32(Sum.text);
        if (!AlreadyTouched[2, 2] && Sum.text != "9")
        {
            if (cnt % 2 == 0)
            {
                t33.text = "O";
                num[2, 2] = 1;
            }
            else
            {
                t33.text = "X";
                num[2,2] = 2;
            }
            cnt++;
            Sum.text = cnt.ToString();
            //Debug.Log(cnt);
            AlreadyTouched[2, 2] = true;
            if ((t33.text != "" && t33.text == t31.text && t31.text == t32.text) || (t33.text != "" && t33.text == t23.text && t23.text == t13.text) || (t33.text != "" && t11.text == t33.text && t33.text == t22.text))
            {
                if (t33.text == "O")
                {
                    FinishText.text = "先攻の勝ち！";
                }
                else
                {
                    FinishText.text = "後攻の勝ち！";
                }
                FinishBool();
                Sum.text = "9";
                RestartButton.gameObject.SetActive(true); //RestartButtonを表示
                FinishText.gameObject.SetActive(true);
            }
        }
    }

    public void OnclickRestartButton()
    {
        Sum.text = "0";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                num[i, j] = 0;
                AlreadyTouched[i, j] = false;
                //texts[i, j] = buttons[i, j].GetComponentInChildren<Text>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
