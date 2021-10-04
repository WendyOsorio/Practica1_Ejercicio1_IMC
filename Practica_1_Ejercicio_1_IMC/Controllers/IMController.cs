using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 * Nombre de la escuela: Universidad Tecnologica Metropolitana
 * Asignatura: Aplicaciones Web Orientadas a Objetos
 * Nombre del Maestro: Chuc Uc Joel Ivan
 * Nombre de la actividad: Indice de masa coporal o IMC
 * Nombre del alumno: Osorio Solis Wendy Yazmin
 * Cuatrimestre: 4
 * Grupo: C
 * Parcial: 1
*/

namespace Practica_1_Ejercicio_1_IMC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IMController : ControllerBase
    {
        [HttpGet]
        public IActionResult IMCFinal(double altura, double peso)
        {
            var I = new Datos();
            I.Peso = peso;
            I.Altura = altura / 100;
            var AlturaFinal = I.Altura;
            var IMCResultado = peso / (AlturaFinal * AlturaFinal);
            var Grado = "";

            if (IMCResultado < 18.5)
            {
                Grado = "Tienes un peso inferior a lo normal";
            }
            else
            {
                if (IMCResultado >= 18.5 && IMCResultado <= 24.9)
                {
                    Grado = "Tienes un peso normal";
                }
                else
                {
                    if (IMCResultado >= 25.0 && IMCResultado <= 29.9)
                    {
                        Grado = "Tienes un peso superior al normal";
                    }
                    else
                    {
                        Grado = "Tienes obesidad";
                    }
                }
            }
            var Resultado = "Su IMC es: " + Convert.ToString(IMCResultado) + " y su composicion corporal es:  " + Grado;
            return Ok(Resultado);
        }
    }
}

