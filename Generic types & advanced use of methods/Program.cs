﻿//var numbers = new SimpleList<int>();
//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);
//numbers.Add(40);
//numbers.Add(50);

//numbers.RemoveAt(2);

//var words = new SimpleList<string>();
//words.Add("aaa");
//words.Add("bbb");
//words.Add("ccc");

//var dates = new SimpleList<DateTime>();
//dates.Add(new DateTime(2025,1,6));
//dates.Add(new DateTime(2025, 1, 3));


//Console.ReadKey();


//class SimpleList<T>
//{
//	private T[] _items = new T[4];
//	private int _size = 0;

//	public void Add(T item)
//	{
//		if (_size >= _items.Length)
//		{
//			var newItems = new T[_items.Length * 2];

//			for (int i = 0; i < _items.Length; i++)
//			{
//				newItems[i] = _items[i];
//			}
//			_items = newItems;
//		}
//		_items[_size] = item;
//		++_size;
//	}

//	public void RemoveAt(int index)
//	{
//		if (index < 0 || index > _size)
//		{
//			throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//		}

//		--_size;

//		for (int i = index; i < _size; ++i)
//		{
//			_items[i] = _items[i + 1];
//		}

//		_items[_size] = default(T);


//	}

//	public T GetAtIndex(int index)
//	{
//		if (index < 0 || index >= _size)
//		{
//			throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//		}

//		return _items[index];
//	}
//}

//class ListOfInts
//{
//	private int[] _items = new int[4];
//	private int _size = 0;

//	public void Add(int item)
//	{
//		if (_size >= _items.Length)
//		{
//			var newItems = new int[_items.Length * 2];

//			for (int i = 0; i < _items.Length; i++)
//			{
//				newItems[i] = _items[i];
//			}
//			_items = newItems;
//		}
//		_items[_size] = item;
//		++_size;
//	}

//	public void RemoveAt(int index)
//	{
//		if (index < 0 || index > _size)
//		{
//			throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//		}

//		--_size;

//		for (int i = index; i < _size; ++i)
//		{
//			_items[i] = _items[i + 1];
//		}

//		_items[_size] = 0;
//	}

//	public int GetAtIndex(int index)
//	{
//		if (index < 0 || index >= _size)
//		{
//			throw new IndexOutOfRangeException($"Index {index} is outside the bounds of the list.");
//		}

//		return _items[index];
//	}
//}


var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
TwoInts minAndMax = GetMinAndMax(numbers);
Console.WriteLine("Smallest number is " + minAndMax.Int1);
Console.WriteLine("Largest number is " + minAndMax.Int2);

Console.ReadKey();

TwoInts GetMinAndMax(IEnumerable<int> input)
{
	if (!input.Any())
	{
		throw new InvalidOperationException($"The input collection cannot be empty.");
	}
	int min = input.First();
	int max = input.First();

	foreach (var number in input)
	{
		if (number > max)
		{
			max = number;
		}
		if (number < min)
		{
			min = number;
		}
	}

	return new TwoInts(min, max);

}

public class TwoInts
{
	public TwoInts(int int1, int int2)
	{
		Int1 = int1;
		Int2 = int2;
	}
	public int Int1 { get; }
	public int Int2 { get; }
}

public class TwoStrings
{
	public TwoStrings(string string1, string string2)
	{
		String1 = string1;
		String2 = string2;
	}
	public string String1 { get; }
	public string String2 { get; }
}