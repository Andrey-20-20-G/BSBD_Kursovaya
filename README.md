Login: Бог Password: Бог (Администратор)
Login: Ivan Password: 1234 (Участник)
Login: Володя Password: Володя (Судья)

Перед запуском программы (после подключения БД на своей рабочей станции) необходимо изменить в коде программы строку подключения, которая выглядит следующим образом: SqlConnection conn = new SqlConnection(@"Data Source = LAPTOP-T22HF5E5; Initial Catalog = Authorization; Integrated Security = True;App=Agent;Asynchronous Processing=true");

У вас она должна выглядеть так:
SqlConnection conn = new SqlConnection(@"Data Source = [Название вашей локальной машины (можно скопировать из строки SSMS при входе)]; Initial Catalog = Authorization; Integrated Security = True;App=Agent;Asynchronous Processing=true");
