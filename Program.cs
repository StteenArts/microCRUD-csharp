// Importing ours model class
using Models.Pascients;

// We need initializar ours instance of class
PascientService service = new PascientService();

string name;
string code;
string symptoms;
int year;


// Here we have the list of pascients
List<Pascients> pascients = new List<Pascients> ();
bool cycle = true;

while (cycle)
{
    Console.WriteLine("");
    Console.WriteLine("*** Welcome to Clinic Heart!***");
    Console.WriteLine("1. Registrar Pasciente...");
    Console.WriteLine("2. Listar Pascientes...");
    Console.WriteLine("3. Buscar Pasciente...");
    Console.WriteLine("4. salir...");
    Console.Write(">: ");
    string choise = Console.ReadLine()!;
    bool option = int.TryParse(choise, out int choiseInt);
    
    // Validation to know if the writter by users is one number
    if (option == false)
    {
        Console.WriteLine("Porfavor digite un valor valido del menú y no letras!");
        continue;
    }
    
    // In case that is true we storage the value to ours cycle
    int choose = int.Parse(choise);
    switch (choose)
    {
        // Questions for register pascient
        case 1:
            Console.WriteLine("Porfavor digite lo que solicita:");
            // Register of pascients
            Console.Write("Nombre del pasciente: ");
            name = Console.ReadLine()!;

            Console.Write("Digite su edad: ");
            year = int.Parse(Console.ReadLine()!);
            
            Console.Write("Documento del pasciente: ");
            code = Console.ReadLine()!;

            Console.Write("Describa los sintomas del pasciente: ");
            symptoms = Console.ReadLine()!;
            
            pascients.Add(new Pascients(name, year, symptoms, code));

            break;
        case 2:
            Console.WriteLine("Lista de Pascientes");
            Console.WriteLine("");

            service.listPascient(pascients);
            
            Console.WriteLine("");
            break;
        case 3:
            // Looking for the pascient
            Console.WriteLine("Escriba el documento del pasciente");
            Console.Write(">: ");
            string codeToSearch = Console.ReadLine()!;
            
            service.searchPascient(codeToSearch, pascients);
            
            break;
        case 4:
            // Option to exist to the system
            Console.WriteLine("Cerrando el sistema, Hasta luego!....");
            // For close the cycle declared the variable false
            cycle = false;
            
            break;
        default:
            Console.WriteLine("Porfavor seleccione una opción valida ");
            continue;
        
    }
}
