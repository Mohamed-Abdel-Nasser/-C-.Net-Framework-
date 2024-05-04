namespace ConsoleApp1
{
    public class suduko
    {

        // Atribute
        private int[,] _matrix;

        private int myVar;

        //indexcess
        public int this[int row, int col]
        {
            get

            {
                if (row < 0 || row > _matrix.GetLength(0) - 1) // GetLength(0) → return rows
                {
                    return -1;
                }

                if (col < 0 || col > _matrix.GetLength(1) - 1)// GetLength(1) → return col
                {
                    return -1;
                }
                return _matrix[row, col];

            }
            set
            {
                if (value < 1 || value > _matrix.GetLength(0))
                {
                    return;
                }
                _matrix[row, col] = value;
            }
        }

        // constractor
        public suduko(int[,] matrix)
        {
            this._matrix = matrix;
        }
    }
}
