using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartFactory : Factory
{
    [SerializeField] private Heart heart_Prefab;
    public override IShape CreateShape(Vector2 pos)
    {
        GameObject heart_Instance = Instantiate(heart_Prefab.gameObject, pos, Quaternion.identity);
        Heart newHeart = heart_Instance.GetComponent<Heart>();

        newHeart.Initialize();

        return newHeart;
    }
}
