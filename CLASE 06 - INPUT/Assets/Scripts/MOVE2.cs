using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE2 : MonoBehaviour
{
    [SerializeField] Vector3 direction = new Vector3(0, 0, 1);
    [SerializeField] float speed = 60f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        transform.Translate(speed * Time.deltaTime * direction);
    }
}
