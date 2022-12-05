using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���C���ƂȂ�퓬�V�X�e��
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
        // ������Ԃ̐ݒ�
        IsPlayerTurn = true;
        IsWin = false;
        IsGameOver = false;
        ResultPanel.SetActive(false);
        GameOverPanel.SetActive(false);

        returnSetActive();
    }

    // �G��|�������ɁA�o���l�����v����
    public void EXP() 
    {
        ALLEXP = int.Parse(PHPEnemyLoad.LoadEnemyEXP) + int.Parse(PHPLoadTest.LoadEXP);
    }

    // ���U���g��ʂ̕\����ON
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

    // �Q�[���I�[�o�[��ʂ̕\����ON
    void ViewGameOver() 
    {
        GameOverPanel.SetActive(true);

        ENEMYPanel.SetActive(false);
        PlayerUIPanel.SetActive(false);
        EnemyUIPanel.SetActive(false);
        Button.SetActive(false);
        Button2.SetActive(false);
    }

    // �g���K�[�����ɖ߂�
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
        // Player��HP��0�Ȃ�Q�[���I�[�o�[��ʂ�\��
        if (Unit.Playerhp == 0 ) 
        {
            IsGameOver = true;
        }

        if (IsGameOver)
        {
            ViewGameOver();
            return;
        }

        // �G��HP��0�Ȃ��V��ʂ�\��
        if (UnitEnemy.Enemyhp == 0)
        {
            IsWin = true;
        }

        if (IsWin)
        {
            ViewResult();
            return;
        }

        // Player�̍U����A1�b���enemy�̍U��
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

    // �U���{�^������������G�Ƀ_���[�W
    public void PushAttackButton()
    {
        if (IsPlayerTurn)
        {
            Player.PlayerAttack();
            IsPlayerTurn = false;
        }
    }
}
