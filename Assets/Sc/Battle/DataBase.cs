using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase
{
    [Tooltip("レベル")]
    int _level;
    [Tooltip("体力")]
    int _hp;
    [Tooltip("マジックポイント")]
    int _mp;
    [Tooltip("攻撃力")]
    int _str;
    [Tooltip("防御力")]
    int _def;
    [Tooltip("速さ")]
    int _speed;

    public int Level { get => _level; set => _level = value; }
    public int HP { get => _hp; set => _hp = value; }
    public int MP { get => _mp; set => _mp = value; }
    public int STR { get => _str; set => _str = value; }
    public int DEF { get => _def; set => _def = value; }
    public int Speed { get => _speed; set => _speed = value; }
}
