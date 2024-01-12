//var numbers = new SimpleList<int>();
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


//var numbers = new List<int> { 5, 3, 2, 8, 16, 7 };
//Tuple<int, int> minAndMax = GetMinAndMax(numbers);

//var twoStrings = new Tuple<string, string>("aaa", "bbb");
//var differentTypes = new Tuple<string, int>("aaa", 1);
//var threeItems = new Tuple<string, int, bool>("aaa", 1, false);
//Console.WriteLine("Smallest number is " + minAndMax.Item1);
//Console.WriteLine("Largest number is " + minAndMax.Item2);

//Console.ReadKey();

//Tuple<int, int> GetMinAndMax(IEnumerable<int> input)
//{
//	if (!input.Any())
//	{
//		throw new InvalidOperationException($"The input collection cannot be empty.");
//	}
//	int min = input.First();
//	int max = input.First();

//	foreach (var number in input)
//	{
//		if (number > max)
//		{
//			max = number;
//		}
//		if (number < min)
//		{
//			min = number;
//		}
//	}

//	return new Tuple<int, int>(min, max);

//}

//public class SimpleTuple<T1, T2>
//{
//	public SimpleTuple(T1 item1, T2 item2)
//	{
//		Item1 = item1;
//		Item2 = item2;
//	}
//	public T1 Item1 { get; }
//	public T2 Item2 { get; }
//}

//public class SimpleTuple<T1, T2, T3>
//{
//	public SimpleTuple(T1 item1, T2 item2, T3 item3)
//	{
//		Item1 = item1;
//		Item2 = item2;
//		Item3 = item3;
//	}
//	public T1 Item1 { get; }
//	public T2 Item2 { get; }
//	public T3 Item3 { get; }
//}

//public class TwoStrings
//{
//	public TwoStrings(string string1, string string2)
//	{
//		String1 = string1;
//		String2 = string2;
//	}
//	public string String1 { get; }
//	public string String2 { get; }
//}

//using System.Collections;
//ArrayList ints = new ArrayList { 2, 3, 4, 5 };

//int sum = 0;
//foreach (object number in ints)
//{
//	sum += (int)number;
//}
//ArrayList strings = new ArrayList { "a", "b", "c" };

//ArrayList variousItems = new ArrayList { 1, false, "abc", new DateTime() };
//object[] objects = new object[] { 1, false, "abc", new DateTime() };


//Console.ReadKey();

var ints = new List<int> { 1, 2, 3 };
ints.AddToFront(10);
ints.AddToFront(11);

Console.ReadKey();

static class ListExtension
{
	public static void AddToFront<T>(this List<T> list, T item)
	{
		list.Insert(0, item);
	}
}
