//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHECKLIST
    {
        public decimal ID_CHECKLIST { get; set; }
        public string ITEM_1 { get; set; }
        public Nullable<decimal> APROVADO_1 { get; set; }
        public Nullable<decimal> USUARIOS_ID_USUARIO { get; set; }
        public Nullable<decimal> EMPRESAS_ID_EMPRESA { get; set; }
        public string ITEM_2 { get; set; }
        public Nullable<decimal> APROVADO_2 { get; set; }
        public string ITEM_3 { get; set; }
        public Nullable<decimal> APROVADO_3 { get; set; }
        public string ITEM_4 { get; set; }
        public Nullable<decimal> APROVADO_4 { get; set; }
        public string ITEM_5 { get; set; }
        public Nullable<decimal> APROVADO_5 { get; set; }
    
        public virtual EMPRESAS EMPRESAS { get; set; }
        public virtual USUARIOS USUARIOS { get; set; }
    }
}
