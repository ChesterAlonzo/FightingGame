using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random=UnityEngine.Random;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{   
    public int p1hp = 100;
    public HealthBar healthbar;
    void Start()
    {
        healthbar.SetMaxHealth(p1hp);
    }
    void Update()
    {
        
    }
 
    void dealDamage( int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            SceneManager.LoadScene ("LP 2");
        }
        else    
        {   
            p1hp = currenthp -= 0;
            SceneManager.LoadScene ("LP 2 MISSED");
        }
    }
    
    void dealDamage2( int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            SceneManager.LoadScene ("HP 2");
        }
        else    
        {   
            p1hp = currenthp -= 0;
            SceneManager.LoadScene ("HP 2 MISSED");
        }
    }
    
    void dealDamage3( int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            SceneManager.LoadScene ("LK 2");
        }
        else    
        {   
            p1hp = currenthp -= 0;
            SceneManager.LoadScene ("LK 2 MISSED");
        }
    }
    
    void dealDamage4( int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            SceneManager.LoadScene ("HK 2");
        }
        else    
        {   
            p1hp = currenthp -= 0;
            SceneManager.LoadScene ("HK 2 MISSED");
        }
    }
    
    void dealDamage5( int currenthp, int damageAmount, float accuracy)
    {
        int ran = Random.Range(0,101);
        if (ran <= accuracy)
        {
            p1hp = currenthp -= damageAmount;
            SceneManager.LoadScene ("SPECIAL 2");
        }
        else    
        {   
            p1hp = currenthp -= 0;
            SceneManager.LoadScene ("SPECIAL 2");
        }
    }

    public void P2LowPunch()
    {    
        dealDamage(p1hp,3,75);
        healthbar.SetHealth(p1hp);
    }
    
    public void P2HighPunch()
    {    
        dealDamage2(p1hp,8,55);
        healthbar.SetHealth(p1hp);
    }
    
        public void P2LowKick()
    {    
        dealDamage3(p1hp,6,65);
        healthbar.SetHealth(p1hp);
    }    
    public void P2HighKick()
    {    
        dealDamage4(p1hp,12,45);
        healthbar.SetHealth(p1hp);
    }    
    public void P2Special()
    {
        dealDamage5(p1hp,25,100);
        healthbar.SetHealth(p1hp);
    }

}
