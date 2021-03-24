using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameObject obst;

    private float timer = 1.5f;

    void Update()
    {
        if (timer < 0f)
        {
            timer = 1.5f;
            GameObject a = Instantiate(obst, new Vector3(9.1f, Random.Range(0.1f, 4f), 0f), Quaternion.identity);
            Destroy(a, 5);
        }
        timer -= Time.deltaTime;
    }
}
