using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Domain.Entities
{
    public class User
{
    public int Id { get; private set; }
    public string Email { get; private set; }
    public string SenhaCriptografada { get; private set; }

    public User(string email, string senhaCriptografada)
    {
        Email = email;
        SenhaCriptografada = senhaCriptografada;
    }

    public void AlterarSenha(string novaSenhaCriptografada)
    {
        SenhaCriptografada = novaSenhaCriptografada;
    }
}
}