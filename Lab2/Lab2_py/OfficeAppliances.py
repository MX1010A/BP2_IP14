from datetime import datetime
from datetime import timedelta


class OfficeAppliances:
    def __init__(self, name, date_of_purchase, warranty_term):  # конструктор
        self.name = name
        self.date_of_purchase = date_of_purchase
        self.warranty_term = warranty_term

    def is_warranty_expired(self):  # перевірка на дійсність гарантії
        is_expired = False
        date1 = datetime.strptime(self.date_of_purchase, "%d.%m.%Y")
        date2 = date1 + timedelta(days=self.warranty_term)
        if date2 < datetime.today():
            is_expired = True
        return is_expired

    def string(self):  # конвертування інформації про техніку в рядок
        return "{0} | purchased: {1} | warranty: {2} days".format(
            self.name, self.date_of_purchase, self.warranty_term)
