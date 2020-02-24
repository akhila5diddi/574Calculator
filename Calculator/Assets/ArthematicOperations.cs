using UnityEngine;
using UnityEngine.UI;
using System;
public class ArthematicOperations : MonoBehaviour
{
     public InputField Field1;
     public InputField Field2;
     public InputField Result;
 
     public void Sum() {
         int a = Convert.ToInt32(Field1.text);
         int b = Convert.ToInt32(Field2.text);
         int c = a+b;
         Result.text = c.ToString();
     }
 
 
     public void Product() {
         int a = Convert.ToInt32(Field1.text);
         int b = Convert.ToInt32(Field2.text);
         int c = a*b;
         Result.text = c.ToString();
     }

	  public void Division() {
         int a = Convert.ToInt32(Field1.text);
         int b = Convert.ToInt32(Field2.text);
         int c = a/b;
         Result.text = c.ToString();
     }
	 public void Subtraction() {
         int a = Convert.ToInt32(Field1.text);
         int b = Convert.ToInt32(Field2.text);
         int c = a-b;
         Result.text = c.ToString();
     }
}
