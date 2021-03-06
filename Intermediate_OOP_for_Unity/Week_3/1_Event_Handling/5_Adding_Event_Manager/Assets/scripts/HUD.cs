﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour {
    // score support
    Text scoreText;
    int score = 0;
    const string ScorePrefix = "Score: ";

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start() {
        // initialize score text
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        scoreText.text = ScorePrefix + score;

        // add self as event listener
        EventManager.AddListener(AddPoints);
        // add listener for points added event
        //Fish fishScript = GameObject.FindGameObjectWithTag("Fish").GetComponent<Fish>();
        //fishScript.AddPointsAddedEventListener(AddPoints);
    }

    /// <summary>
    /// Updates the score
    /// </summary>
    /// <param name="points">points to add</param>
    public void AddPoints(int points) {
        score += points;
        scoreText.text = ScorePrefix + score;
    }
}
