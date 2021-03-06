﻿using Entidades.Entidades.Ordenes;
using Entidades.Entidades.Permisos;
using Entidades.Entidades.Roles;
using Entidades.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XShop.CLS
{
    public static class Utility
    {
       public static string getRol(int id)
        {
            string rol = "";

            switch (id)
            {
                case 1:
                    {
                        rol = "Administrador";
                        break;
                    }
                case 2:
                    {
                        rol = "Mesero";
                        break;
                    }
                case 3:
                    {
                        rol = "Cocinero";
                        break;
                    }
            }


            return rol;
        }

        public static string DevolverClasificacion(int id)
        {
            String dato;

            ClasificacionOrdenes clasificacion = new ClasificacionOrdenes();

            OrdenDAO dao = new OrdenDAO();

           clasificacion =  dao.GetClasificacion(id);

           dato =  clasificacion.nombre;

            return dato;
        }
        public static string DevolverRolName(string id)
        {
            String dato;

            Rol rol = new Rol();

            RolesDAO dao = new RolesDAO();

            rol = dao.ObtenerRolByName(id);

            dato = rol.RolName;

            return dato;
        }

        public static string DevolverRol(int id)
        {
            String dato;

            Rol rol = new Rol();

            RolesDAO dao = new RolesDAO();

            rol = dao.ObtenerRolById(id);

            dato = rol.RolName;

            return dato;
        }
        public static string DevolverOpcion(string id)
        {
            String dato;

            Opcion opcion = new Opcion();

            OpcionDAO dao = new OpcionDAO();

            opcion = dao.ObtenerOpcionByName(id);

            dato = opcion.NombreOpcion;

            return dato;
        }

        public static Ordenes getOrdenById(int id)
        {
            OrdenDAO dao = new OrdenDAO();
            Ordenes o = dao.ObtenerOrdenById(id);
            return o != null ? o : new Ordenes();
        }

        public static Boolean textBoxIsEmpty(List<TextBox> t)
        {
            Boolean Valido = false;
            for(int i =0; i< t.Count; i++)
            {
                if (t[i].Text != string.Empty && t[i].Text != " ")
                {
                    Valido = true;
                }
                else
                {
                    Valido = false;
                }    
            }
            return Valido;
        }

        public static void ClearTextbox(List<TextBox> t)
        {
            
            for (int i = 0; i < t.Count; i++)
            {
                t[i].Text = "";
            }
          
        }

        public static string DevolverNombreMes(int numeroMes)
        {
           string mes = string.Empty;

            switch (numeroMes)
            {
                case 1:
                    mes = "Enero";
                break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
                default:
                     mes = string.Empty;
                    break;
            }
           return mes;
        }

       public static string Encryptar(string clave)
        {
            string devolver;
            try
            {

                UsuarioDAO dao = new UsuarioDAO();
                devolver = dao.Encriptar(clave);

                return devolver;
            }
            catch 
            {
                devolver = string.Empty;
               
            }
            return devolver;
          
        }


    }

   
}
