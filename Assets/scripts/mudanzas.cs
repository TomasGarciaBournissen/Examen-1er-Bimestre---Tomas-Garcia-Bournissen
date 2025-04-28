using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudanzas : MonoBehaviour
{

    public int cargaContratada;
    public int kmContratados;
    int capacidadUtilitario = 2000;
    int capacidadPickup = 5000;
    int capacidadCamion = 10000;
    int precioUtilitario = 3000;
    int precioPickup = 4500;
    int precioCamion = 7000;
    int precioEnUso;
    int horasTotales;
    string vehiculoEnUso;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        if (cargaContratada < 100 || kmContratados < 1 || cargaContratada >10000)
        {
            Debug.Log("Datos invalidos, Porfavor ingrese una carga no menor de 100kg y no mayor a 10000kg o un kilometraje mayor o igual a 1km");
        }
        else
        {
            
            horasTotales = (kmContratados +24 )/ 25;
            
            if (horasTotales < 2)
            {
                horasTotales = 2;
            }
            if (cargaContratada <= capacidadUtilitario)
            {
                precioEnUso = precioUtilitario;

                vehiculoEnUso = "Utilitario";

            }
            else if (cargaContratada <= capacidadPickup)
            {
                precioEnUso = precioPickup;
                vehiculoEnUso = "Pickup";
            }
            else if (cargaContratada <= capacidadCamion)
            {
                precioEnUso = precioCamion;
                vehiculoEnUso = "Camion";
            }



            if (kmContratados > 50)
            {
                horasTotales += 1;
            }
            total = precioEnUso * horasTotales;

            Debug.Log("Se necesita un " + vehiculoEnUso + " para este viaje. Ademas, se necesitan " + horasTotales + " horas para realizar el viaje");
            Debug.Log("Precio total " + horasTotales + " horas a $" + precioEnUso + " : " + total);



        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
