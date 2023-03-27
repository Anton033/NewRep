using System;
namespace Test1.HW10
{
	public class Generic<T>
	{
		public T[] data;

		public Generic()
		{
			data = new T[0];
		}

		public int Length
		{
			get { return data.Length; }
		}

		public void AddToArray(T item)
		{
			T[] newData = new T[data.Length + 1];
			data.CopyTo(newData, 0);
			newData[data.Length] = item;
			data = newData;
		}

		public void RemoveFromArray(int index)
		{
			T[] newData = new T[data.Length - 1];
			for (int i = 0; i < index; i++)
			{
				newData[i] = data[i];
			}
			for (int i = index + 1; i < data.Length; i++)
			{
				newData[i - 1] = data[i];
			}
			data = newData;
		}

		public T GetArrayItem(int index)
		{
			return data[index];
		}
	}
}

