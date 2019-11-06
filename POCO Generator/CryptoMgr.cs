using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;


namespace POCO_Generator
{
    public class CryptoMgr
    {
        private const String A1 = "C";
        private const String A2 = "F";
        private const String A3 = "a";
        private const String A4 = "j";
        private const String A5 = "H";
        private const String A6 = "E";
        private const String A7 = "k";
        private const String A8 = "N";
        private const String B1 = "b";
        private const String B2 = "Q";
        private const String B3 = "J";
        private const String B4 = "n";
        private const String B5 = "e";
        private const String B6 = "S";
        private const String B7 = "L";
        private const String B8 = "t";
        private const String C1 = "i";
        private const String C2 = "s";
        private const String C3 = "l";
        private const String C4 = "A";
        private const String C5 = "K";
        private const String C6 = "M";
        private const String C7 = "f";
        private const String C8 = "c";
        private const String D1 = "T";
        private const String D2 = "o";
        private const String D3 = "D";
        private const String D4 = "p";
        private const String D5 = "g";
        private const String D6 = "r";
        private const String D7 = "G";
        private const String D8 = "O";
        private const String E1 = "h";
        private const String E2 = "q";
        private const String E3 = "B";
        private const String E4 = "m";
        private const String E5 = "I";
        private const String E6 = "R";
        private const String E7 = "d";
        private const String E8 = "P";
        private const String F1 = "7";
        private const String F2 = "v";
        private const String F3 = "6";
        private const String F4 = "";
        private const String F5 = "u";
        private const String F6 = "4";
        private const String F7 = "";
        private const String F8 = "X";

        private const String G1 = "8";
        private const String G2 = "U";
        private const String G3 = "5";
        private const String G4 = "Y";
        private const String G5 = "z";
        private const String G6 = "1";
        private const String G7 = "V";
        private const String G8 = "9";

        private const String H1 = "x";
        private const String H2 = "3";
        private const String H3 = "w";
        private const String H4 = "2";
        private const String H5 = "y";
        private const String H6 = "0";
        private const String H7 = "W";
        private const String H8 = "Z";

        private static Byte[] m_arySeed = null;

        private static String m_strPrivateKey = "";


        /// <summary>
        /// Constructor
        /// </summary>
        public CryptoMgr()
        {

            try
            {
                // 32 characters x 8 bits/character = 256 bits
                m_strPrivateKey = A2 + B3 + F4 + C1 + D2 + E8 + H1 + G5 +
                                  A7 + B2 + F8 + C8 + D8 + E5 + H6 + G1 +
                                  A4 + B8 + F5 + C3 + D6 + E4 + H3 + G2 +
                                  A1 + B6 + F2 + C7 + D5 + E1 + H2 + G8;

                m_arySeed = Encoding.ASCII.GetBytes(A3 + B1 + A1 + D4 + C6 + E7 + D6 + A5);

            }  // END try
            catch 
            {
                throw;
            } // END catch
            finally
            {

            }  // END finally


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strPrivateKey">Typically 32 characters long (32 characters x 8 bits/character = 256 bits)</param>
        /// <param name="strSeed">Typically 8 characters</param>
        public CryptoMgr(String strPrivateKey, String strSeed)
        {


            try
            {
                m_strPrivateKey = strPrivateKey;

                m_arySeed = Encoding.ASCII.GetBytes(strSeed);

            }  // END try
            catch
            {
                throw;
            } // END catch
            finally
            {

            }  // END finally


        }

        /// <summary> 
        /// Encrypt the given string using AES.  The string can be decrypted using  
        /// DecryptStringAES().   
        /// </summary> 
        /// <param name="strStringToEncrypt">The text to encrypt.</param> 
        public String EncryptStringAES(String strStringToEncrypt)
        {
            if (String.IsNullOrEmpty(strStringToEncrypt))
            {

                ArgumentNullException exArg = new ArgumentNullException(CryptoMgrResources.ENCRYPT_EMPTY_MSG);

                throw exArg;
            }

            String strReturn = null;                    // Encrypted string to return 
            RijndaelManaged objRij = null;              // RijndaelManaged object used to encrypt the data. 

            try
            {
                // generate the key from the shared secret and the salt 
                Rfc2898DeriveBytes aryDerivedKey = new Rfc2898DeriveBytes(m_strPrivateKey, m_arySeed, 2345);

                // Create a RijndaelManaged object 
                // with the specified key and IV. 
                objRij = new RijndaelManaged();
                objRij.Key = aryDerivedKey.GetBytes(objRij.KeySize / 8);
                objRij.IV = aryDerivedKey.GetBytes(objRij.BlockSize / 8);

                // Create a encryptor to perform the stream transform. 
                ICryptoTransform objEncryption = objRij.CreateEncryptor(objRij.Key, objRij.IV);

                // Create the streams used for encryption. 
                using (MemoryStream objMemStreamEncrypt = new MemoryStream())
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(objMemStreamEncrypt,
                                                                           objEncryption,
                                                                           CryptoStreamMode.Write))
                    {
                        using (StreamWriter objWriter = new StreamWriter(objCryptoStream))
                        {

                            //Write all data to the stream. 
                            objWriter.Write(strStringToEncrypt);
                        }
                    }

                    strReturn = Convert.ToBase64String(objMemStreamEncrypt.ToArray());
                }
            }  // END try
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("strStringToEncrypt", strStringToEncrypt ?? "");

