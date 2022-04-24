using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    class BookStoreSingleton
    {
        //To restric instance creation adding private Contructor
        static Object locks = new Object();
        private BookStoreSingleton()
        {

        }

        private static BookStoreSingleton instance;

        /*Simple singleton implementation
         * But this fails when multiple threads are trying to access it at the same time.
         */
        public static BookStoreSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new BookStoreSingleton();
            }

            return instance;
        }

        /*
         * adding Method Sync, so that only one process gets theough at a time. So even though you 
         * have made it sync and only one instance would be created but it slows down your application
         * since only one thread will get through(even afterwards, when you have the one instance created)
         * and would be able to get the instance.
         */

        [MethodImpl(MethodImplOptions.Synchronized)] // locks on the instance of the object
        public static BookStoreSingleton GetInstance1()
        {
            if (instance == null)
            {
                instance = new BookStoreSingleton();
            }
            return instance;
        }

        /*
         * This also behaves the same way above, it consistently check for lock for all calls to getInstance
         */
        public static BookStoreSingleton GetInstance2()
        {
            lock (locks)
            {
                if (instance == null)
                {
                    instance = new BookStoreSingleton();
                }
            }

            return instance;
        }

        /*
         * DOUBLE CHECK LOCKING (Recomended in this scenario)
         */

        public static BookStoreSingleton GetInstance3()
        {
            if (instance == null)// if instance allready exists the it would not suffice
            {
                lock (locks) // attain lock
                {
                    if (instance == null)// check again since another thread could have entered
                                         //and created instance
                    { instance = new BookStoreSingleton(); }
                }
            }

            return instance;
        }
    }
}
