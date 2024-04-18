using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedFactory : Factory
{
    [SerializeField] private RedCircle redcircle_Prefab;
    public override IShape CreateShape(Vector2 pos)
    {
        GameObject redcircle_Instance = Instantiate(redcircle_Prefab.gameObject, pos, Quaternion.identity);
        RedCircle newRedCircle = redcircle_Instance.GetComponent<RedCircle>();

        newRedCircle.Initialize();

        return newRedCircle;
    }
}
