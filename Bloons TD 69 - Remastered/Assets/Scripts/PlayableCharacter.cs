using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter
{
    public Projectile _projectile;


    private float _speed;

    public float Speed
    {
        get
        {
            return _speed;
        }

        set
        {
            _speed = value;
        }
    }

    private float _attackSpeed;

    public float AttackSpeed
    {
        get
        {
            return _attackSpeed;
        }

        set
        {
            _attackSpeed = value;
        }
    }

    public PlayableCharacter(Projectile projectile ,float speed, float attackSpeed)
    {
        _projectile = projectile;
        Speed = speed;
        AttackSpeed = attackSpeed;

    }




}
