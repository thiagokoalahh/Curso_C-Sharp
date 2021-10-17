using System;
using System.Collections.Generic;
using System.Text;

namespace Course_71_FixVect {
    class Estudante {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Estudante(string _nome, string _email) {
            Nome = _nome;
            Email = _email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
