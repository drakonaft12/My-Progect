using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculate : MonoBehaviour
{
    [SerializeField] private float _number1;
    [SerializeField] private float _number2;
    [SerializeField] private bool _plus;
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

    // Update is called once per frame
    void Update()
    {
        if (_calculate)
        {
            if (_plus)
            {
                Debug.Log(PlusCalculate(_number1, _number2));
            }
            else
            {
                Debug.Log(MinusCalculate(_number1, _number2));
            }
            _calculate = false;
        }
    }
}
