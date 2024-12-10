using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShindinDN.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] columns = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                columns[i] = matrix[i, 2];
            }

            Array.Sort(columns);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, 2] = columns[i];
            }

            return matrix;
        }
    }
}
