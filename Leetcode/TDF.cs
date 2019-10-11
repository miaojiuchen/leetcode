using System;
using System.Threading.Tasks.Dataflow;

namespace Leetcode
{
    public class TDF
    {
        private static BufferBlock<int> m_buffer = new BufferBlock<int>();

        private static int i;

        public void Producer()
        {
            while(true)
            {
                var x = i++;
                m_buffer.Post(x);
            }
        }

        public void Consumer()
        {
            while(true)
            {
                var x = m_buffer.Receive();
                Console.WriteLine("receive: " + x.ToString());
            }
        }

        public async void DoSomething<T>(T Block) where T : ISourceBlock<int>, ITargetBlock<int>
        {

        }

    }
}
