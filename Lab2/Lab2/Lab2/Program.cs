using System.Collections.Generic;
using System.IO;
using static Lab2.Func;

namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            const string path1 = "AllAppliances.txt";
            const string path2 = "ExpiredAppliances.txt";
            var allAppliances = new List<OfficeAppliances>
            {
                new("HP OfficeJet 8012e Printer", "23.09.2021", 365),
                new("WD Desktop 12TB External Hard Drive", "01.12.2014", 365),
                new("Brother IntelliFax 2820 Laser Fax", "13.04.2009", 730),
                new("Dell Latitude E7270 12,5\" Laptop", "28.11.2021", 365),
                new("Dell XPS 9310 13\" Laptop", "03.06.2020", 365),
                new("TP-LINK Archer AX1500 Wi-Fi Router", "26.07.2021", 730),
                new("LG Signage TV 43\" UHD LED IPS", "17.01.2021", 365),
                new("Panasonic KXTG2511JTM Phone", "06.09.2012", 182)
            };
            FileWrite(allAppliances, path1, FileMode.Append);
            allAppliances = FileRead(path1);
            ListOut(allAppliances, "List of all appliances in office:\n");
            
            var warrantedAppliances = ListSort(path1, path2);
            var unwarrantedAppliances = FileRead(path2);
            ListOut(warrantedAppliances, "List of appliances with valid warranty:\n");
            ListOut(unwarrantedAppliances, "List of appliances with expired warranty:\n");
        }
    }
}