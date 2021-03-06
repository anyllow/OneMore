using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    public Text InputText;
    public string Values;
    private bool _isHasOperator;
    private static bool _isHasFirstPoint;
    private static bool _isHasSecondPoint;

    public void OnClickButton()
    {
        if ((Values == "+" && InputText.text == "") || (Values == "-" && InputText.text == "") || (Values == "*" && InputText.text == "") ||
            (Values == "/" && InputText.text == ""))
        {
            InputText.text += "";
        }

        else if ((InputText.text.Contains("+") || InputText.text.Contains("-") || InputText.text.Contains("*") ||
            InputText.text.Contains("/")) && (Values == "+" || Values == "-" || Values == "*" || Values == "/"))
        {
            InputText.text += "";

        }
        else
        {
            if (!_isHasOperator && (Values == "+" || Values == "-" || Values == "*" || Values == "/"))
            {
                InputText.text += Values;
                _isHasOperator = true;
            }
            else
            {
                InputText.text += Values;
            }
        }
    }
    public void ButtonClickPoint()
    {


        if (InputText.text == "")
        {
            InputText.text += "0.";
            _isHasFirstPoint = true;
        }
        else if (_isHasFirstPoint && _isHasSecondPoint)
        {
            InputText.text += "";

        }
        else if (InputText.text.Contains(",") && !_isHasFirstPoint)
        {
            InputText.text += "";
            _isHasFirstPoint = true;
        }
        else
        {
            if (!_isHasFirstPoint && (InputText.text.Contains("+") || InputText.text.Contains("-") || InputText.text.Contains("*") ||
                InputText.text.Contains("/")))
            {
                InputText.text += "";
                _isHasFirstPoint = true;
            }
            else if (!_isHasFirstPoint && !(InputText.text.Contains("+") || InputText.text.Contains("-") || InputText.text.Contains("*") ||
                InputText.text.Contains("/")))
            {
                InputText.text += ".";
                _isHasFirstPoint = true;
            }
            else if (InputText.text.Contains("+") || InputText.text.Contains("-") || InputText.text.Contains("*") ||
                InputText.text.Contains("/") && _isHasFirstPoint && !_isHasSecondPoint)
            {
                InputText.text += ".";
                _isHasSecondPoint = true;
            }
        }


    }
    public void ButtonClear()
    {
        InputText.text = "";
        _isHasFirstPoint = false;
        _isHasSecondPoint = false;
    }

    public void ButtonEqual()
    {
        DataTable dt = new DataTable();
        InputText.text = dt.Compute(InputText.text, "").ToString();
        if (InputText.text.Contains(","))
        {
           InputText.text = InputText.text.Replace(',', '.');
        }
        _isHasOperator = false;
        _isHasFirstPoint = false;
        _isHasSecondPoint = false;
    }

}
