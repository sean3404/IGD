using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        Instantiate(redObj,new Vector3(2.0f,0,0), Quaternion.identity);
        Instantiate(blueObj,new Vector3(-2.0f,0,0), Quaternion.identity);
=======
        Instantiate(redObj, new Vector3(2.0f, 0, 0), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2.0f, 0, 0), Quaternion.identity);
>>>>>>> feature-print

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        Debug.Log(transform.position);
=======
      
>>>>>>> feature-print
    }
}
