using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    private enum Operations
    {
        Sum,
        Sub,
        Multi,
        Div,
        Degree
    }

    [SerializeField] private float _number1;
    [SerializeField] private float _number2;
    [SerializeField] private Operations _operations;
    [SerializeField] private bool _calculate = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private string PlusCalculate(float number1, float number2)
    {
        var result = number1 + number2;
        return $"Result addition => {result}";
    }
    private string MinusCalculate(float number1, float number2)
    {
        var result = number1 - number2;
        return $"Result subtraction => {result}";
    }
    private string MultiCalculate(float number1, float number2)
    {
        var result = number1 * number2;
        return $"Result miltiplication => {result}";
    }
    private string DivCalculate(float number1, float number2)
    {
        var result = number1 / number2;
        return $"Result division => {result}";
    }
    private string DegreeCalculate(float number1, float number2)
    {

        if(((int)number2) != number2)
        {
            return "Number 2 must be an integer";
        }
        var result =  number1;
        for(int i = 0; i < number2; i++)
        {
            result *= number1;
        }
        return $"Result degree => {result}";
    }

    // Update is called once per frame
    void Update()
    {
        if (_calculate)
        {
            switch (_operations)
            {
                case Operations.Multi:
                    Debug.Log(MultiCalculate(_number1, _number2));
                    break;
                case Operations.Sum:
                    Debug.Log(PlusCalculate(_number1, _number2));
                    break;
                case Operations.Sub:
                    Debug.Log(MinusCalculate(_number1, _number2));
                    break;
                case Operations.Div:
                    Debug.Log(DivCalculate(_number1, _number2));
                    break;
                case Operations.Degree:
                    Debug.Log(DegreeCalculate(_number1, _number2));
                    break;
            }
            _calculate = false;
        }
    }
}
