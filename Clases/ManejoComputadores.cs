using ComputadoresITM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ComputadoresITM.Clases
{
    public class ManejoComputadores
    {
        private ITM_VentasEntities dbITM_Ventas = new ITM_VentasEntities();
        public string Ingresar(Computador computador)
        {
            try
            {
                dbITM_Ventas.Computadors.Add(computador);
                dbITM_Ventas.SaveChanges();
                return "Computador ingresado correctamente";

            }
            catch (Exception ex)
            {
                return "Error al ingresar un Computador: " + ex.Message;
            }

        }

        public List<Computador> CosultarTodos()
        {
            return dbITM_Ventas.Computadors.ToList();
        }

        public Computador ConsultarPorID(int id)
        {
            return dbITM_Ventas.Computadors.FirstOrDefault(c => c.ComputadorID == id);
        }

        public List<Computador> ConsultarPorTipo(int idTipo)
        {
            return dbITM_Ventas.Computadors.Where(compu => compu.TipoComputadorID == idTipo).ToList();
        }

        public string Actualizar(Computador computador)
        {
            try
            {
                Computador com = dbITM_Ventas.Computadors.FirstOrDefault(compu => compu.ComputadorID == computador.ComputadorID);
                if (com == null)
                {
                    return "No exite este Computador";
                }
                dbITM_Ventas.Computadors.AddOrUpdate(computador);
                dbITM_Ventas.SaveChanges();
                return "Computador actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al actualizar un Computador: " + ex.Message;
            }
        }

        public string EliminarPorID(int id)
        {
            try
            {
                Computador com = dbITM_Ventas.Computadors.FirstOrDefault(compu => compu.ComputadorID == id);
                if (com == null)
                {
                    return "No exite este Computador";
                }
                dbITM_Ventas.Computadors.Remove(com);
                dbITM_Ventas.SaveChanges();
                return "Computador eliminado correctamente";
            }
            catch (Exception ex)
            {
                return "Error al eliminar un Computador: " + ex.Message;
            }
        }
    }
}