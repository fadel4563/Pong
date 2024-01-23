using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BallInitialization(0);
    }
    public void BallInitialization(int secondsToWait)
    {
        StartCoroutine(BallInitializationCoroutine(secondsToWait));
    }

    private IEnumerator BallInitializationCoroutine(int secondsToWait)
    {
        yield return new WaitForSeconds(secondsToWait);

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.velocity = new Vector2(speed * x, speed * y);
    }

}
