using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excepcion : MonoBehaviour
//No es copia profe, lo hice viendo la clase, lo hice directo en visual, solo lo estoy pasando en la compu donde esta mi repositorio :D
{

    int divide(int a, int b)
    {
        if (b == 0 || a == 0) {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return a / b;

    }
    int GetArrayValue(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("Indice fuera de rango. Revisa nuevamente");
        }

        return array[index];
    }
    int CastStringToInt(string _str)
    {
        return int.Parse(_str);
    }
    void Start()
    {
        try
        {
            int result = divide(10, 0);
            Debug.Log("El Resultado de la division es: " + result);
        }
        catch (DivideByZeroException exception)
        {
            Debug.Log("Error: al dividir por cero: " + exception.Message);
        }

        //Access to an invalid index
        try
        {
            string str = "lUIS";

            int result = CastStringToInt(str);
            Debug.Log("El resultado del numero convertido es:" + result);
        }
        catch (FormatException ex3)
        {
            Debug.LogError("Error Erroneo. Detalles: " + ex3.Message);

        }
        catch (Exception ex4) {
            Debug.LogError("Error en general: Formato incorrecto. Detalles: " + ex4.Message);
            
        }
        //cast 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            transform.parent.GetChild(0).gameObject.SetActive(true);
        }
    } 
    private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                transform.parent.GetChild(0).gameObject.SetActive(false);
            }
        }
}









    
 