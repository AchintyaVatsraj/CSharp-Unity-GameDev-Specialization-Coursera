﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	[SerializeField]
	float minImpulseForce;
    [SerializeField]
    float maxImpulseForce;

    // death support
    const float TeddyBearLifespanSeconds = 10;
	Timer deathTimer;

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // apply impulse force to get teddy bear moving
        float angle = Random.Range(0, 2 * Mathf.PI);
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(minImpulseForce, maxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude,
            ForceMode2D.Impulse);

        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
		deathTimer.Duration = TeddyBearLifespanSeconds;
		deathTimer.Run();
	}

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// kill teddy bear if death timer finished
		if (deathTimer.Finished)
        {
			Destroy(gameObject);
		}
	}
}