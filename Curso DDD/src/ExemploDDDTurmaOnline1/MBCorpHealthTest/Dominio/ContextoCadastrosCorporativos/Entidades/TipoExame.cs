﻿using System;

namespace MBCorpHealthTest.Dominio.ContextoCadastrosCorporativos.Entidades
{
    public class TipoExame
    {
        //Classificação Brasileira Hierarquizada de Procedimentos Médicos
        public TipoExame(string cbhpm, string descricao, Double valor)
        {
            CBHPM = cbhpm;
            Descricao = descricao;
            Valor = valor;
        }

        protected TipoExame()
        {
        }

        public string CBHPM { get; protected set; }
        public string Descricao { get; protected set; }
        public double Valor { get; set; }

        //Todo Criar método de validação
    }
}