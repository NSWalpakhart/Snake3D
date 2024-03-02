using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeMovementController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    private List<GameObject> tails=new List<GameObject>();
    [SerializeField] private GameObject _tailObject;
    public Text ScoreText;
    private int _score=0;
    Joystick _joystick;
    private Vector3 direction = Vector3.forward;
    private void Start()
    {
        Application.targetFrameRate = 144;
        tails.Add(gameObject);
    }
    void Update()
    {
        ScoreText.text = _score.ToString();
        MoveHead();
        LeftTouchMove();
        RightTouchMove();
    }
    /*#if UNITY_STANDALONE
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
            float angle = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
            transform.Rotate(0, angle, 0);
    #endif*/
    // Начальное направление (вперед)

    private void MoveHead()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        float angle = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        transform.Rotate(0, angle, 0);
    }

    public void LeftTouchMove()
    {
        float angle = -1 * _rotationSpeed*10 * Time.deltaTime;
        transform.Rotate(0, angle, 0);
    }

    public void RightTouchMove()
    {
        float angle = 1 * _rotationSpeed*10 * Time.deltaTime;
        transform.Rotate(0, angle, 0);
    }

    public float GetSpeed()
    {
        return _speed;
    }

    public List<GameObject> Tails
    {
        get
        {
            return tails;
        }
    }
    public void AddTailPart()
    {
        _score++;
        _speed += 0.1f;
        Vector3 newPartTailPos = tails[tails.Count - 1].transform.position;
        tails.Add(GameObject.Instantiate(_tailObject, newPartTailPos, Quaternion.identity));
    }

}
