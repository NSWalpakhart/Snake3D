using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour
{
    [SerializeField] private GameObject foodObject;
    [SerializeField] private float widthSize = 12.14f;
    [SerializeField] private float heightSize = 12.14f;
    private GameObject curFood;
    private Vector3 curPos;
    void Start()
    {
       GenerateFood();
    }

    public void GenerateFood()
    {
        randomFoodPos();
        curFood = Instantiate(foodObject, curPos, Quaternion.identity);
    }

    private void randomFoodPos()
    {
        curPos = new Vector3(Random.Range(widthSize * -1, widthSize), 1.1f, Random.Range(heightSize * -1, heightSize));
    }

    private void Update()
    {
        if (!curFood)
            GenerateFood();
        else return;
    }
}
