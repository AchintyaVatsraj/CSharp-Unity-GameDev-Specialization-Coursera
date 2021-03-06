﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour {
    [SerializeField]
    GameObject prefabExplosion;

    int damage = 100;

    /// <summary>
    /// Gets the damage inflicted by the fish
    /// </summary>
    /// <value>damage</value>
    public int Damage {
        get { return damage; }
    }

    /// <summary>
    /// Fires fish when clicked on its collider
    /// </summary>
    private void OnMouseUpAsButton() {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0, 25), ForceMode2D.Impulse);
    }
}
