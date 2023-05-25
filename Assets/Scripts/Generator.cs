using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Generator : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    [SerializeField] private GameObject _object;

  

   

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
           
            var newCube = Instantiate(_object);
            newCube.transform.position = _transform.position+ new Vector3(Random.Range(-10,10),0,0);
        }
       
    }
}
