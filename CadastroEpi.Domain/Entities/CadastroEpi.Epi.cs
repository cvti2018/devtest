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
    /// There are no comments for CadastroEpi.Domain.Model.Epi in the schema.
    /// </summary>
    public partial class Epi    {

        public Epi()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for EpiId in the schema.
        /// </summary>
        public virtual int EpiId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NomEpi in the schema.
        /// </summary>
        public virtual string NomEpi
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for DatInclusao in the schema.
        /// </summary>
        public virtual global::System.DateTimeOffset DatInclusao
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for DatValidade in the schema.
        /// </summary>
        public virtual global::System.Nullable<System.DateTime> DatValidade
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NumCa in the schema.
        /// </summary>
        public virtual int NumCa
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NumProcesso in the schema.
        /// </summary>
        public virtual string NumProcesso
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for NomFabricante in the schema.
        /// </summary>
        public virtual string NomFabricante
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CnpjFabricante in the schema.
        /// </summary>
        public virtual string CnpjFabricante
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
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
