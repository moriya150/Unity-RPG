using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// メインとなる戦闘システム
public class BattleMainSystem : MonoBehaviour
{
    public Unit Player;
    public UnitEnemy Enemy;

    public static int ALLEXP = 0;

    public GameObject ResultPanel;
    public GameObject GameOverPanel;

    public GameObject ENEMYPanel;
    public GameObject Button;
    public GameObject Button2;
    public GameObject PlayerUIPanel;
    public GameObject EnemyUIPanel;

    bool IsPlayerTurn;
    bool IsGameOver;
    bool IsWin;
    float second = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // 初期状態の設定
        IsPlayerTurn = true;
        IsWin = false;
        IsGameOver = false;
        ResultPanel.SetActive(false);
        GameOverPanel.SetActive(false);

        returnSetActive();
    }

    // 敵を倒した時に、経験値を合計する
    public void EXP() 
    {
        ALLEXP = int.Parse(PHPEnemyLoad.LoadEnemyEXP) + int.Parse(PHPLoadTest.LoadEXP);
    }

    // リザルト画面の表示をON
    void ViewResult()
    {
        ResultPanel.SetActive(true);

        EXP();

        ENEMYPanel.SetActive(false);
        PlayerUIPanel.SetActive(false);
        EnemyUIPanel.SetActive(false);
        Button.SetActive(false);
        Button2.SetActive(false);
    }

    // ゲームオーバー画面の表示をON
    void ViewGameOver() 
    {
        GameOverPanel.SetActive(true);

        ENEMYPanel.SetActive(false);
        PlayerUIPanel.SetActive(false);
        EnemyUIPanel.SetActive(false);
        Button.SetActive(false);
        Button2.SetActive(false);
    }

    // トリガーを元に戻す
    public void returnSetActive() 
    {
        IsWin = false;
        IsGameOver = false;
        IsPlayerTurn = true;
        
        ResultPanel.SetActive(false);
        GameOverPanel.SetActive(false);
    }

    void Update()
    {
        // PlayerのHPが0ならゲームオーバー画面を表示
        if (Unit.Playerhp == 0 ) 
        {
            IsGameOver = true;
        }

        if (IsGameOver)
        {
            ViewGameOver();
            return;
        }

        // 敵のHPが0なら報酬画面を表示
        if (UnitEnemy.Enemyhp == 0)
        {
            IsWin = true;
        }

        if (IsWin)
        {
            ViewResult();
            return;
        }

        // Playerの攻撃後、1秒後にenemyの攻撃
        if (!IsPlayerTurn)
        {
            second += Time.deltaTime;
            if (second >= 1f)
            {
                second = 0;
                IsPlayerTurn = true;
                Enemy.EnemyAttack();
                
            }
        }
    }

    // 攻撃ボタンを押したら敵にダメージ
    public void PushAttackButton()
    {
        if (IsPlayerTurn)
        {
            Player.PlayerAttack();
            IsPlayerTurn = false;
        }
    }
}
