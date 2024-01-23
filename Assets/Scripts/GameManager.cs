using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject ball;

    private void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        if (ball != null)
        {
            Instantiate(ball, Vector3.zero, Quaternion.identity);
        }
    }

}
