namespace FilePassword.Cryptors
{
    public class Decryptor : Cryptor
    {
        public Decryptor ( string password )
        {
            PasswordToKey( password );
        }

        public string[ ] DecryptLines ( string[ ] lines )
        {
            return CryptLines( lines );
        }

        public string DecryptLine ( string line )
        {
            return CryptLine( line );
        }

        public char DecryptSymbol ( char symbol )
        {
            return CryptSymbol( symbol );
        }

        protected override char CryptMethod ( char symbol )
        {
            return ( char ) ( key ^ symbol );
        }
    }
}
