using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    private int _hp;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void GetDamage(int damage)
    {
        _hp -= damage;
        if (_hp <= 0)
        {
            print("qWE");
        }
    }
}
