using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CubeSpawner : MonoBehaviour
{
    public GameObject [] cubePool;
    public int poolSize = 100;




    public GameObject cubePrefab;
    //public Text cubeCountText;
    //public int cubesPerFrame = 10;

    //int _currentCubeCount = 0;


    // Start is called before the first frame update
    void Start()
    {
        SpawnCubePool();
    }


    void SpawnCubePool ()
    {
        cubePool = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            GameObject thisCube = Instantiate (cubePrefab, transform.position, Quaternion.identity);
            cubePool [i] = thisCube;
            thisCube.SetActive(false);

            thisCube.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }






    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cubePool.Length; i++)
        {
            if (!cubePool [i].activeSelf)
            {
                cubePool[i].SetActive (true);
                cubePool[i].transform.position = transform.position;

                break;
            }
        }
    }
}
