using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector2(-36.7f, 32);
    }
    void Update()
    {
        transform.Translate(new Vector2(10, 0) * Time.deltaTime);
    }
}
