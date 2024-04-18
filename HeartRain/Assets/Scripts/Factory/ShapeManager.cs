using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [Header("Factories and Points")]
    private GameObject[] dropPoints;
    [SerializeField] private Factory[] factoires;
    private Factory factory;
    private GameObject dropPoint;


    [Header("CountDown")]
    [SerializeField] private float countDown;
    private float _countDown;
    private void Awake()
    {
        _countDown = countDown;
        dropPoints = GameObject.FindGameObjectsWithTag("DropPoint");
    }
    private void Update()
    {
        if (GameManager.Instance.isGameStart)
        {
            if (_countDown <= 0)
            {
                //spawner cod
                factory = factoires[Random.Range(0, factoires.Length)];
                dropPoint = dropPoints[Random.Range(0, dropPoints.Length)];
                factory.CreateShape(dropPoint.transform.position);

                //countDown reset
                _countDown = countDown;
            }
            else
                _countDown -= Time.deltaTime;
        }
    }
}
