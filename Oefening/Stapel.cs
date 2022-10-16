using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening
{
    internal class Stapel<T>
    {
        private List<T> Container = new List<T>();
        private List<T> ContainerCopy = new List<T>();
        public int teller = -1;

        public void Toevoegen(T item)
        {
            Container.Add(item); 
            
        }

        public T Verwijderen()
        {
            if (Container.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T updatedContainer = Container[Container.Count - 1];
            Container.RemoveAt(Container.Count - 1);

            return updatedContainer; 
        }

        public void Leegmaken()
        {
            Container.Clear();
        }

        public string ToString()
        {
            return String.Join(" , ", Container.ToArray()); 
        }

        public bool IsAanwezig(T item)
        {
            return Container.Contains(item); 
        }

        public Stapel<T> Copy()
        {
            // ContainerCopy = Container.GetRange(0, Container.Count);
            // return ContainerCopy

            return (Stapel<T>)this.MemberwiseClone(); 

        }

    }
}
