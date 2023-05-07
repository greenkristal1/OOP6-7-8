using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_4._1n
{
    class Storage
    {
        private Base[] arr;
        private int size;

        public Storage(int size)
        {

            arr = new Base[size];
            this.size = size;
        }
        ~Storage()
        {

        }
        public int getCount()
        {
            return size;
        }
        public void setObject(int index, Base o)
        {
            if (index < size && index >= 0 && arr[index] == null)
                arr[index] = o;
            else if (index >= 0)
            {

                Base[] temp = new Base[size + 1];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = arr[i];

                }
                temp[size] = o;
                size++;
                arr = temp;

            }
        }
        public void setObject(Base o)
        {
            bool found = false;
            for (int i = 0; i < getCount(); i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = o;
                    found = true;
                    break;


                }
            }
            if (found == false)
            {
                Base[] temp = new Base[size + 1];
                for (int i = 0; i < size; i++)
                {
                    temp[i] = arr[i];

                }
                temp[size] = o;
                size++;
                arr = temp;
            }
        }
        public Base getObject(int index)
        {

            return arr[index];

        }

        public void deleteObject(int index)
        {
            if (index < size)
            {
                Base[] temp = new Base[size - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = arr[i];
                }
                size--;
                for (int i = index; i < size; i++)
                {
                    temp[i] = arr[i + 1];
                }

                arr = temp;
            }
        }
        public int countRealObjects()
        {
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] != null)
                    count++;
            }
            return count;
        }
        public Base takeOutObject(int index)
        {

            if (index < size)
            {
                Base o = arr[index];
                Base[] temp = new Base[size - 1];
                for (int i = 0; i < index; i++)
                {
                    temp[i] = arr[i];
                }
                size--;
                for (int i = index; i < size; i++)
                {
                    temp[i] = arr[i + 1];
                }

                arr = temp;
                return o;
            }
            else return null;

        }
    


}

}
