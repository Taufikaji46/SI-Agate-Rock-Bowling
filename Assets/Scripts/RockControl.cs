using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockControl : MonoBehaviour
{
    //untuk line renderer
    public LineRenderer line;

    //deklarasi kontrol batu
    public Rigidbody rock;
    float xRot, yRot = 0f;
    public float rotationSpeed = 5f;
    public float throwPower = 30f;
    bool isThrowed = false;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = rock.position;
        if (!isThrowed)
        {
            if (Input.GetMouseButton(0))
            {
                //xRot += Input.GetAxis("Mouse Y") * rotationSpeed;
                yRot += Input.GetAxis("Mouse X") * rotationSpeed;

                //lakukan rotasi dengan quaternion (rotasi sumbu x dan y)
                transform.rotation = Quaternion.Euler(0f, yRot, 0f);
                
                //setting line renderer untuk helper arah
                line.gameObject.SetActive(true);
                line.SetPosition(0, transform.position);
                line.SetPosition(1, transform.position + transform.forward * 4f);
            }

            if (Input.GetMouseButtonUp(0))
            {
                rock.velocity = transform.forward * throwPower;
                line.gameObject.SetActive(false);
                isThrowed = true;
            }
        }
       
    }   
}
