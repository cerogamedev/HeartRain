using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject[] columns;
    private GameObject column;
    private int index = 0;


    void Update()
    {
        column = columns[index];
        this.transform.position = new Vector2(column.transform.position.x, this.transform.position.y);
        if (InputHandler.Instance.GoRight && index < columns.Length - 1)
            index++;
        if (InputHandler.Instance.GoLeft && index >= 1)
            index -= 1;
    }
}
