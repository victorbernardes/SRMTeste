//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SRMTeste.Dados
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int Cod_Cliente { get; set; }
        public string Nome_Cliente { get; set; }
        public long CPF { get; set; }
        public string Endereco_Rua { get; set; }
        public Nullable<long> Endereco_Numero { get; set; }
        public string Endereco_Complemento { get; set; }
        public string Endereco_Cidade { get; set; }
        public string Endereco_Estado { get; set; }
        public string Endereco_CEP { get; set; }
        public Nullable<System.DateTime> Data_Nascimento { get; set; }
        public Nullable<System.DateTime> Data_Cadastro { get; set; }
        public string Email { get; set; }
        public Nullable<long> Telefone { get; set; }
        public Nullable<decimal> Valor_Credito { get; set; }
        public string Endereco_Bairro { get; set; }
    }
}