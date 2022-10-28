using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMainSystem : MonoBehaviour
{
    public Unit player;
    public Unit enemy;
    public GameObject ResultPanel;
    public GameObject GameOverPanel;

    bool IsPlayerTurn;
    bool IsGameOver;
    bool IsWin;
    float second = 0f;

    // Start is called before the first frame update
    void Start()
    {
        IsPlayerTurn = true;
        IsWin = false;
        IsGameOver = false;
        ResultPanel.SetActive(false);
        GameOverPanel.SetActive(false);

    }

    void ViewResult()//リザルト画面の表示をON
    {
        ResultPanel.SetActive(true);
    }

    void ViewGameOver() //ゲームオーバー画面の表示をON
    {
        GameOverPanel.SetActive(true);
    }
    


    void Update()
    {
        if (player.hp == 0 ) //playerのHPが0ならゲームオーバー画面を表示
        {
            IsGameOver = true;
        }

        if (IsGameOver)
        {
            ViewGameOver();
            return;
        }

        if (enemy.hp == 0) //敵のHPが0なら報酬画面を表示
        {
            IsWin = true;
        }
        if (IsWin)
        {
            ViewResult();
            return;
        }


        if (!IsPlayerTurn) //playerの攻撃後、1秒後にenemyの攻撃
        {
            second += Time.deltaTime;
            if (second >= 0.5f)
            {
                second = 0;
                IsPlayerTurn = true;
                player.OnDamage(enemy.at);
            }
            
        }
    }

    public void PushAttackButton() //攻撃ボタンを押したら相手にダメージ
    {
        if (IsPlayerTurn)
        {
            enemy.OnDamage(player.at);
            IsPlayerTurn = false;
        }
    }
}
