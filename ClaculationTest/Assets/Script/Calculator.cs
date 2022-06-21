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

    public void OnClickButton()
    {
        InputText.text += Values;
        
    }
    public void ButtonClear()
    {
        InputText.text = "";
    }

    public void ButtonEqual()
    {
        DataTable dt = new DataTable();
        _temp = dt.Compute(InputText.text, "").ToString();
        InputText.text = _temp;
    }

}
