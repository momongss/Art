using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    private void Awake()
    {
        for (int i = 1; i < 100; i++)
        {
            Material yourMaterial = (Material)Resources.Load($"Mats/M {i}", typeof(Material));
            print(yourMaterial);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 30; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = new Vector3(x - 15, y - 3, Random.Range(-1f, 1f));

                Material material = cube.GetComponent<Renderer>().material;
                material.EnableKeyword("_EMISSION");
                material.color = Random.ColorHSV(0.99f, 1f, 0.1f, 0.7f, 1f, 1f);

                float emission = Random.Range(0, 3);
                float e_intenVar = 1f;
                if (emission < 1) e_intenVar = 1f;
                else if (emission < 2) e_intenVar = 2f;
                else e_intenVar = 3f;
                material.SetColor("_EmissionColor", Random.ColorHSV(0.99f, 1f, 0.1f, 0.8f, 1f, 1f) * Random.Range(0f, 2f) * e_intenVar);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
