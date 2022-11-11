using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMainSystem : MonoBehaviour
{
    public Unit Player;
    public UnitEnemy Enemy;
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

    void ViewResult()//���U���g��ʂ̕\����ON
    {
        ResultPanel.SetActive(true);
    }

    void ViewGameOver() //�Q�[���I�[�o�[��ʂ̕\����ON
    {
        GameOverPanel.SetActive(true);
    }
    


    void Update()
    {
        if (Unit.Playerhp == 0 ) //player��HP��0�Ȃ�Q�[���I�[�o�[��ʂ�\��
        {
            IsGameOver = true;
        }

        if (IsGameOver)
        {
            ViewGameOver();
            return;
        }

        if (UnitEnemy.Enemyhp == 0) //�G��HP��0�Ȃ��V��ʂ�\��
        {
            IsWin = true;
        }
        if (IsWin)
        {
            ViewResult();
            return;
        }


        /*if (!IsPlayerTurn) //player�̍U����A1�b���enemy�̍U��
        {
            second += Time.deltaTime;
            if (second >= 1f)
            {
                second = 0;
                IsPlayerTurn = true;
                player.OnDamage(enemy.at);
            }
            
        }*/

        if (!IsPlayerTurn) //player�̍U����A1�b���enemy�̍U��
{
            second += Time.deltaTime;
            if (second >= 1f)
            {
                second = 0;
                Enemy.EnemyAttack();
                IsPlayerTurn = true;
            }

}
    }

    public void PushAttackButton() //�U���{�^�����������瑊��Ƀ_���[�W
    {
        if (IsPlayerTurn)
        {
            Player.PlayerAttack();
            IsPlayerTurn = false;
        }
    }
}
