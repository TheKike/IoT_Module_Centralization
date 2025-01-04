using IoT_Module_Centralization.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

ApplicationContext appContext = new ApplicationContext("Data Source=IoT_Modulo_Centralization.sqlite");

//Verificando si la BD no existe
if (!appContext.Database.CanConnect())
{
    Console.WriteLine("Migrando la BD... wait");
    //Migrando base de datos. Este paso genera la BD con las tabls configuradas en su migracion.
    appContext.Database.Migrate();
    Console.WriteLine("Se ha migrado la BD");
}
