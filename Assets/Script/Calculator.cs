using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    public Text InputText;
    public string Values;
    private string _temp;
    private bool _isHaveOperator = false;
    public void OnClickButton()
    {
        if((InputText.text.Contains("+") || InputText.text.Contains("-") || InputText.text.Contains("/") ||
            InputText.text.Contains("*") || InputText.text.Contains(".")) && _isHaveOperator)
        {
            InputText.text += "";
            
        }
        else 
        {
            if(Values == "+" && !_isHaveOperator)
            {
                InputText.text += Values;
                _isHaveOperator = true;
            }
            else if (Values == "-" && !_isHaveOperator)
            {
                InputText.text += Values;
                _isHaveOperator = true;
            }
            else if (Values == "*" && !_isHaveOperator)
            {
                InputText.text += Values;
                _isHaveOperator = true;
            }
            else if (Values == "/" && !_isHaveOperator)
            {
                InputText.text += Values;
                _isHaveOperator = true;
            }
            else if (Values == "." && !_isHaveOperator)
            {
                InputText.text += Values;
                _isHaveOperator = true;
            }
            else
            {
                InputText.text += Values;
            }
        } 
    }
    public void ButtonClear()
    { 
        InputText.text = "";
        _isHaveOperator = false;
    }

    public void ButtonEqual()
    {
        DataTable dt = new DataTable();
        _temp = dt.Compute(InputText.text, "").ToString();
        InputText.text = _temp;
        _isHaveOperator = false;
    }

}
