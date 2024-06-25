using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptbuenisimo : MonoBehaviour
{
    public int cant = 0;
    public int i = 0;

    public bool autoGenerate;
    public float freq;

    public GameObject[] Prefabs;

    public int Random_Number;


    // Start is called before the first frame update
    void Start()
    {
        if (autoGenerate)
        {
            InvokeRepeating(nameof(Clone), 0, freq);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        cant++;
    }
    public void Clone()
    {
        if (i > cant)
        {
            Random_Number = Random.Range(0, Prefabs.Length);

            Instantiate(Prefabs[Random_Number], new Vector3(Random.Range(-140, 450), 260, 400), Prefabs[Random_Number].transform.rotation);
            i++;
        }
    }
}
