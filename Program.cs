using System;
using System.IO;

int opcion; 

// aca agregue un bucle do-while para repetir el menú hasta que el usuario seleccione "11. Salir"
do
{
    Console.WriteLine("\nSeleccione una opción: ");
    Console.WriteLine("1. Crear Archivo");
    Console.WriteLine("2. Agregar Invento");
    Console.WriteLine("3. Leer Linea Por Linea");
    Console.WriteLine("4. Leer todo el Texto");
    Console.WriteLine("5. Copiar Archivo");
    Console.WriteLine("6. Mover Archivo");
    Console.WriteLine("7. Crear Carpeta");
    Console.WriteLine("8. Verificar Existencia de Archivo");
    Console.WriteLine("9. Eliminar Archivo");
    Console.WriteLine("10. Listar Archivos");
    Console.WriteLine("11. Salir");

    Console.Write("Ingrese una opción: ");

    // aca se Valida que el usuario ingrese un número válido
    if (!int.TryParse(Console.ReadLine(), out opcion)) 
    {
        Console.WriteLine("Opción inválida, intente nuevamente.");
        continue; // Si la entrada no es válida, volvemos a mostrar el menú
    }

    switch (opcion)
    {
        // Se crea el archivo con los inventos de tony stark
        case 1:
            void CrearArchivo()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string contenido = "1. Traje Mark 1 \n 2. Reactor Arc \n 3. Inteligencia Artificial JARVIS\n ";
                File.WriteAllText(path, contenido);
                Console.WriteLine("Archivo creado");
            }
            CrearArchivo();
            break;

            // se agrega el nuveo invento
        case 2:
            void AgregarInvento()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string linea = "3. Drones de Combate \n";
                File.AppendAllLines(path, new string[] { linea }); // Se agrega una nueva línea al archivo
                Console.WriteLine("Línea agregada");
            }
            AgregarInvento();
            break;

            // se lee el archivo linea por linea
        case 3:
            void LeerLineaPorLinea()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string[] lineas = File.ReadAllLines(path); // Se leen todas las líneas del archivo
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
            LeerLineaPorLinea();
            break;

            //se lee todo el texto
        case 4:
            void LeerTodoElTexto()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string contenido = File.ReadAllText(path); // Se lee todo el contenido del archivo
                Console.WriteLine("Contenido: ");
                Console.WriteLine(contenido);
            }
            LeerTodoElTexto();
            break;

            // se copia el archivo
        case 5:
            void CopiarArchivo()
            {
                string pathOrigen = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string pathDestino = "C:\\Users\\maria\\Desktop\\tony stark\\Backup\\inventos 2.txt";
                File.Copy(pathOrigen, pathDestino, true); // Cambio agregado:
                Console.WriteLine("Archivo copiado");
            }
            CopiarArchivo();
            break;

            // se mueve el archivo
        case 6:
            void MoverArchivo()
            {
                string pathOrigen = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                string pathDestino = "C:\\Users\\maria\\Desktop\\tony stark\\archivos clasificados\\clasificados.txt";
                File.Move(pathOrigen, pathDestino); // Se mueve el archivo a una nueva ubicación
                Console.WriteLine("Archivo movido exitosamente");
            }
            MoverArchivo();
            break;

            // se crea una carpeta
        case 7:
            void CrearCarpeta()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\Proyectos Ultra Secretos";
                if (!Directory.Exists(path)) // Verificamos si la carpeta ya existe
                {
                    Directory.CreateDirectory(path); // Si no existe, se crea
                    Console.WriteLine("Carpeta creada");
                }
                else
                {
                    Console.WriteLine("La carpeta ya existe");
                }
            }
            CrearCarpeta();
            break;

            // se verifica la existencia del archivo
        case 8:
            void VerificarExistencia()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                if (File.Exists(path)) // Verificamos si el archivo existe
                {
                    Console.WriteLine("El archivo existe");
                }
                else
                {
                    void CrearArchivo()
                    {
                        string contenido = "Archivo de prueba";
                        File.WriteAllText(path, contenido); // Si no existe, se crea
                        Console.WriteLine("Archivo creado...");
                    }
                    CrearArchivo();
                }
            }
            VerificarExistencia();
            break;

            // se elimina el archivo
        case 9:
            void EliminarArchivo()
            {
                string archivo = "C:\\Users\\maria\\Desktop\\tony stark\\inventos.txt";
                File.Delete(archivo); // Se elimina el archivo
                Console.WriteLine("Archivo eliminado");
            }
            EliminarArchivo();
            break;

            // se listan los archivos
        case 10:
            void ListarArchivos()
            {
                string path = "C:\\Users\\maria\\Desktop\\tony stark";
                if (Directory.Exists(path)) // Verificamos si la carpeta existe
                {
                    foreach (var archivo in Directory.GetFiles(path)) // Se listan los archivos dentro de la carpeta
                    {
                        Console.WriteLine(archivo);
                    }
                }
                else
                {
                    Console.WriteLine("No existe la carpeta");
                }
            }
            ListarArchivos();
            break;

            // se sale del programa
        case 11:
            Console.WriteLine("Hasta luego, Tony Stark."); // mensajito de despedida 
            break;

        default:
            Console.WriteLine("Opción no válida, intente nuevamente."); // mensajito de error si la opción es incorrecta
            break;
    }

} while (opcion != 11); // el bucle do-while se repite hasta que el usuario ingrese "11"































