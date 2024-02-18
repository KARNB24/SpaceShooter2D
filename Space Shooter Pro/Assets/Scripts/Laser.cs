using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;
    //private bool _isEnemyLaser = false;

    // Update is called once per frame
    void Update()
    {
        //if (_isEnemyLaser == false)
        //{
        //     MoveUp();
        //}
        //else
        //{
        //     MoveDown();
        //}

        MoveUp();
        
    }

    void MoveUp()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y > 8f)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    void MoveDown()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);

        if (transform.position.y < -8f)
        {
            if (transform.parent != null)
            {
                Destroy(transform.parent.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    //public void AssignEnemyLaser()
    //{
    //    _isEnemyLaser = true;
    //}
}
