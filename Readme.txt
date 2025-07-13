Программа "Домашняя бухгалтерия"

Для использования приложения в своем компьтере, вам необходимо в программе 
pgAdmin создать базу данных postgresq и зарегистрировать адрес к нему в программе Program.cs:

services.AddDbContext<DataContext>(options =>
{
    options.UseNpgsql("Host=localhost;Port=5432;Database=micros_test_task;Username=postgres;Password=jalol;"); <- Здесь вы пишете данные о базе данных.
});

То же самое вам придется сделать в файле DataContextFactory.cs (папка Data):

public DataContext CreateDbContext(string[] args)
{
    var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=micros_test_task;Username=postgres;Password=jalol;"); <- Здесь

    return new DataContext(optionsBuilder.Options);
}

Затем вы создаете миграцию и обновляете базы данных (в PMC):
> add-migration init
> update-database

Затем можете запускать программиу!

Программа разбита на несколько окон, первым выйдет окно логина/регистрации. 
После входа выйдет основное окно, котором можете увидеть вашу таблицу с транзакциями 
(создание/изменение/удаление), создавать свои категории, наносить фильтры и видеть 
диаграмму в разрезе категорий.
