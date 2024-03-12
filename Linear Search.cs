using System;
namespace Practices
{
	public class Linear_Search
	{
		public Linear_Search()
		{
            int i, flag;
            int NumberOfElements;
            double RequestedElement;


            Console.WriteLine("Digite el número de elementos a ser introducidos");
            NumberOfElements = Convert.ToInt32(Console.ReadLine());

            double[] Elements = new double[NumberOfElements];

            for (i = 0; i < NumberOfElements; i++)
            {
                Console.WriteLine("Digite los elementos a añadir");
                Elements[i] = Convert.ToDouble(Console.ReadLine());

            }


            Console.WriteLine("Digite el elemento a ser buscado");
            RequestedElement = Convert.ToDouble(Console.ReadLine());

            flag = 0;

            for (i = 0; i < NumberOfElements; i++)
            {

                if (RequestedElement == Elements[i])
                {
                    Console.WriteLine("El elemento " + RequestedElement + " ha sido hallado en la posición: " + i++);
                    flag = 1;
                }

            }

            if (flag == 0)
                Console.WriteLine("El elemento no se ha encontrado");
        }
	}
}

