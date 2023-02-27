﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField, Tooltip("ステータスのテキストの名前")]
    string _statusTextName;

    DataBase _enemyDataBase = new DataBase();
    /// <summary>読み込んだテキストを保存しておく変数</summary>
    string _statusData;
    /// <summary>テキストを分割したものを保存する配列</summary>
    string[] _splitStatusupText;
    /// <summary>各ステータスを保存する</summary>
    string[] _statusDatas;
    PlayerStatus _player;
    private void Start()
    {
        _statusData = (Resources.Load(_statusTextName, typeof(TextAsset)) as TextAsset).text;

        _splitStatusupText = _statusData.Split('\n');

        _player = GameObject.Find("Player").GetComponent<PlayerStatus>();
        int _playerLevel = _player.PlayerLevel;
        int random = Random.Range(1, _playerLevel);
        _statusDatas = _splitStatusupText[random].Split(',');
        _enemyDataBase.Level = int.Parse(_statusDatas[0]);
        _enemyDataBase.HP = int.Parse(_statusDatas[1]);
        _enemyDataBase.MP = int.Parse(_statusDatas[2]);
        _enemyDataBase.STR = int.Parse(_statusDatas[3]);
        _enemyDataBase.DEF = int.Parse(_statusDatas[4]);
        _enemyDataBase.Speed = int.Parse(_statusDatas[5]);

        checkStatus();
    }
    /// <summary>現在のステータスを確認する（デバッグ用)</summary>
    void checkStatus()
    {
        Debug.Log("現在のEnemyLevelは" + _enemyDataBase.Level + "です");
        Debug.Log("現在のEnemyのHPは" + _enemyDataBase.HP);
        Debug.Log("現在のEnemyのMPは" + _enemyDataBase.MP);
        Debug.Log("現在のEnemyの力は" + _enemyDataBase.STR);
        Debug.Log("現在のEnemyの防御力は" + _enemyDataBase.DEF);
        Debug.Log("現在のEnemyの素早さは" + _enemyDataBase.Speed);
    }
}
