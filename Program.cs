class quiz3 {
    static public void Main(String[] args)
    {
        while(true)
        {
            char input = char.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            float[,] matrixOne = new float[row,column];
            float[,] matrixTwo = new float[row,column];
            if(input != '+' && input != '-' )
            {
                break;
            }

            for(int rowMatrix = 0 ; rowMatrix < row; rowMatrix++)
            {
                for (int columnMatrix = 0; columnMatrix < column; columnMatrix++)
                {
                    matrixOne[rowMatrix,columnMatrix] = float.Parse(Console.ReadLine());
                }
            }

            for(int rowMatrix = 0 ; rowMatrix < row; rowMatrix++)
            {
                for (int columnMatrix = 0; columnMatrix < column; columnMatrix++)
                {
                    matrixTwo[rowMatrix,columnMatrix] = float.Parse(Console.ReadLine());
                }
            }

             for(int rowMatrix = 0 ; rowMatrix < row; rowMatrix++)
            {
                for (int columnMatrix = 0; columnMatrix < column; columnMatrix++)
                {
                    if(input == '+')
                    {
                        matrixOne[rowMatrix,columnMatrix] += matrixTwo[rowMatrix,columnMatrix];
                    }
                    else
                    {
                        matrixOne[rowMatrix,columnMatrix] -= matrixTwo[rowMatrix,columnMatrix];
                    }
                }
            }

            for(int rowMatrix = 0 ; rowMatrix < row; rowMatrix++)
            {
                for (int columnMatrix = 0; columnMatrix < column; columnMatrix++)
                {
                    Console.Write("{0} ",matrixOne[rowMatrix,columnMatrix]);
                }
                Console.WriteLine("");
            }
        }
    }

}
