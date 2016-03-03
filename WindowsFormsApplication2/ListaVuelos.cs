using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class ListaVuelos:List<Vuelo>
    {
    
        public void SortByDate(int start, int end)
        {

            int pivot;

            if (start < end)
            {
                pivot = divideListByDate(start, end);

                // Ordeno la lista de los menores
                SortByDate(start, pivot - 1);

                // Ordeno la lista de los mayores
                SortByDate(pivot + 1, end);
            }
        }


        public void SortBySeats(int start, int end)
        {

            int pivot;

            if (start < end)
            {
                pivot = divideListBySeats(start, end);

                // Ordeno la lista de los menores
                SortBySeats(start, pivot - 1);

                // Ordeno la lista de los mayores
                SortBySeats(pivot + 1, end);
            }
        }




        private int divideListBySeats(int start, int end)
        {
            int left;
            int right;
            Vuelo pivot;
            Vuelo temp;

            pivot = this[start];
            left = start;
            right = end;

            // Mientras no se cruzen los índices
            while (left < right)
            {
                while (this[right].getAsientosDisp() < pivot.getAsientosDisp())
                {
                    right--;
                }

                while ((left < right) && (this[left].getAsientosDisp() >= pivot.getAsientosDisp()))
                {
                    left++;
                }

                // Si todavía no se cruzan los indices seguimos intercambiando
                if (left < right)
                {
                    temp = this[left];
                    this[left] = this[right];
                    this[right] = temp;
                }
            }
                // Los índices ya se han cruzado, ponemos el pivot en el lugar que le corresponde
                temp = this[right];
                this[right] = this[start];
                this[start] = temp;

                // La nueva posición del pivot
                return right;
            }




        private int divideListByDate(int start, int end)
        {
            int left;
            int right;
            Vuelo pivot;
            Vuelo temp;

            pivot = this[start];
            left = start;
            right = end;

            // Mientras no se cruzen los índices
            while (left < right)
            {
                while (this[right].getDate() > pivot.getDate())
                {
                    right--;
                }

                while ((left < right) && (this[left].getDate() <= pivot.getDate()))
                {
                    left++;
                }

                // Si todavía no se cruzan los indices seguimos intercambiando
                if (left < right)
                {
                    temp = this[left];
                    this[left] = this[right];
                    this[right] = temp;
                }
            }

            // Los índices ya se han cruzado, ponemos el pivot en el lugar que le corresponde
            temp = this[right];
            this[right] = this[start];
            this[start] = temp;

            // La nueva posición del pivot
            return right;
        }
    }

}