                throw;
            }
            finally
            {

                // Clear the RijndaelManaged object. 
                if (objRij != null)
                {
                    objRij.Clear();
                }
            }

            // Return the encrypted bytes from the memory stream. 
            return strReturn;
        }

        /// <summary> 
        /// Decrypt the given string.  Assumes the string was encrypted using  
        /// EncryptStringAES(). 
        /// </summary> 
        /// <param name="strEncryptedText">The text to decrypt.</param> 
        public String DecryptStringAES(String strEncryptedText)
        {

            if (String.IsNullOrEmpty(strEncryptedText))
            {

                ArgumentNullException exArg = new ArgumentNullException(CryptoMgrResources.DECRYPT_EMPTY_MSG);

                throw exArg;
            }

            // Declare the RijndaelManaged object 
            // used to decrypt the data. 
            RijndaelManaged objRij = null;


            // Declare the string used to hold 
            // the decrypted text. 
            String strReturn = null;

            try
            {
                // generate the key from the shared secret and the salt. 
                // RSA recommends a minimum of 1,000 iterations
                Rfc2898DeriveBytes aryDerivedKey = new Rfc2898DeriveBytes(m_strPrivateKey, m_arySeed, 2345);

                // Create a RijndaelManaged object 
                // with the specified key and IV. 
                objRij = new RijndaelManaged();
                objRij.Key = aryDerivedKey.GetBytes(objRij.KeySize / 8);
                objRij.IV = aryDerivedKey.GetBytes(objRij.BlockSize / 8);

                // Create a decrytor to perform the stream transform. 
                ICryptoTransform objDecryption = objRij.CreateDecryptor(objRij.Key, objRij.IV);

                // Create the streams used for decryption.                 
                byte[] aryEncryptedText = Convert.FromBase64String(strEncryptedText);

                using (MemoryStream objMemStreamDecrypt = new MemoryStream(aryEncryptedText))
                {
                    using (CryptoStream objCryptoStream = new CryptoStream(objMemStreamDecrypt,
                                                                           objDecryption,
                                                                           CryptoStreamMode.Read))
                    {
                        using (StreamReader objReader = new StreamReader(objCryptoStream))

                            // Read the decrypted bytes from the decrypting stream 
                            // and place them in a string. 
                            strReturn = objReader.ReadToEnd();
                    }
                }
            }  // END try
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("strEncryptedText", strEncryptedText ?? "");

                throw;

            } // END catch
            finally
            {

                // Clear the RijndaelManaged object. 
                if (objRij != null)
                {
                    objRij.Clear();
                }
            }

            return strReturn;

        }  // END public String DecryptStringAES(String strEncryptedText)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objInnerStream"></param>
        /// <returns></returns>
        public CryptoStream GetEncryptedStreamObject(Stream objInnerStream)
        {


            CryptoStream objEncryptedStream = null;

            // Declare the RijndaelManaged object 
            // used to decrypt the data. 
            RijndaelManaged objRij = null;

            try
            {
                // generate the key from the shared secret and the salt. 
                // RSA recommends a minimum of 1,000 iterations
                Rfc2898DeriveBytes aryDerivedKey = new Rfc2898DeriveBytes(m_strPrivateKey, m_arySeed, 2345);

                // Create a RijndaelManaged object 
                // with the specified key and IV. 
                objRij = new RijndaelManaged();
                objRij.Padding = PaddingMode.Zeros;
                objRij.Key = aryDerivedKey.GetBytes(objRij.KeySize / 8);
                objRij.IV = aryDerivedKey.GetBytes(objRij.BlockSize / 8);

                // Create a decrytor to perform the stream transform. 
                ICryptoTransform objEncryptor = objRij.CreateEncryptor(objRij.Key, objRij.IV);

                objEncryptedStream = new CryptoStream(objInnerStream, objEncryptor, CryptoStreamMode.Write);
            }  // END try
            catch (Exception exUnhandled)
            {
                throw;
            } // END catch
            finally
            {

                // Clear the RijndaelManaged object. 
                if (objRij != null)
                {
                    objRij.Clear();
                }
            }

            return objEncryptedStream;

        }  // END public CryptoStream GetEncryptedStreamObject(Stream objInnerStream)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="objInnerStream"></param>
        /// <returns></returns>
        public CryptoStream GetDecryptedStreamObject(Stream objInnerStream)
        {


            DateTime dtmMethodStart = DateTime.Now;

            CryptoStream objEncryptedStream = null;

            // Declare the RijndaelManaged object 
            // used to decrypt the data. 
            RijndaelManaged objRij = null;

            try
            {
                // generate the key from the shared secret and the salt. 
                // RSA recommends a minimum of 1,000 iterations
                Rfc2898DeriveBytes aryDerivedKey = new Rfc2898DeriveBytes(m_strPrivateKey, m_arySeed, 2345);

                // Create a RijndaelManaged object 
                // with the specified key and IV. 
                objRij = new RijndaelManaged();
                objRij.Padding = PaddingMode.Zeros;
                objRij.Key = aryDerivedKey.GetBytes(objRij.KeySize / 8);
                objRij.IV = aryDerivedKey.GetBytes(objRij.BlockSize / 8);

                // Create a decrytor to perform the stream transform. 
                ICryptoTransform objDecryptor = objRij.CreateDecryptor(objRij.Key, objRij.IV);

                objEncryptedStream = new CryptoStream(objInnerStream, objDecryptor, CryptoStreamMode.Read);
            }  // END try
            catch (Exception exUnhandled)
            {
                throw;
            } // END catch
            finally
            {
                // Clear the RijndaelManaged object. 
                if (objRij != null)
                    objRij.Clear();
            }

            return objEncryptedStream;

        }  // END public CryptoStream GetEncryptedStreamObject(Stream objInnerStream)


        /// <summary>
        /// This function takes a value you want hashed and hashes it uses SHA-512 for strength.  
        /// The value returned is the hash string in Base 64.
        /// </summary>
        /// <param name="strStringToHash">This is the value, such as a password.  It will usually be the same over a number of instances on multiple machines.</param>
        /// <returns>The value returned is the hash string in Base 64</returns>
        public String GetHash(string strStringToHash)
        {

            String ReturnValue = "";

            SHA512Managed Hasher = null;

            try
            {
                Hasher = new System.Security.Cryptography.SHA512Managed();

                Byte[] Text2Hash = System.Text.Encoding.UTF8.GetBytes(strStringToHash);

                Byte[] PlateOfHash = Hasher.ComputeHash(Text2Hash);

                ReturnValue = Convert.ToBase64String(PlateOfHash);

            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("strStringToHash", strStringToHash ?? "");

                throw;

            } // END catch
            finally
            {
                if (Hasher != null)
                {
                    Hasher.Clear();

                    Hasher.Dispose();

                    Hasher = null;
                }
            }

            return ReturnValue;

        }

        /// <summary>
        /// This function takes a value you want hashed, uses SHA-512 for strength, and includes a 
        /// salt value that has no intrinsic meaning.  The value returned is the hash string in Base 64.
        /// </summary>
        /// <param name="ValueToHash">This is the value, such as a password.  It will usually be the same over a number of instances on multiple machines.</param>
        /// <param name="SaltToUse">This is a value that extends the hash for security.</param>
        /// <returns>The value returned is the hash string in Base 64</returns>
        public String GetHash(String ValueToHash, String SaltToUse)
        {

            DateTime dtmMethodStart = DateTime.Now;

            String ReturnValue = "";

            SHA512Managed Hasher = null;

            try
            {
                Hasher = new System.Security.Cryptography.SHA512Managed();

                Byte[] Text2Hash = System.Text.Encoding.UTF8.GetBytes(String.Concat(ValueToHash.Trim(),
                                                                                    SaltToUse.Trim()));

                Byte[] PlateOfHash = Hasher.ComputeHash(Text2Hash);

                ReturnValue = Convert.ToBase64String(PlateOfHash);
            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("ValueToHash", ValueToHash ?? "");
                exUnhandled.Data.Add("SaltToUse", SaltToUse ?? "");

                throw;


            } // END catch
            finally
            {

                if (Hasher != null)
                {
                    Hasher.Clear();

                    Hasher.Dispose();

                    Hasher = null;
                }
            }

            return ReturnValue;

        }  // END public String GetHash(String ValueToHash, String ValueLocale, String SaltToUse)



        /// <summary>
        /// This function takes a value you want hashed, uses SHA-512 for strength, and includes a locale extender such as a computer name, 
        /// and a salt value that has no intrinsic meaning.  The value returned is the hash string in Base 64.
        /// </summary>
        /// <param name="ValueToHash">This is the value, such as a password.  It will usually be the same over a number of instances on multiple machines.</param>
        /// <param name="ValueLocale">This is a value specific to the machine, such as machine name.  It should be deterministic on every use.</param>
        /// <param name="SaltToUse">This is a value that extends the hash for security.</param>
        /// <returns>The value returned is the hash string in Base 64</returns>
        public String GetHash(String ValueToHash, String ValueLocale, String SaltToUse)
        {

            DateTime dtmMethodStart = DateTime.Now;

            String ReturnValue = "";

            SHA512Managed Hasher = null;

            try
            {
                Hasher = new System.Security.Cryptography.SHA512Managed();

                Byte[] Text2Hash = System.Text.Encoding.UTF8.GetBytes(String.Concat(ValueToHash.Trim(),
                                                                                    ValueLocale.ToUpper(),
                                                                                    SaltToUse.Trim()));

                Byte[] PlateOfHash = Hasher.ComputeHash(Text2Hash);

                ReturnValue = Convert.ToBase64String(PlateOfHash);
            }
            catch (Exception exUnhandled)
            {
                exUnhandled.Data.Add("ValueToHash", ValueToHash ?? "");
                exUnhandled.Data.Add("ValueLocale", ValueLocale ?? "");
                exUnhandled.Data.Add("SaltToUse", SaltToUse ?? "");

                throw;

            } // END catch
            finally
            {

                if (Hasher != null)
                {
                    Hasher.Clear();

                    Hasher.Dispose();

                    Hasher = null;
                }
            }

            return ReturnValue;

        }  // END public  String GetHash(String ValueToHash, String ValueLocale, String SaltToUse)



    }  // END public class CryptoMgr
}
