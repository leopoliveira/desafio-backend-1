﻿using desafio_backend_1.Models.Enums;

namespace desafio_backend_1.Models.Clientes
{
    public class Cliente
    {
        public Cliente()
        {
            ProblemasDeSaude = new List<ProblemaDeSaude>();
            DataCriacao = DateTime.Now;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public DateOnly DataNascimento { get; set; }

        public EnumSexo Sexo { get; set; }

        public List<ProblemaDeSaude> ProblemasDeSaude { get; set; }

        public decimal SomaGrauProblemas { get; set; }

        public DateTime DataCriacao { get; set; }

        public DateTime DataAtualizacao { get; set; }
    }
}
