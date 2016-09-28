using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
    public Transform target;
    private Vector3 offset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
        target.Rotate(this.transform.eulerAngles);
    }
}
