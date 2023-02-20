using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObeject/CharacterData")]
public class CharacterData : ScriptableObject
{
    [SerializeField, Header("レベル")]
    public int[] _level = default;
    [SerializeField, Header("HP")]
    public int[] _hp = default;
    [SerializeField, Header("MP")]
    public int[] _mp = default;
    [SerializeField, Header("攻撃力")]
    public int[] _str = default;
    [SerializeField, Header("防御力")]
    public int[] _def = default;
    [SerializeField, Header("速さ")]
    public int[] _speed = default;
}
