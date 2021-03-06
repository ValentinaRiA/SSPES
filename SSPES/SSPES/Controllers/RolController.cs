﻿using SSPES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSPES.Controllers {
    public class RolController {

        public RolModel modelo = new RolModel();

        public List<string> consultarRoles(RolModel obj) {
            return obj.consultarRoles(obj);
        }

        public bool RegistrarRol(string cad) {
            return modelo.InsertarRol(cad);
        }

        public List<string> Permisos() {
            return modelo.ConsultarPermisos();
        }

        public string ConsultarPk(string obj) {
            return modelo.ConsultarPk(obj);
        }
    }
}