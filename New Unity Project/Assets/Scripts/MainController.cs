﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameObject obst;

    private float timer = 0.8f;

    void Update()
    {
        if (timer <= 0f && !PlayerController.isDead)
        {
            timer = 1.5f;
            GameObject a = Instantiate(obst, new Vector3(9.1f, Random.Range(0.1f, 4f), 0f), Quaternion.identity);
            StartCoroutine(dest(a));
        }
        timer -= Time.deltaTime;
    }

    private  IEnumerator dest(GameObject a)
    {
        yield return new WaitForSeconds(5f);

        if(!PlayerController.isDead)
            Destroy(a);
    }
}
