﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinpickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSFX;
    [SerializeField] int pointsForCoinPickup = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //this passes the integer variable for coins to the script GameSession
        FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickup);

        AudioSource.PlayClipAtPoint(coinPickUpSFX, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
