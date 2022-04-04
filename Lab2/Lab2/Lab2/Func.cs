using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab2
{
    public class Func
    {   
        //запис даних у бінарний файл
        public static void FileWrite(List<OfficeAppliances> officeAppliances, string path, FileMode fm) 
        {
            var stream = File.Open(path, fm);
            var bf = new BinaryFormatter();
            foreach (var i in officeAppliances)
                bf.Serialize(stream, i); 
            stream.Close();
        }
        
        //читання даних з бінарного файлу
        public static List<OfficeAppliances> FileRead(string path)
        {
            var officeAppliances = new List<OfficeAppliances>();
            var bf = new BinaryFormatter();
            var stream = File.Open(path, FileMode.Open);
            while (stream.Position < stream.Length)
                officeAppliances.Add((OfficeAppliances) bf.Deserialize(stream));
            stream.Close();
            return officeAppliances;
        }
        
        //виведення списку техніки
        public static void ListOut(List<OfficeAppliances> list, string comment) 
        {
            Console.WriteLine("\n" + comment);
            for (int i = 0; i < list.Count; i++) 
                Console.WriteLine($"{i + 1}. " + list[i].String());
            Console.WriteLine();
        }
        
        //сортування техніки за гарантією
        public static List<OfficeAppliances> ListSort(string path1, string path2) 
        {
            var list = FileRead(path1);
            var validList = new List<OfficeAppliances>();
            var expiredList = new List<OfficeAppliances>();
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].IsWarrantyExpired())
                    expiredList.Add(list[i]);
                else validList.Add(list[i]);
            }
            FileWrite(expiredList, path2, FileMode.Create);
            return validList;
        }
        
        //форматування табуляції
        public static string Tab(int len) 
        {
            string tab = "\t";
            for (int k = 0; k < (len >= 29 ? 0 : Math.Abs(len/10 - 3)); k++)
                tab += "\t";
            return tab;
        }
    }
}