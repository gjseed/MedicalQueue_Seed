using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Seed
{
    class ERQueue
    {
        Queue qt = new Queue();
        public void Add(Patient queueItem)
        {
            qt.Enqueue(queueItem);
            //qt.Count;
        }

        public void Remove(Patient queueItem)
        {
            qt.Dequeue();
        }
    }
}
