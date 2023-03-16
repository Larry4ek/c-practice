using System.Collections;

namespace p1
{
    class Fil
    {
        private ArrayList list;
        public Fil()
        {
            list = new ArrayList();
        }
        public Fil(ArrayList a)
        {
            list = a;
        }
        public void Add(Time m)
        {
            list.Add(m);
        }
        public Fil Clone()
        {
            return new Fil(list);
        }
        public void RemoveAt(int i)
        {
            list.RemoveAt(i);
        }
        public void Clear()
        {
            list.Clear();
        }
        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}