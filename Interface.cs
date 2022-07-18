using System;

namespace eight_lab_L
{
    interface softwareLtd
    {
        void websiteDesign();
        void softwareTesting();
        void appDev();
    }

    interface onlineShop
    {
        void buyItem();
        int addUser(int a);
    }

    class ApvtLtd : softwareLtd, onlineShop
    {
        public int addUser(int a)
        {
            int totaluser = 0;
            int adduser = totaluser + a;
            return adduser;
        }

        public void appDev()
        {
            Console.WriteLine("App is developed");
        }

        public void buyItem()
        {
            Console.WriteLine("Item is bought");

        }

        public void softwareTesting()
        {
            Console.WriteLine("Software is tested");

        }

        public void websiteDesign()
        {
            Console.WriteLine("Website is developed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ApvtLtd com = new ApvtLtd();
            com.websiteDesign();
            com.appDev();
            com.softwareTesting();
            com.buyItem();
            Console.WriteLine("The total number of user of the website is " + com.addUser(2));

            /*
            try
            {
                double sum1 = Convert.ToDouble(Console.ReadLine());
                double sum2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(sum1 / sum2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
        }
    }
}
