using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private int _id;
    private string _username;

    private SpriteRenderer _model;

    private float _maxHealth = 100f;
    private float _curHealth;

    public void Initialize(int _id, string _username)
    {
        this._id = _id;
        this._username = _username;
        _curHealth = _maxHealth;
    }

    public void SetHealth(float _health)
    {
        _curHealth = _health;

        if (_curHealth <= 0f)
        {
            Die();
        }
    }

    public void Die()
    {
        _model.enabled = false;
    }

    public void Respawn()
    {
        _model.enabled = true;
        SetHealth(_maxHealth);
    }
}
