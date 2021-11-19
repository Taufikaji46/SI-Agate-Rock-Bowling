using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    bool rock1Active = true;
    bool rock2Active = false;
    bool rock3Active = false;

    //constraint agar tidak bisa switch setelah throw
    public RockControl rockControl1;
    public RockControl rockControl2;
    public RockControl rockControl3;
    bool noSwitch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        noSwitch = rockControl1.isThrowed || rockControl2.isThrowed || rockControl3.isThrowed;
        if (!noSwitch)
        {
            if (Input.GetKey(rockSelect1))
            {
                rock1.SetActive(true);
                rock2.SetActive(false);
                rock3.SetActive(false);
                rock1Active = true;
                rock2Active = false;
                rock3Active = false;
            }
            else if (Input.GetKey(rockSelect2))
            {
                rock2.SetActive(true);
                rock1.SetActive(false);
                rock3.SetActive(false);
                rock1Active = false;
                rock2Active = true;
                rock3Active = false;
            }
            else if (Input.GetKey(rockSelect3))
            {
                rock3.SetActive(true);
                rock1.SetActive(false);
                rock2.SetActive(false);
                rock1Active = false;
                rock2Active = false;
                rock3Active = true;
            }

            //which active
            if (rock1Active)
            {
                rock2.transform.position = rock1.transform.position;
                rock3.transform.position = rock1.transform.position;
            }

            else if (rock2Active)
            {
                rock1.transform.position = rock2.transform.position;
                rock3.transform.position = rock2.transform.position;
            }

            else if (rock3Active)
            {
                rock1.transform.position = rock3.transform.position;
                rock2.transform.position = rock3.transform.position;
            }
        }
        
    }
}
