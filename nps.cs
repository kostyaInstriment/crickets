using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nps : MonoBehaviour
{

    public int health = 1;

    public int level = 1;

    public float speed = 1.2f;

    Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }

}
