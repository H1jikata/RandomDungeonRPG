using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObeject/EnemyData")]
public class EnemyData : ScriptableObject
{
    [SerializeField, Header("名前")]
    string _name = default;
    [SerializeField, Header("レベル")]
    int _exp = default;
    [SerializeField, Header("HP")]
    int _hp = default;
    [SerializeField, Header("MP")]
    int _mp = default;
    [SerializeField, Header("攻撃力")]
    int _str = default;
    [SerializeField, Header("防御力")]
    int _def = default;
}
