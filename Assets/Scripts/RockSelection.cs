using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RockSelection : MonoBehaviour
{
    public GameObject rock1;
    public GameObject rock2;
    public GameObject rock3;

    //tombol selection
    public KeyCode rockSelect1 = KeyCode.Alpha1;
    public KeyCode rockSelect2 = KeyCode.Alpha2;
    public KeyCode rockSelect3 = KeyCode.Alpha3;

    //which active
    public bool rock1Active = true;
    public bool rock2Active = false;
    public bool rock3Active = false;

    //particle effect
    public GameObject particle_Rock2;

    //constraint agar tidak bisa switch setelah throw
    public RockControl rockControl1;
    public RockControl rockControl2;
    public RockControl rockControl3;
    public bool noSwitch = false;
    public bool forceNoSwitch = false;
    public bool forceNoSwitch1 = false;
    public bool forceNoSwitch2 = false;
    public bool forceNoSwitch3 = false;

    //constraint agar tidak bisa bebas switch
    [Header("Classic Rock")]
    public Image classicRock;
    public float cooldownTime1 = 0f;
    bool isCooldown1 = false;

    [Header("Fire Rock")]
    public Image fireRock;
    public float cooldownTime2 = 3f;
    bool isCooldown2 = false;

    [Header("Bombarda")]
    public Image bombarda;
    public float cooldownTime3 = 10f;
    bool isCooldown3 = false;

    // Start is called before the first frame update
    void Start()
    {
        classicRock.fillAmount = 1;
        fireRock.fillAmount = 1;
        bombarda.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        noSwitch = rockControl1.isThrowed || rockControl2.isThrowed || rockControl3.isThrowed;
        //which active
        if (rock1Active)
        {
            rock2.transform.position = rock1.transform.position;
            rock3.transform.position = rock1.transform.position;
            rock2.transform.rotation = rock1.transform.rotation;
            rock3.transform.rotation = rock1.transform.rotation;
            particle_Rock2.SetActive(false);
        }

        else if (rock2Active)
        {
            rock1.transform.position = rock2.transform.position;
            rock3.transform.position = rock2.transform.position;
            rock1.transform.rotation = rock2.transform.rotation;
            rock3.transform.rotation = rock2.transform.rotation;
            particle_Rock2.SetActive(true);
        }

        else if (rock3Active)
        {
            rock1.transform.position = rock3.transform.position;
            rock2.transform.position = rock3.transform.position;
            rock1.transform.rotation = rock3.transform.rotation;
            rock2.transform.rotation = rock3.transform.rotation;
            particle_Rock2.SetActive(false);
        }
              

        if (!forceNoSwitch)
        {
            forceNoSwitch1 = false;
            forceNoSwitch2 = false;
            forceNoSwitch3 = false;
        }
        
        if (!noSwitch)
        {
            if (Input.GetKey(rockSelect1) && !isCooldown1)
            {
                isCooldown1 = true;
                classicRock.fillAmount = 0;
                if (!forceNoSwitch1)
                {
                    rock1.SetActive(true);
                    rock2.SetActive(false);
                    rock3.SetActive(false);
                    rock1Active = true;
                    rock2Active = false;
                    rock3Active = false;
                }
                
            }
            else if (Input.GetKey(rockSelect2) && !isCooldown2)
            {
                isCooldown2 = true;
                fireRock.fillAmount = 0;
                if (!forceNoSwitch2)
                {
                    rock2.SetActive(true);
                    rock1.SetActive(false);
                    rock3.SetActive(false);
                    rock1Active = false;
                    rock2Active = true;
                    rock3Active = false;
                }
               
            }
            else if (Input.GetKey(rockSelect3) && !isCooldown3)
            {
                isCooldown3 = true;
                bombarda.fillAmount = 0;
                if (!forceNoSwitch3)
                {
                    rock3.SetActive(true);
                    rock1.SetActive(false);
                    rock2.SetActive(false);
                    rock1Active = false;
                    rock2Active = false;
                    rock3Active = true;
                }
                
            }
        }
        if (isCooldown1)
        {
            classicRock.fillAmount += 1 / cooldownTime1 * Time.fixedDeltaTime;
            if (classicRock.fillAmount >= 1)
            {
                classicRock.fillAmount = 1;
                isCooldown1 = false;
            }
        }
        if (isCooldown2)
        {
            fireRock.fillAmount += 1 / cooldownTime2 * Time.fixedDeltaTime;
            if (fireRock.fillAmount >= 1)
            {
                fireRock.fillAmount = 1;
                isCooldown2 = false;
            }
        }
        if (isCooldown3)
        {
            bombarda.fillAmount += 1 / cooldownTime3 * Time.fixedDeltaTime;
            if (bombarda.fillAmount >= 1)
            {
                bombarda.fillAmount = 1;
                isCooldown3 = false;
            }
        }
    }
}
