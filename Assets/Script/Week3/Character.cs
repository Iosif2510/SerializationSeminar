using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string name;
    public int hp;

    private void Start()
    {
        StartCoroutine(CutHP());
    }

    private IEnumerator CutHP()
    {
        while (hp > 0)
        {
            yield return new WaitForSeconds(1f);
            hp -= 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 10 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-10 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(10 * Time.deltaTime, 0, 0);
        }
    }
}
