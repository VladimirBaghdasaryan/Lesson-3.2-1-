namespace Lesson_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Կազմել բլոկ-սխեմա և ծրագիր, որոնք կհաշվեն և կտպեն տրված ո տարրեր պարունակող միաչափ զանգվածի


            //211.դրական տարրերի միջին թվաբանականը:

            //int[] arr = { 2, -4, 14, -56, 28, 57 };

            //int qanak = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        qanak++;
            //        sum += arr[i];

            //    }

            //}
            //Console.WriteLine((double)sum / qanak);


            //212.դրական տարրերի միջին քառակուսայինը:
            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        
            //        sum += Math.Pow(arr[i], 2); 
            //        qanak++;

            //    }

            //}
            //Console.WriteLine(Math.Sqrt(sum / qanak));


            //213.բացասական տարրերի միջին քառակուսայինը:

            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        qanak++;
            //        sum += Math.Pow(arr[i], 2); ;

            //    }

            //}
            //Console.WriteLine(Math.Sqrt(sum / qanak));

            //214.բացասական տարրերի միջին թվաբանականը:

            //int qanak = 0;
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        qanak++;
            //        sum += arr[i];

            //    }

            //}
            //Console.WriteLine((double)sum / qanak);

            //215.զույգ ինդեքս ունեցող տարրերի գումարը: 

            //int sum=0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i%2==0)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //216.զույգ ինդեքս ունեցող տարրերի արտադրյալը:

            //int sum=1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i%2==0)
            //    {
            //        sum *= arr[i];
            //    }
            //}
            //Console.WriteLine(sum);


            //217.կենտ ինդեքս ունեցող տարրերի քառակուսիների արտադրյալը:

            //int sum = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum *= Convert.ToInt32(Math.Pow(arr[i],2));
            //    }
            //}
            //Console.WriteLine(sum);

            //218.կենտ ինդեքս ունեցող տարրերի բացարձակ արժեքների գումարը:

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += Math.Abs(arr[i]);
            //    }
            //}
            //Console.WriteLine(sum);

            //219.տրված թվին բազմապատիկ ինդեքս ունեցող տարրերի քանակը:

            //int qanak=0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i]%i==0)
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);

            //220.դրական և բացասական տարրերի քանակը:

            //int drakan = 0;
            //int bacasakan = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]>0)
            //    {
            //        drakan++;
            //    }
            //    else if(arr[i] < 0)
            //    {
            //        bacasakan++;
            //    }
            //}

            //Console.WriteLine($"Drkan tveri qanak: {drakan}\nBacasakan tveri qnak: {bacasakan}");

            //221.տրված(a;b ) միջակայքին պատկանող տարրերի գումարը:

            //int sum = 0;
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    if ((a >= 0 && a <= arr.Length) && b <= arr.Length)
            //    {
            //        sum += arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //222.տրված(c; d ) միջակայքին պատկանող տարրերի արտադրյալը:


            //int sum = 1;
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //for (int i = c; i <= d; i++)
            //{
            //    if ((c>0  && c<= arr.Length) && d <= arr.Length)
            //    {
            //        sum *= arr[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //223.տրված(a; b ) միջակայքին պատկանող տարրերի քանակը:

            //int qanak = 0;
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <=b; i++)
            //{
            //    if ((a >= 0 && a <= arr.Length) && b <= arr.Length)
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);

            //224.այն տարրերի խորանարդների գումարը, որոնք բացարձակ արժեքով փոքր են տրված k թվից:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Math.Abs(arr[i])<k)
            //    {
            //        sum += Convert.ToInt32(Math.Pow(arr[i], 3));
            //    }
            //}

            //Console.WriteLine(sum);

            //225.այն տարրերի արտադրյալը, որոնք բացարձակ արժեքով փոքր ենտրված թվից:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int sum = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Math.Abs(arr[i]) < k)
            //    {
            //        sum *= arr[i];
            //    }
            //}

            //Console.WriteLine(sum);

            //226.այն տարրերի քանակը, որոնք բացարձակ արժեքով փոքր են տրված k թվից:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Math.Abs(arr[i]) < k)
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);


            //227.այն տարրերի միջին թվաբանականը, որոնց ինդեքսը բազմապատիկ է տրված ամբողջ թվին:
            //int k = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int qanak=0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i%k==0)
            //    {
            //        sum += arr[i];
            //        qanak++;
            //    }
            //}

            //Console.WriteLine(sum/qanak);


            //28.այն տարրերի գումարը, որոնց ինդեքսը առանց մնացորդի բաժանվում է տրված ամբողջ թվի վրա:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (i % k == 0)
            //    {
            //        sum += arr[i];

            //    }
            //}

            //Console.WriteLine(sum);


            //229.այն տարրերի արտադրյալը, որոնց արժեքի և ինդեքսի տարբերությունը դրական թիվ է:


            //int sum = 1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]-i>0)
            //    {
            //        sum *= arr[i];

            //    }
            //}

            //Console.WriteLine(sum);

            //230.այն տարրերի միջին քառակուսայինը, որոնց ամբողջ մասը բազմապատիկ է տրված ամբողջ թվին:
            //int k = Convert.ToInt32(Console.ReadLine());
            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%k==0)
            //    {
            //        qanak++;
            //        sum += Math.Pow(arr[i], 2); 

            //    }

            //}
            //Console.WriteLine(Math.Sqrt(sum / qanak));


            //Կազմել բլոկ-սխեմա և ծրագիր, որոնք կհաշվեն և կտպեն ո հատ ամբողք տիպի տարրեր պարունակող 
            //միաչափ զանգվածի

            //int[] arr = { 4, -20, 34, -56, 12, 57,19};

            //231.զույգ արժեք ունեցող տարրերի քառակուսիների գումարը:

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]%2==0)
            //    {
            //        sum += Convert.ToInt32(Math.Pow(arr[i], 2));
            //    }
            //}
            //Console.WriteLine(sum);

            //232.զույգ արժեք ունեցող տարրերի քանակը: 

            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);

            //233.զույգ արժեք ունեցող տարրերի արտադրյալը և գումարը:


            //int artadrial = 1;
            //int gumar = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        artadrial *= arr[i];
            //        gumar += arr[i];
            //    }
            //}
            //Console.WriteLine($"artadrial: {artadrial}\ngumar: {gumar}");

            //234.կենտ արժեք ունեցող տարրերի միջին թվաբանականը:
            //int qanak=0;
            //double sum=0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        sum += arr[i];
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(sum/qanak);

            //235.կենտ արժեք ունեցող տարրերի միջին քառակուսայինը:

            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {

            //        sum += Math.Pow(arr[i], 2);
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(sum / qanak);

            //236.կենտ արժեք ունեցող տարրերի քանակը և արտադրյալը:


            //int artadrial = 1;
            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 != 0)
            //    {
            //        artadrial *= arr[i];
            //        qanak++;
            //    }
            //}
            //Console.WriteLine($"artadrial: {artadrial}\nqanak: {qanak}");

            //237.զրո արժեք ունեցող տարրերի քանակը:


            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 0)
            //    {

            //        qanak++;
            //    }
            //}
            //Console.WriteLine($"qanak: {qanak}");

            //238.3 - ին բազմապատիկ տարրերի միջին թվաբանականը:

            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 3 != 0)
            //    {
            //        sum += arr[i];
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(sum / qanak);

            //239.5 - ին բազմապատիկ տարրերի միջին քառակուսայինը:


            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 5 == 0)
            //    {

            //        sum += Math.Pow(arr[i], 2);
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(sum / qanak);

            //240. 7 - ին բազմապատիկ տարրերի քանակը:

            //int qanak = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 7 == 0)
            //    { 
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);

            //241.տրված k թվին բազմապատիկ տարրերի գումարը:


            //int k=Convert.ToInt32(Console.ReadLine());
            //int gumar = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % k == 0)
            //    {

            //        gumar += arr[i];
            //    }
            //}
            //Console.WriteLine($"gumar: {gumar}");

            //242.տրված թվին բազմապատիկ տարրերի արտադրյալը:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int artadrial = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % k == 0)
            //    {

            //        artadrial *= arr[i];
            //    }
            //}
            //Console.WriteLine($"artadrial: {artadrial}");

            //243.տրված m թվին բազմապատիկ տարրերի քանակը:

            //int m = Convert.ToInt32(Console.ReadLine());
            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % m == 0)
            //    {

            //        qanak++;
            //    }
            //}
            //Console.WriteLine($"qanak: {qanak}");

            //244.այն տարրերի արտադրյալը, որոնք 5 - ի բաժանելիս կմնա 2 մնացորդ:

            //int artadrial = 1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 5 == 2)
            //    {

            //        artadrial *= arr[i];
            //    }
            //}
            //Console.WriteLine($"artadrial: {artadrial}");

            //245.այն տարրերի քառակուսիների գումարը, որոնց արժեքների և ինդեքսների գումարը 
            //    առանց մնացորդի բաժանվում է 3 - ի: 


            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if ((arr[i] + i)%3==0)
            //    {

            //        sum += Math.Pow(arr[i], 2);

            //    }
            //}
            //Console.WriteLine(sum);

            //246.այն տարրերի միջին թվաբանականը, որոնց ինդեքսը որևէ բնական թվի քառակուսի է:





            //247.այն տարրերի միջին քառակուսայինը, որոնց արժեքը մեծ է ինդեքսի արժեքից:

            //int qanak = 0;
            //double sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > i)
            //    {

            //        sum += Math.Pow(arr[i], 2);
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(sum / qanak);



            //248.այն տարրերի գումարը, որոնց արժեքի և ինդեքսի գումարի քառակուսին առանց մնացորդի
            //    բաժանվում է տրված ամբողջ թվին: 

            //int k = Convert.ToInt32(Console.ReadLine());
            //int gumar = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if ((Math.Pow((arr[i] + i),2))% k == 0)
            //    {

            //        gumar += arr[i];
            //    }
            //}
            //Console.WriteLine($"gumar: {gumar}");

            //249.այն տարրերի քանակը, որոնց արժեքի և ինդեքսի տարբերությունը բացարձակ արժեքով մեծ է տրված թվից:

            //int k = Convert.ToInt32(Console.ReadLine());
            //int qanak = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (Math.Abs((arr[i]-i)) >k)
            //    {
            //        qanak++; 
            //    }
            //}
            //Console.WriteLine($"qanak: {qanak}");

            //250.այն տարրերի քառակուսիների արտադրյալը, որոնց արժեքների և ինդեքսների արտադրյալը 3 - ի
            //    բաժանելիս կմնա 2 մնացորդ:

            //int sum=1;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if ((arr[i] *i)%3==2)
            //    {
            //        sum *= Convert.ToInt32(Math.Pow(arr[i],2));
            //    }
            //}
            //Console.WriteLine(sum);



            //Կազմել բլոկ-սխեմա և ծրագիր, որոնք կհաշվեն և կտպեն ո հատ ամբողք տիպի 
            //    տարրեր պարունակող միաչափ զանգվածի

            //int[] arr = { 2, -30, 335, -16, 18, 62, 7 };

            //251.մեծագույն տարրը:

            //int max = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i]>max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(max);

            //252.փոքրագույն տարրը:

            //int min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine(min);

            //253.մեծագույն և փոքրագույն տարրերի գումարը:

            //int max = arr[0];
            //int min= arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    else if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(min+max);

            //254.մեծագույն և փոքրագույն տարրերի արտադրյալը:

            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //    else if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(min * max);

            //255.մեծագույն տարրի և իր համարի գումարը(ենթադրվում է, որ զանգվածում կա միայն մեկ մեծագույն տարր): 

            //int max = arr[0];
            //int index = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        index = i;
            //    }
            //}
            //Console.WriteLine(max + index);

            //256.փոքրագույն տարրի և իր համարի գումարը(ենթադրվում է, որ զանգվածում կա միայն մեկ փոքրագույն տարր):

            //int min = arr[0];
            //int index = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        index = i;
            //    }
            //}
            //Console.WriteLine(min + index);

            //257.առաջին մեծագույն տարրի համարը:


            //int max = arr[0];
            //int index = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index);

            //258.վերջին մեծագույն տարրի համարը

            //int max = arr[0];
            //for (int i = arr.Length-1; i >0 ; i--)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        break;
            //    }
            //}
            //Console.WriteLine(max);

            //259.առաջին փոքրագույն տարրի համարը:


            //int min = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        break;
            //    }
            //}
            //Console.WriteLine(min);

            //260.վերջին փոքրագույն տարրի համարը:

            //int min = arr[0];
            //int index = 0;
            //for (int i = arr.Length-1; i >0; i--)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        index = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(index);


            //Տրված են ո ամբողջ թիվը և ո տարրեր պարունակող X և Y միաչափ զանգվածները: 
            //    Կազմել բլոկ-սխեմա և ծրագիր, որոնք կհաշվեն և կտպեն
            //int n = 7;
            //int[] x = { 2, -30, 3, -16, 18, 62, 7 };
            //int[] y = { 5, -15, 222, -18, 45, 9, -12 };

            //261.տրված զանգվածների տարրերի միջին թվաբանականների արտադրյալը:

            //int sumX = 0;
            //int sumY = 0;

            //foreach (var item in x)
            //{
            //    sumX += item;
            //} 

            //foreach (var item in y)
            //{
            //    sumY += item;
            //}

            //Console.WriteLine((sumX/n)*(sumY/n));

            //262.տրված զանգվածների տարրերի միջին քառակուսայինների գումարը:

            //int sumX = 0;
            //int sumY = 0;

            //foreach (var item in x)
            //{
            //    sumX += Convert.ToInt32(Math.Pow(item, 2));
            //}

            //foreach (var item in y)
            //{
            //    sumY += Convert.ToInt32(Math.Pow(item,2));
            //}

            //Console.WriteLine((sumX / n) + (sumY / n));


            //263.տրված զանգվածների դրական տարրերի ընդհանուր քանակը:

            //int X = 0;
            //int Y = 0;
            //foreach (var item in x)
            //{
            //    if (item > 0)
            //    {
            //        X++;
            //    }
            //}

            //foreach (var item in y)
            //{
            //    if (item > 0)
            //    {
            //        Y++;
            //    }
            //}

            //Console.WriteLine(X + Y);

            //264.տրված զանգվածների բացասական տարրերի քանակները:

            //int X = 0;
            //int Y = 0;
            //foreach (var item in x)
            //{
            //    if (item < 0)
            //    {
            //        X++;
            //    }
            //}

            //foreach (var item in y)
            //{
            //    if (item < 0)
            //    {
            //        Y++;
            //    }
            //}

            //Console.WriteLine(X + Y);

            //265.X զանգվածի տարրերի գումարի հարաբերությունը Y զանգ վա ծի տարրերի արտադրյալին(ենթադրվում է, 
            //    որ Y զանգվածը չի պարունակում զրոյին հավասար տարր):

            //int sumX = 0;
            //int sumY = 1;

            //foreach (var item in x)
            //{
            //    sumX += item;
            //}

            //foreach (var item in y)
            //{
            //    sumY *= item;
            //}

            //Console.WriteLine(sumX-sumY);

            //266.X զանգվածի կենտ արժեք ունեցող տարրերի և Y զանգվածի զույգ արժեք ունեցող տարրերի 
            //    գումարների տարբերությունը:

            //int sumX = 0;
            //int sumY = 0;

            //foreach (var item in x)
            //{
            //    if (item%2!=0)
            //    {
            //        sumX += item;
            //    }
            //}

            //foreach (var item in y)
            //{

            //    if (item % 2 == 0)
            //    {
            //        sumY += item;
            //    }
            //}

            //Console.WriteLine(sumX - sumY);

            //267.տրված զանգվածների 7 - ին բազմապատիկ տարրերի ընդհանուր գումարը:

            //int sumX = 0;
            //int sumY = 0;

            //foreach (var item in x)
            //{
            //    if (item % 7== 0)
            //    {
            //        sumX += item;
            //    }
            //}

            //foreach (var item in y)
            //{

            //    if (item % 7 == 0)
            //    {
            //        sumY += item;
            //    }
            //}

            //Console.WriteLine(sumX + sumY);

            //269.X զանգվածի զույգ ինդեքս ունեցող և Y զանգվածի կենտ ինդեքս ունեցող տարրերի ընդհանուր գումարը:

            //int sumX = 0;
            //int sumY = 0;

            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i%2==0)
            //    {
            //        sumX+= x[i];
            //    }
            //}

            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sumY += y[i];
            //    }
            //}
            //Console.WriteLine(sumX + sumY);


            //270.տրված զանգվածների տարրերի քառակուսիների ընդհանուր գումարը:


            //int sumX = 0;
            //int sumY = 0;

            //foreach (var item in x)
            //{
            //    sumX += Convert.ToInt32(Math.Pow(item,2));
            //}

            //foreach (var item in y)
            //{
            //    sumY += Convert.ToInt32(Math.Pow(item, 2));
            //}

            //Console.WriteLine(sumX + sumY);



            //Տրված են ո բնական թիվը և ո հատ սիմվոլային տիպի տարրեր պարունակող միաչափ զանգվածը:
            //    Կազմել բլոկ-սխեմա և ծրագիր, որոնք

            //char[] array = { 'a', 't', '#', ')', 'z','r','d' ,'f'};
            //int n = Convert.ToInt32(Console.ReadLine());

            //271.կհաշվեն և կտպեն այն տարրերի քանակըը.որոնց արժեքը հավասար է 'a' - ի:

            //int qanak = 0;
            //foreach (var item in array)
            //{
            //    if (item=='a')
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(qanak);


            //272.տրամաբանական փոփոխականին կվերագրեն true, եթե զանվածում կան գոնե ո / 2 հատ
            //    'b' արժեք ունեցող տարրեր, հակառակ դեպքում false: 

            //int qanak = 0;
            //bool n2 = (n / 2) == qanak;
            //foreach (var item in array)
            //{
            //    if (item == 'b')
            //    {
            //        qanak++;
            //    }
            //}
            //Console.WriteLine(n2);

            //273.կհաշվեն և կտպեն այն տարրերի ինդեքսների գումարը, որոնց արժեքը հավասար է 's-ի:

            //int index = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == 's')
            //    {
            //        index += i;
            //    }
            //}
            //Console.WriteLine(index);

            //274.կհաշվեն և կտպեն այն տարրերի ինդեքսների միջին թվաբանականը, որոնց արժեքը մեծ է 'h' - ից:

            //int sum = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > 'h')
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum/2);

            //275.կհաշվեն և կտպեն այն տարրերի քանակը, որոնց արժեքը փոքր է 'k' - ից:

            //int qanak = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > 'k')
            //    {
            //        qanak ++;
            //    }
            //}
            //Console.WriteLine(qanak );

            //276.տրամաբանական փոփոխականին կվերագրեն true արժեք, եթե զանվածի տարրերից գոնե
            //    մեկի արժեքը հավասար է 'r' - ի, հակառակ դեպքում false: Տպել 1 - ի արժեքը:

            //bool b = false;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == 'r')
            //    {
            //        b = true;
            //        break;
            //    }
            //}
            //Console.WriteLine(b);


            //277.կստանան նոր զանգված, որի տարրերը ստացվում են տրված զանգվածից 
            //    հեռացնելով'd' արժեք ունեցող տարրերը: 
            //int count = 0;
            //char[] z=new char[array.Length - count];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]!='d')
            //    {
            //        z[i] = array[i];
            //        Console.WriteLine(z[i]);

            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            //278.կստանան նոր զանգված, որի տարրերը ստացվում են տրված զանգվածի կենտ ինդես ունեցող տարրերից:

            //int count = 0;
            //char[] z = new char[array.Length - count];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] %2!=0)
            //    {
            //        z[i] = array[i];
            //        Console.WriteLine(z[i]);

            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

            //: 279.կստանան նոր զանգված, որի տարրերը ստացվում են տրված զանգվածի այն տարրերից,
            //    որոնց արժեքը մեծ է 'k' - ից: 

            //int count = 0;
            //char[] z = new char[array.Length - count];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]> 'k')
            //    {
            //        z[i] = array[i];
            //        Console.WriteLine(z[i]);

            //    }
            //    else
            //    {
            //        count++;
            //    }
            //}

           

        }

    }
}