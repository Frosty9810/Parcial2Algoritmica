using System;

 
public class Node

    
{
    public int data;
    public Node next;

    // Constructor para crear el nodo
    public Node(int d)
    {
        
        data = d;
        next = null;
    }
}

class BinarySearch
{
    // Funcion para insertar un valor al principio de una linked list
    
    static Node push(Node head, int data)
    {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
        return head;
    }

    // Funcion para encontrar el nodo del medio. 
    // usando punterso Slow y Fast donde slow avanza la lista cada 1 nodo y Fast avanza la lista cada 2 nodos.
    static Node middleNode(Node start, Node last)
    {
        if (start == null)
            return null;

        Node slow = start;
        Node fast = start.next;

        while (fast != last)
        {
            fast = fast.next;
            if (fast != last)
            {
                slow = slow.next;
                fast = fast.next;
            }
        }
        return slow;
    }

    
    static Node binarySearch(Node head, int value)
    {
        Node start = head;
        Node last = null;

        do
        {
            // Encontrar el medio
            Node mid = middleNode(start, last);

            // Si el medio esta vacio
            if (mid == null)
                return null;

            // Si el valor esta en el meedio 
            if (mid.data == value)
                return mid;

            // Si el medio es mayor al valor
            else if (mid.data > value)
            {
                start = mid.next;
            }

            // Si el valor es mayor al del medio 
            else
                last = mid;
        } while (last == null || last != start);

        //si no existe. 
        return null;
    }
    
    public static void Main(String[] args)
    {
        Node head = null;


        head = push(head, 1);
        head = push(head, 4);
        head = push(head, 7);
        head = push(head, 8);
        head = push(head, 9);
        head = push(head, 10);
        int value = 7;

        if (binarySearch(head, value) == null)
        {
            Console.WriteLine("Valor no presente");
        }
        else
        {
            Console.WriteLine(value);
        }
    }



}