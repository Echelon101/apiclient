﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopwareApi;
using ShopwareApi.Models.Articles;
using ShopwareApi.Resources;
using System.Threading;

namespace ApiClient
{
    class Program
    {
        public static ShopwareClient shopwareClient;
        static void Main(string[] args)
        {
            shopwareClient =  new ShopwareClient("http://localhost/shop/api", "apiuser", "ag5tA9KQVKwF1ANVJPFBplLVgSFarIvKFbWih69V");

            Thread tid1 = new Thread(new ThreadStart(Thread1));
            Thread tid2 = new Thread(new ThreadStart(Thread2));
            Thread tid3 = new Thread(new ThreadStart(Thread3));
            Thread tid4 = new Thread(new ThreadStart(Thread4));
            Thread tid5 = new Thread(new ThreadStart(Thread5));

            tid1.Start();
            tid2.Start();
            tid3.Start();
            tid4.Start();
            tid5.Start();


            Console.WriteLine("done");
            Console.ReadKey();
            
        }

        public static void Thread1()
        {
            for (int i = 1; i < 1000; i++)
            {
                shopwareClient.GetArticleResource().Delete(i.ToString());
                Console.WriteLine(string.Format("Thread1 {0}", i));
            }
        }
        public static void Thread2()
        {
            for (int i = 1000; i < 2000; i++)
            {
                shopwareClient.GetArticleResource().Delete(i.ToString());
                Console.WriteLine(string.Format("Thread2 {0}", i));
            }
        }
        public static void Thread3()
        {
            for (int i = 2000; i < 3000; i++) {
                shopwareClient.GetArticleResource().Delete(i.ToString());
                Console.WriteLine(string.Format("Thread3 {0}", i));
            }
        }
        public static void Thread4()
        {
            for (int i = 3000; i < 4000; i++) { shopwareClient.GetArticleResource().Delete(i.ToString());
                Console.WriteLine(string.Format("Thread4 {0}", i));
            }
        }
        public static void Thread5()
        {
            for (int i = 4000; i < 5000; i++) { shopwareClient.GetArticleResource().Delete(i.ToString());
                Console.WriteLine(string.Format("Thread5 {0}", i));
            }
        }
        

    }
}
