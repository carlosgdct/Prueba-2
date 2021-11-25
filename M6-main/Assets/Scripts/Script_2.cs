using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_2 : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float FactorDeEscalamiento;
    public int numCubos = 0;

    void Awake()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNum" + numCubos;
        Color a = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = a;

        //tempGameObject.transform.position = Random.insideUnitSphere;

        //listaDeCubos.Add(gameObject);
        //List<GameObject> objetosAEliminar = new List<GameObject>();
        //foreach (GameObject go in listaDeCubos)
        //{
        //    float scale = go.transform.localScale.x;
        //    scale *= FactorDeEscalamiento;
        //    go.transform.localScale = Vector3.one * scale;

        //    if (scale <= 0.1)
        //    {
        //        objetosAEliminar.Add(go);
        //    }
        //}

        //foreach (GameObject go in objetosAEliminar)
        //{
        //    listaDeCubos.Remove(go);
        //    Destroy(go);
        //}
    }
    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
