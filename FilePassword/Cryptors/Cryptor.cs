using System.Linq;

namespace FilePassword.Cryptors
{
    abstract public class Cryptor
    {
        protected int key;
        
        protected void PasswordToKey( string password )
        {
            key = password.GetHashCode( );
        }

        protected string[ ] CryptLines ( string[ ] lines )
        {
            return lines.Select(
                line => line = CryptLine( line )
            ).ToArray( );
        }

        protected string CryptLine ( string line )
        {
            return new string( line.Select(
                symbol => symbol = CryptSymbol( symbol )
            ).ToArray());
        }

        protected char CryptSymbol ( char symbol )
        {
            return CryptMethod( symbol );
        }

        protected abstract char CryptMethod ( char symbol );

    }
}
