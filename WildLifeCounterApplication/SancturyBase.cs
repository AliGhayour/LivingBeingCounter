using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class SancturyBase
    {
        protected string _name;
        protected int _count;

        public SancturyBase(string name, int count)
        {
            this._name = name;
            this._count = count;
        }

        public abstract int CalculateTotalCount();
    }


    public interface ISancturyOperations
    {
        void Add(SancturyBase sanctury);
        void Remove(SancturyBase sanctury);
    }


    public class CompositeSanctury : SancturyBase, ISancturyOperations
    {
        private List<SancturyBase> _sancturies;

        public CompositeSanctury(string name, int count)
            : base(name, count)
        {
            _sancturies = new List<SancturyBase>();
        }

        public void Add(SancturyBase sanctury)
        {
            _sancturies.Add(sanctury);
        }

        public void Remove(SancturyBase sanctury)
        {
            _sancturies.Remove(sanctury);
        }

        public override int CalculateTotalCount()
        {
            int total = 0;

            Console.WriteLine($"{_name} contains the following livingBeings with counts:");

            foreach (var sanctury in _sancturies)
            {
                total += sanctury.CalculateTotalCount();
            }

            return total;
        }

        public class SingleSanctury : SancturyBase
        {
            public SingleSanctury(string name, int count)
                : base(name, count)
            {
            }

            public override int CalculateTotalCount()
            {
                Console.WriteLine($"{_name} with the count {_count}");

                return _count;
            }
        }
    }
}
