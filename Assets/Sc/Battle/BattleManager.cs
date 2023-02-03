using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    [SerializeField, Tooltip("次のコマンドに行くときに切り替えるUI")]
    GameObject[] _commandUI;

    /// <summary>現在のターン状態を保存する</summary>
    BattalePhase _turnPhase = BattalePhase.SelectPhase;

    private void Start()
    {
        _turnPhase = BattalePhase.SelectPhase;
        PhaseChange();
    }
    void PhaseChange()
    {
        switch (_turnPhase)
        {
            case BattalePhase.SelectPhase:
                Debug.Log("コマンドを選択してください");
                break;
                    
            case BattalePhase.BattlePhase:
                Debug.Log("ターン進行中です");
                break ;

            case BattalePhase.ResulePhaze:
                Debug.Log("敵を倒しました");
                break;
        }
    }

    public void NextCommand()
    {
        _commandUI[0].SetActive(false);
        _commandUI[1].SetActive(true);
    }
    public void Battale()
    {
        _turnPhase = BattalePhase.BattlePhase;
        PhaseChange();
    }

    public void Result()
    {
        _turnPhase = BattalePhase.ResulePhaze;
        PhaseChange();
    }
    public enum BattalePhase
    {
        SelectPhase,
        BattlePhase,
        ResulePhaze
    }
}
