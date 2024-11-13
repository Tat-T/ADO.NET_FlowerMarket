### Задание
Создать базу магазин цветов с таблицами Товары и Клиенты
заполнить тестовыми данными.

Создать приложение для вывода данных из БД при помощи LINQ.

---
### Инструменты разработки


<img src="images/SQL-Server-Management-Studio.jpg" alt="Окно приложения" height="50"><img src="images/VisualStudiologo.jpg" alt="Окно приложения" height="50">

- SQL Server Management Studio 20 

- Visual Studio 2022 

### Настройка подключения к БД перед запуском
---

Перед запуском прложения нужно настроить подключение к БД. 

В SQL Server добавить базу данных.
База данных FlowerMarket.sql в папке bd

И изменить настройки подключения к БД в коде.

1. В файле Form1.cs в строке 19 указываете имя своего сервера `con.ConnectionString = "Data Source= свои данные SQL Server;"`

   <img src="images/2.jpg" alt="Окно приложения" width="350">

2. В БД Долждны быть 2 таблицы: Clients и Flower

   <img src="images/3.jpg" alt="Окно приложения" width="180">

И если всё это есть можно запускать приложение через WindowsFormsApp1.sln

<img src="1.jpg" alt="Окно приложения" width="350">
