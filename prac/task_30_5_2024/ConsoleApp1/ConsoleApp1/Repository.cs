using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Repository<T> where T : IEntity
    {
        public Guid Id { get; set; }

    

        List<T> genericList = new List<T>();

        //creating in the list
        /// <summary>
        /// add an element in the repo but enforces single type.
        /// </summary>
        /// <param name="t"></param>
        /// <exception cref="Exception"></exception>
        private void CreateAnItem(T t) {
            try
            {
                if (genericList.Count == 0 || genericList.Last().GetType() == t.GetType())
                {
                    genericList.Add(t);
                }
            }
            catch (ArgumentException ex) {
                throw new Exception($"\n--------------------\nTypeException : {ex} \n------------------\n ");
            }
          
        }

        //reading from the list
        /// <summary>
        /// will get the element with the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public void Get(Guid id)
        {
            genericList.FirstOrDefault(e => e.Id == id);
        }

        //updating in the list
        public void UpdateItem(Guid id)
        {
            try
            {
                if
            }
        }
        //deleting from the list

    }
}
