using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeInstance : MonoBehaviour
{
    public float life = 5;
    public Rigidbody rb;

    float _elapsedLife = 0;


    void OnEnable()
    {
        _elapsedLife = 0;
        rb.velocity = Vector3.up * 2;
    }


    // Update is called once per frame
    void Update()
    {
        _elapsedLife = AddLife ();



        if (_elapsedLife > life)
        {
            Debug.Log(GetRandomCompliment ());



            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.SetActive(false);

            //Destroy(gameObject);
        }
    }


    float AddLife ()
    {
        _elapsedLife += Time.deltaTime;

        return _elapsedLife;
    }


    string GetRandomCompliment ()
    {
        string compliment = "";
        float randomNum = Random.value;

        if (randomNum < 0.1f)
        {
            compliment = "You look nice!";
        }
        else if (randomNum < 0.2f)
        {
            compliment = "Good Work!";
        }
        else if (randomNum < 0.3f)
        {
            compliment = "Nice shoes!";
        }

        return compliment;
    }
}
