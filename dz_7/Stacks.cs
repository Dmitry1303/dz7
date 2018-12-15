using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_7
{
    public class Stacks
    {
        // класс стэк для хранения элементов 
        private List<int> _Elements= new List<int>(0);

        public void Add(int Element)
        {
            // добавление
            _Elements.Add(Element);
        }

        public int ElementsCount
        {
            // счетчик
            get
            { return _Elements.Count; }
        }
        public void DellLast()
        {
            // удаление
            _Elements.Remove(_Elements.Last());
        }
        public int this[int index]
        {
            //вызов по индексу
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Индекс <0");
                if (index >= _Elements.Count)
                    throw new IndexOutOfRangeException("Индекс больше индекса листа");
                return _Elements[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Индекс <0");
                if (index >= _Elements.Count)
                    throw new IndexOutOfRangeException("Индекс больше индекса листа");
                _Elements[index] = value;
            }
        }
        public Stacks(List<int> Elements)
        {
            // объявление
            if (Elements == null)
                throw new NullReferenceException("Указана пустая ссылка на лист");
            _Elements = Elements;
        }
        public Stacks()
        {
            // объявление 2 
        }
    }
}
