from OfficeAppliances import OfficeAppliances
import func

path1 = "AllAppliances.txt"
path2 = "ExpiredAppliances.txt"
all_appliances = [
    OfficeAppliances("HP OfficeJet 8012e Printer", "23.09.2021", 365),
    OfficeAppliances("WD Desktop 12TB External Hard Drive", "01.12.2014", 365),
    OfficeAppliances("Brother IntelliFax 2820 Laser Fax", "13.04.2009", 730),
    OfficeAppliances("Dell Latitude E7270 12,5\" Laptop", "28.11.2021", 365),
    OfficeAppliances("Dell XPS 9310 13\" Laptop", "03.06.2020", 365),
    OfficeAppliances("TP-LINK Archer AX1500 Wi-Fi Router", "26.07.2021", 730),
    OfficeAppliances("LG Signage TV 43\" UHD LED IPS", "17.01.2021", 365),
    OfficeAppliances("Panasonic KXTG2511JTM Phone", "06.09.2012", 182)
]
func.file_write(all_appliances, path1, "ab")
all_appliances = func.file_read(path1)
func.list_out(all_appliances, "List of all appliances in office:\n")

warranted_appliances = func.list_sort(path1, path2)
unwarranted_appliances = func.file_read(path2)
func.list_out(warranted_appliances, "List of appliances with valid warranty:\n")
func.list_out(unwarranted_appliances, "List of appliances with expired warranty:\n")
