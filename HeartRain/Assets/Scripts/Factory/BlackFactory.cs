using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackFactory : Factory
{
    [SerializeField] private BlackCircle blackcircle_Prefab;
    public override IShape CreateShape(Vector2 pos)
    {
        GameObject blackcircle_Instance = Instantiate(blackcircle_Prefab.gameObject, pos, Quaternion.identity);
        BlackCircle newBlackCircle = blackcircle_Instance.GetComponent<BlackCircle>();

        newBlackCircle.Initialize();

        return newBlackCircle;
    }
}
