namespace LeetCode.Matrix
{
    //73. Set Matrix Zeroes    public class MatrixZeroes
    public class MatrixSetZeroes
    {
        //Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's, and return the matrix.
        public void SetZeroes(int[][] matrix)
        {
            bool zeroInFirstCol = false;
            for (int row = 0; row < matrix.Length; row++)
            {
                if (matrix[row][0] == 0){
                    zeroInFirstCol = true;
                }
                for (int col = 1; col < matrix[row].Length; col++)
                {

                    if (matrix[row][col] == 0)
                    {
                        matrix[0][col] = 0;
                        matrix[row][0] = 0;
                    }
                }
            }
            for (int row = 1; row < matrix.Length; row++){
                for (int col = 1; col < matrix[row].Length; col++){
                    if (matrix[row][0] == 0 || matrix[0][col] == 0){
                        matrix[row][col] = 0;
                    }
                }
            }

            if (matrix[0][0] == 0){
                for (int j = 0; j < matrix[0].Length; j++){
                    matrix[0][j] = 0;
                }
            }

            if (zeroInFirstCol){
                for (int i = 0; i < matrix.Length; i++){
                    matrix[i][0] = 0;
                }
            }
        }

        public int[][] example1(){
            var matrix = new int[3][];
            matrix[0] = new int[]{ 1, 1, 1};
            matrix[1] = new int[]{ 1, 0, 1};
            matrix[2] = new int[]{ 1, 1, 1};

            return matrix;
        }

        public int[][] example2(){
            var matrix = new int[3][];
            matrix[0] = new int[]{ 0, 1, 2, 0};
            matrix[1] = new int[]{ 3, 4, 5, 2};
            matrix[2] = new int[]{ 1, 3, 1, 5};
            return matrix;
        }
    }
}