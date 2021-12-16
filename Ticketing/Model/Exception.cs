using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing
{
    public class BadPasswordException : Exception
    {
        public BadPasswordException() : base ("Mot de passe incorrecte")
        {
        }
    }
}
