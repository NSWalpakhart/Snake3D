using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovementController : MonoBehaviour
{
    SnakeMovementController _snakeHead;
    private float _speed;
    private int _index;
    private Vector3 _tailTarget;
    private GameObject _tailTargetObject;

    private void Start()
    {
        _snakeHead = GameObject.FindGameObjectWithTag("SnakeHead").GetComponent<SnakeMovementController>();
        _speed=_snakeHead.GetSpeed();
        _tailTargetObject = _snakeHead.Tails[_snakeHead.Tails.Count - 2];
        
    }

    private void Update() {
        _tailTarget=_tailTargetObject.transform.position;
       transform.LookAt( _tailTarget );
       transform.position = Vector3.Lerp(transform.position,_tailTarget,Time.deltaTime*_speed);
        _index = _snakeHead.Tails.IndexOf(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead")) {
            if (_index > 2)
                SceneManager.LoadScene("Menu");

        }
    }

}
