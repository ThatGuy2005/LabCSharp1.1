using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Thread = System.Threading.Thread;

namespace LabCSharp1._1
{
    internal class MyThread
    {
        public MyThread(int id)
        {
            this.id = id;
            myThread = new Thread(Run);
            myThread.Start();
            MessageBox.Show("Thread " + id + " is running.");
        }

        public void Run()
        {
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
            }
            MessageBox.Show("Thread " + id + " has finished running.");
        }
        Thread myThread;
        int id;
    }
}
