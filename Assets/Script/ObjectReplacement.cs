using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReplacement : MonoBehaviour
{
    private int _numFound;
    private Vector3 OSOffset;
    private readonly Collider[] _colliders = new Collider[3];

    void Awake()
    {
        OSOffset.x = 0;
        OSOffset.y = 0.05f;
        OSOffset.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(this.transform.position + OSOffset, 0.1f, _colliders);
        if (_numFound > 0)
        {
            for (int i = 0; i < _numFound; i++)
            {
                if (_colliders[i].gameObject.tag == "Rampe")
                {
                    //Debug.Log("Object entered: " + _colliders[i].gameObject.name);
                    _colliders[i].gameObject.transform.position = this.transform.position - OSOffset;
                    _colliders[i].gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position + OSOffset, 0.1f);
    }
}
