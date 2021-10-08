using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioHotel
{
    class Estudante
    {
        //Criando e encapsulando uma variavel Nome
        public string Nome { get; set; }
        //Criando e encapsulando uma variavel Email
        public string Email { get; set; }

        //Criando um construtor para o nome e email da classe estudante
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //retornando o valor da variavel nome e email
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
