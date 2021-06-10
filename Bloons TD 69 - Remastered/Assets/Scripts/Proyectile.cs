using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Projectile : MonoBehaviour
{
    protected Vector2 _posInicial;
    protected float _speed;
    protected int _dmg;
    protected int _pierce;
    protected bool _isExplosive;
    protected float _aoeRadius;
    //private Effect _effectOnBloon;

    public abstract string Name { get; }

    public abstract void Movement();




}