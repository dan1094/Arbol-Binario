using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Entidades;
using Rule;

namespace DanielDelgado_ArbolBinario.Controllers
{
    /// <summary>
    /// Consultas para Arbol
    /// </summary>
    public class ArbolController : ApiController
    {

        /// <summary>
        /// 1. Crear Arbol
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IHttpActionResult CreateTree(ParametrosEntradaCrear param)
        {
            try
            {
                ArbolRule rule = new ArbolRule();
                int err = rule.ValidarParametros(param);
                if (err == 1000)
                {
                    return BadRequest("Maximo de niveles debe ser mayor a 1");
                }
                else if (err == 1001)
                {
                    return BadRequest("valor minino debe ser menor a valor maximo");
                }


                return Ok(rule.CrearArbol(param));
            }
            catch (Exception)
            {
                return InternalServerError();

            }


        }

        /// <summary>
        /// Lowest Common Ancestor
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IHttpActionResult LowestCommonAncestor(ParametrosEntradaBuscar param)
        {
            try
            {
                ArbolRule rule = new ArbolRule();
                int resultado = rule.BuscarAntecesorComun(param);
                if (resultado > 0)
                {
                    return Ok(string.Format("El antecesor comun entre '{0}' y  '{1}' es: '{2}'", param.Valor1, 
                        param.Valor2, resultado));
                }
                return NotFound();

            }
            catch (Exception)
            {
                return InternalServerError();
            }


        }
    }
}