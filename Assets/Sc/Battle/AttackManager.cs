using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour, IDamage
{
    [SerializeField]
    EnemyStatus[] _enemyStatus;
    [SerializeField]
    PlayerStatus[] _playerStatus;

    int _targetHP = 0;
    int _targetDEF = 0;
    int _addDamage = 0;
    
    public void AddDamage(int addDamage, int targetHP, int targetDEF)
    {
        targetHP -= (addDamage - targetDEF);
        _targetHP = targetHP;
    }

    public void PlayerAttack()
    {
        _targetHP = _enemyStatus[0].EnemyHP;
        _targetDEF = _enemyStatus[0].EnemyDEF;
        _addDamage = _playerStatus[0].PlayerSTR;

        AddDamage(_addDamage, _targetHP, _targetDEF);

        _enemyStatus[0].takehp(_targetHP);
    }

    public void EnemyAttack()
    {
        _targetHP = _playerStatus[0].PlayerHP;
        _targetDEF = _playerStatus[0].PlayerHP;
        _addDamage = _enemyStatus[0].EnemySTR;

        AddDamage(_addDamage, _targetHP, _targetDEF);
    }
}
