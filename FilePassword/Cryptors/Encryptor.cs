namespace FilePassword.Cryptors
{
    public class Encryptor : Cryptor
    {
        public Encryptor ( string password )
        {
            PasswordToKey( password );
        }

        public string[ ] EncryptLines ( string[ ] lines )
        {
            return CryptLines( lines );
        }

        public string EncryptLine ( string line )
        {
            return CryptLine( line );
        }

        public char EncryptSymbol ( char symbol )
        {
            return CryptSymbol( symbol );
        }

        protected override char CryptMethod ( char symbol )
        {
            return ( char ) ( symbol ^ key );
        }
    }
}
