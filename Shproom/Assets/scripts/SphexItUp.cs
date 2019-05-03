using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphexItUp : MonoBehaviour
{
    public int sizeX, sizeY;
    public GameObject shroom, sphex;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sizeX; i++)
        {
            for (int j = 0; j < sizeY; j++)
            {
                int offset = i % 2;
                
                GameObject go = Instantiate(sphex, new Vector3(i * 0.7f, j * 0.7f + offset * 0.35f, 0), Quaternion.identity);
            }
        }
    }
    // +-0.2, +-0.2, -0.5
    // Update is called once per frame
    void Update()
    {
        
    }
}
