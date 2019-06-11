//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using Entidades;
//using Rule;

//namespace DanielDelgado_ArbolBinario.Controllers
//{
//    public class ValuesController : ApiController
//    {
//        // GET api/values
//        public IEnumerable<string> Get()
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // GET api/values/5
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        public void Post([FromBody]string value)
//        {
//        }

//        // PUT api/values/5
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/values/5
//        public void Delete(int id)
//        {

//            //IsolatedStorageFile iso = new IsolatedStorageFile.GetStore();
//        }

//        /// <summary>
//        /// Crear Arbol
//        /// </summary>
//        /// <param name="param"></param>
//        /// <returns></returns>
//        public IHttpActionResult CrearArbol(ParametrosEntrada param) {
//            try
//            {
//                ArbolRule rule = new ArbolRule ();

//                return Ok(rule.CrearArbol(param));
//            }
//            catch (Exception)
//            {
//                return  InternalServerError(); 
//              //  throw;
//            }
        
        
//        }

//    }
//}
