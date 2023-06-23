using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class calculaCedulas : MonoBehaviour
{   
    [SerializeField]double valor = 437.33;
    private double[,] notasQtd = new double[12, 2]
    {
        { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 } , { 5, 0 }, { 2, 0 },
        { 1, 0 }, { 0.5, 0 }, { 0.25, 0 }, { 0.10, 0 }, { 0.5, 0 }, { 0.1, 0 }
    };

    // Start is called before the first frame update
    void Start()
    {
        if (valor >= 100)
        {
            this.notasQtd[0, 1] = (valor - (valor % 100))/100;
            valor -= this.notasQtd[0, 1] * 100;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 50)
        {
            this.notasQtd[1, 1] = (valor - (valor % 50))/50;
            valor -= this.notasQtd[1, 1] * 50;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 20)
        {
            this.notasQtd[2, 1] = (valor - (valor % 20))/20;
            valor -= this.notasQtd[2, 1] * 20;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 10)
        {
            this.notasQtd[3, 1] = (valor - (valor % 10))/10;
            valor -= this.notasQtd[3, 1] * 10;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 5)
        {
            this.notasQtd[4, 1] = (valor - (valor % 5))/5;
            valor -= this.notasQtd[4, 1] * 5;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 2)
        {
            this.notasQtd[5, 1] = (valor - (valor % 2))/2;
            valor -= this.notasQtd[5, 1] * 2;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        if (valor >= 1)
        {
            this.notasQtd[6, 1] = (valor - (valor % 1))/1;
            valor -= this.notasQtd[6, 1] * 1;
            valor = (double)(Math.Round((Decimal)valor, 2));
        }
        
        valor *= 100;

        if (valor >= 50)
        {
            this.notasQtd[7, 1] = (valor - (valor % 50))/50;
            valor -= this.notasQtd[7, 1] * 50;
        }
        if (valor >= 25)
        {
            this.notasQtd[8, 1] = (valor - (valor % 25))/25;
            valor -= this.notasQtd[8, 1] * 25;
        }
        if (valor >= 10)
        {
            this.notasQtd[9, 1] = (valor - (valor % 10))/10;
            valor -= this.notasQtd[9, 1] * 10;
        }
        if (valor >= 5)
        {
            this.notasQtd[10, 1] = (valor - (valor % 5))/5;
            valor -= this.notasQtd[10, 1] * 5;
        }
        if (valor >= 1)
        {
            this.notasQtd[11, 1] = (valor - (valor % 1))/1;
            valor -= this.notasQtd[11, 1] * 1;
        }
        imprimiResultado(this.notasQtd);
    }
    
    public void imprimiResultado(double[,] notas)
    {
        for (int i = 0; i < 12; i++)
        {
            if (notas[i, 1] != 0)
            {
                if (i < 6) Debug.Log($"{notas[i, 1]} notas de {notas[i, 0]} reais.");
                else Debug.Log($"{notas[i, 1]} moedas de {notas[i, 0]} centavos.");
            } 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
