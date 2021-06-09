using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "MonkeyInfo", menuName = "Monkey Information", order = 0)]
public class MonkeyInformation : ScriptableObject
{

    [SerializeField] private string _name;
    [TextArea][SerializeField] private string _description;
    [SerializeField] private int _cost;
    [SerializeField] private int _attackSpeed;

    public string Name => _name;

    public string Description => _description;

    public int Cost => _cost;

    public int AttackSpeed => _attackSpeed;



}
