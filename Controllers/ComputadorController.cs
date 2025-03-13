
using ComputadoresITM.Models;
using ComputadoresITM.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ParqueDivITM.Controllers
{
    [RoutePrefix("api/Computador")]
    public class ComputadorController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Computador> ConsultarTodos()
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.CosultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorID")]
        public Computador ConsultarPorID(int id)
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.ConsultarPorID(id);
        }

        [HttpGet]
        [Route("ConsultarTipoComputador")]
        public List<Computador> ConsultarPorTipo(int idTipo)
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.ConsultarPorTipo(idTipo);
        }

        [HttpPost]
        [Route("Ingresar")]
        public string Ingresar([FromBody] Computador computador)
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.Ingresar(computador);
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador computador)
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.Actualizar(computador);
        }

        [HttpDelete]
        [Route("EliminaPorID")]
        public string EliminaPorID(int id)
        {
            ManejoComputadores manejoComputadores = new ManejoComputadores();
            return manejoComputadores.EliminarPorID(id);
        }

    }
}