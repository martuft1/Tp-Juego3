using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scriptbuenisimo : MonoBehaviour
{
    public int cant = 0;
    public float minX;
    public float maxX;
    public bool autoGenerate;
    public float freq;
    public int min = 0;
    public int max = 2;
    public GameObject prefab;
    public Vector3 newPosition;
    public GameObject fuente;

    public GameObject[]
    // Start is called before the first frame update
    void Start()
    {
        if (autoGenerate)
        {
            InvokeRepeating(nameof(Clonefuente), 0, freq);
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
    public void Clonefuente()
    {
        int random = Random.Range(min, max);
        float randomX = Random.Range(minX, maxX);
        newPosition = new Vector3(randomX, newPosition.y, newPosition.z);


        if (random == 1)
        {
            Instantiate(prefab, newPosition, Quaternion.identity);

        }
        else if (random == 0)
        {
            Instantiate(fuente, newPosition, Quaternion.identity);
        }
    }
}
