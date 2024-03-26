using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienManager : MonoBehaviour
{
    public GameObject alien;
    private Vector3 startPosition;
    [SerializeField] float moveValue;
    [SerializeField] float rotateValue;
    [SerializeField] Vector3 sizeChange;
   
    void Start()
    {
        startPosition = new Vector3(alien.transform.position.x, alien.transform.position.y, alien.transform.position.z);
    }

    public void MoveLeft()
    {
        alien.transform.position = new Vector3(alien.transform.position.x - moveValue, alien.transform.position.y, alien.transform.position.z);
    }

    public void MoveRight()
    {
        alien.transform.position = new Vector3(alien.transform.position.x + moveValue, alien.transform.position.y, alien.transform.position.z);
    }

    public void RotateLeft()
    {
        alien.transform.Rotate(0, rotateValue, 0);
    }

    public void RotateRight()
    {
        alien.transform.Rotate(0, -rotateValue, 0);
    }

    public void Shrink()
    {
        alien.transform.localScale = alien.transform.localScale - sizeChange;
    }

    public void Grow()
    {
        alien.transform.localScale = alien.transform.localScale + sizeChange;
    }

    public void Reset()
    {
        alien.transform.position = startPosition;
        alien.transform.rotation = Quaternion.identity;
        alien.transform.localScale = Vector3.one;
    }
}   
