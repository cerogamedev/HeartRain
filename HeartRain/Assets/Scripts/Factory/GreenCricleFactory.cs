using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCricleFactory : Factory
{
    [SerializeField] private GreenCircle greencircle_Prefab;
    public override IShape CreateShape(Vector2 pos)
    {
        GameObject greencircle_Instance = Instantiate(greencircle_Prefab.gameObject, pos, Quaternion.identity);
        GreenCircle newGreenCircle = greencircle_Instance.GetComponent<GreenCircle>();

        newGreenCircle.Initialize();

        return newGreenCircle;
    }
}
