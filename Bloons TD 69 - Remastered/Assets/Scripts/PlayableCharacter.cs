using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayableCharacter : MonoBehaviour
{
    public Projectile _projectile;

    private float _speed;

    private Vector2 _projectileSpawningPosition;

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




}
