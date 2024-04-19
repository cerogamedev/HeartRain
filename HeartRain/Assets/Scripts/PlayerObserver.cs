using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerObserver : MonoSingleton<PlayerObserver>
{
    public static Action HeartHere;
    public static Action CircleHere;


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Heart"))
        {
            HeartHere?.Invoke();
            Debug.Log("HeartHere!");
            AudioManager.Instance.HeartPlaySound();
            Destroy(collision);
        }
        if (collision.transform.CompareTag("BadBall"))
        {
            Debug.Log("CircleHere!");

            CircleHere?.Invoke();
            Destroy(collision);

        }
    }
}
