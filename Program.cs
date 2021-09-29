using System;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
# include <stdio.h>
            int main()
            {

                int number1, number2, sum;

                printf("Enter two integers: ");
                scanf("%d %d", &number1, &number2);

                // calculating sum
                sum = number1 + number2;

                printf("%d + %d = %d", number1, number2, sum);
                return 0;

                int main()
                {
                    long long n;
                    int count = 0;
                    printf("Enter an integer: ");
                    scanf("%lld", &n);

                    
                    do
                    {
                        n /= 10;
                        ++count;
                    } while (n != 0);

                    printf("Number of digits: %d", count);
                }
    }
}
