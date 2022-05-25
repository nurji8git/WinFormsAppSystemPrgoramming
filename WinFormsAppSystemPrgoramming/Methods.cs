using System;
using System.Collections.Generic;

namespace WinFormsAppSystemPrgoramming
{
    public class Methods
    {
        public List<int> FillArray(int arr_length)
        {
            Random rnd = new Random();
            List<int> arr1 = new List<int>(arr_length);
            for (int i = 0; i < arr_length; i++)
            {
                arr1.Add(rnd.Next(-10, 10));
            }

            return arr1;
        }

        public int MaxIndex(List<int> arr1)
        {
            int index = 0;
            int temp = arr1[0];
            for (int i = 0; i < arr1.Count; i++)
            {
                if (temp <= arr1[i])
                {
                    temp = arr1[i];
                    index = i;
                }
            }
            return index;
        }

        public int BeforeMax(int index, List<int> arr1)
        {
            int temp = 1;
            for (int i = 0; i < index; i++)
            {
                temp = temp * arr1[i];
            }
            return temp;
        }

        public int AfterMax(int index, List<int> arr1)
        {
            int temp1 = 0;
            for (int i = index + 1; i < arr1.Count; i++)
            {
                temp1 += arr1[i];
            }
            return temp1;
        }

        public String Message(int temp, int temp1)
        {
            float val = 0f;
            try
            {
                if (temp1 == 0 || temp1 == null)
                {
                    return "Деление на ноль!";
                }
                else
                {
                    val = (float)temp / temp1;
                    return val.ToString();
                }
            }
            catch (DivideByZeroException)
            {
                return "Деление на ноль!";
            }
            
        }

        public List<int> Task2_Solution(List<int> arr1)
        {
            List<int> temp_list = new List<int>();
            int temp = 0;
            for (int i = arr1.Count - 1; i > -1; i--)
            {
                if (arr1[i] > 0 && temp < 2)
                {
                    temp++;
                }
                else if (arr1[i] <= 0 && temp < 2 && temp > 0 && i != arr1.Count - 1)
                {
                    temp = 0;
                    temp_list.Add(arr1[i + 1]);
                    temp_list.Add(arr1[i]);
                }
                else if (arr1[i] <= 0 || temp == 2)
                {
                    temp_list.Add(arr1[i]);
                }
                if (arr1.Count - temp_list.Count == 1)
                {
                    temp_list = arr1;
                    temp_list.Reverse();
                }
            }
            temp_list.Reverse();
            return temp_list;
        }

        public List<int> Task3_Solution(List<int> arr1, int input)
        {
            List<int> temp_list = new List<int>();
            bool temp = false;
            for (int i = arr1.Count - 1; i > -1; i--)
            {
                if (arr1[i] < 0 && temp == false)
                {
                    temp = true;
                    temp_list.Add(input);
                    temp_list.Add(input);
                }
                temp_list.Add(arr1[i]);
            }

            return temp_list;
        }

        public string Task4_Solution(List<int> arr1)
        {
            bool temp = false;
            int p = 0;
            foreach (int i in arr1)
            {
                if (i > 0)
                {
                    temp = true;
                    p = i;
                    break;
                }
            }
            if (temp) { return "Есть! " + p; }
            else { return "Нет!"; }
        }


    }
}
