﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 19/04/2018 17:21:49
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace CadastroEpi.Domain.Model
{

    /// <summary>
    /// There are no comments for CadastroEpi.Domain.Model.Funcao in the schema.
    /// </summary>
    public partial class Funcao    {

        public Funcao()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for FuncaoId in the schema.
        /// </summary>
        public virtual int FuncaoId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NomeFuncao in the schema.
        /// </summary>
        public virtual string NomeFuncao
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for EmpresaId in the schema.
        /// </summary>
        public virtual int EmpresaId
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Empresa in the schema.
        /// </summary>
        public virtual Empresa Empresa
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for Funcionarios in the schema.
        /// </summary>
        public virtual ICollection<Funcionario> Funcionarios
        {
            get;
            set;
        }

        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
