using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Security.Cryptography;
using System.Text;

public class CryptSaveData
{
    //public string inputFile;
    //public string outputFile;
    public string filePath;
    public string password;

    private char[] mychar = { '.', 'P', 'R', 'D' };

    public CryptSaveData(string path, string pass)
    {
        //inputFile = input;
        //outputFile = output;
        filePath = path;
        password = pass;
    }

    public void EncryptedSaveData()
    {
        string e_file = filePath;
        if (File.Exists(e_file))
        {
            EncryptFile(e_file, e_file + ".PRD", password);
            File.Delete(e_file);
        }
    }

    public void DecryptedSaveData()
    {
        string e_file = filePath;
        if (File.Exists(e_file))
        {
            DecryptFile(e_file, e_file.TrimEnd(mychar), password);
            File.Delete(e_file);
        }
    }

    private void EncryptFile(string inputFile, string outputFile, string password)
    {
        try
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            string cryptFile = outputFile;
            FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

            FileStream fsIn = new FileStream(inputFile, FileMode.Open);

            int data;
            while ((data = fsIn.ReadByte()) != -1)
                cs.WriteByte((byte)data);


            fsIn.Close();
            cs.Close();
            fsCrypt.Close();
        }
        catch
        {
            
        }
    }

    private void DecryptFile(string inputFile, string outputFile, string password)
    {
        try
        {
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();
        }
        catch
        {
            
        }
    }
}
