// IEnumerable
// 1. Array
// 2. List<T>
// 3. Dictionary<TKey, TValue>
// 4. LinkedList<T>
// 5. Queue<T>
// 6. Stack<T>


#region List
Console.WriteLine("*** List ***");
var names = new List<string>();
names.Add("Pedro");
names.Add("María");
names.Add("Luisa");
names.Add("Juan");
names.Add("José");

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

names.Remove("María");

foreach (string nombre in names)
{
    Console.WriteLine(nombre);
}
#endregion

#region Dictionary
Console.WriteLine("\n*** Dictionary ***");
var diccionary = new Dictionary<string, int>();

diccionary.Add("Uno", 1);
diccionary.Add("Dos", 2);
diccionary.Add("Tres", 3);

foreach (var par in diccionary)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}

if (diccionary.ContainsKey("Uno"))
{
    int value = diccionary["Uno"];
    Console.WriteLine($"El valor asociado a la clave Uno es {value}");
}
#endregion

#region LinkedList
Console.WriteLine("\n*** LinkedList ***");
var numbers = new LinkedList<int>();

numbers.AddFirst(1);
numbers.AddLast(2);
numbers.AddLast(3);
numbers.AddLast(4);
numbers.AddLast(5);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

var node2 = numbers.Find(2);
numbers.AddAfter(node2!, 6);

var node3 = numbers.Find(3);
numbers.Remove(node3!);

var lastNode = numbers.Last;
while (lastNode != null)
{
    Console.WriteLine(lastNode.Value);
    lastNode = lastNode.Previous;
}
#endregion

#region Queue
Console.WriteLine("\n*** Queue ***");
var messages = new Queue<string>();

messages.Enqueue("Primer mensaje");
messages.Enqueue("Segundo mensaje");
messages.Enqueue("Tercer mensaje");

foreach (string mensaje in messages)
{
    Console.WriteLine(mensaje);
}

string primerMensaje = messages.Peek();
Console.WriteLine("Primer mensaje en la cola: " + primerMensaje);

string mensajeEliminado = messages.Dequeue();
Console.WriteLine("Mensaje eliminado de la cola: " + mensajeEliminado);

while (messages.Count > 0)
{
    string mensaje = messages.Dequeue();
    Console.WriteLine("Mensaje eliminado de la cola: " + mensaje);
}
#endregion

#region Stack
Console.WriteLine("\n*** Stack ***");
var numbersStack = new Stack<int>();

numbersStack.Push(1);
numbersStack.Push(2);
numbersStack.Push(3);

foreach (int numero in numbersStack)
{
    Console.WriteLine(numero);
}

int ultimoNumero = numbersStack.Peek();
Console.WriteLine("Último número en la pila: " + ultimoNumero);

int numeroEliminado = numbersStack.Pop();
Console.WriteLine("Número eliminado de la pila: " + numeroEliminado);

while (numbersStack.Count > 0)
{
    int numero = numbersStack.Pop();
    Console.WriteLine("Número eliminado de la pila: " + numero);
}
#endregion