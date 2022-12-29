namespace Loop1Tasks
{
    public static class Tasks
    {
        public static int Task1(int n, int m)
        {
            int sum = 0;

            while (n <= m)
            {
                sum = sum + ((n % 2 == 0) ? n : 0);
                n++;
            }

            return sum;
        }

        public static int Task2(int n, int m)
        {
            int sum = 0;

            while (n <= m)
            {
                sum = sum+ ((n % 2 == 0) ? 0 : n);
                n++;
            }

            return sum;
        }

        public static int Task3(int n)
        {
            int sum = 0;
            for ( ; n > 0 ; n /= 10 )
            {
                sum += n % 10;
            }
            return sum;
        }
    }
}
