using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace berhalak.utils
{
	// http://github.com/berhalak/utils

	/// <summary>
	/// Base virtual dictionary
	/// </summary>
	/// <typeparam name="T1"></typeparam>
	/// <typeparam name="T2"></typeparam>
	[Serializable]
	public class DictionaryImpl<T1, T2> : IDictionary<T1, T2>
	{
		protected Dictionary<T1, T2> _dict = new Dictionary<T1, T2>();

		public virtual bool ContainsKey(T1 key)
		{
			return _dict.ContainsKey(key);
		}


		/// <summary>
		/// Gets or sets the value with the specified key.
		/// </summary>
		/// <value></value>
		public virtual T2 this[T1 key]
		{
			get
			{
				return _dict[key];
			}

			set
			{
				_dict[key] = value;
			}
		}

		/// <summary>
		/// Adds an element with the provided key and value to the <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </summary>
		/// <param name="key">The object to use as the key of the element to add.</param>
		/// <param name="value">The object to use as the value of the element to add.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// 	<paramref name="key"/> is null.
		/// </exception>
		/// <exception cref="T:System.ArgumentException">
		/// An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// The <see cref="T:System.Collections.Generic.IDictionary`2"/> is read-only.
		/// </exception>
		public virtual void Add(T1 key, T2 value)
		{
			_dict.Add(key, value);
		}

		/// <summary>
		/// Gets an <see cref="T:System.Collections.Generic.ICollection`1"/> containing the keys of the <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// An <see cref="T:System.Collections.Generic.ICollection`1"/> containing the keys of the object that implements <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </returns>
		public virtual ICollection<T1> Keys
		{
			get { return _dict.Keys; }
		}

		/// <summary>
		/// Removes the element with the specified key from the <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </summary>
		/// <param name="key">The key of the element to remove.</param>
		/// <returns>
		/// true if the element is successfully removed; otherwise, false.  This method also returns false if <paramref name="key"/> was not found in the original <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">
		/// 	<paramref name="key"/> is null.
		/// </exception>
		/// <exception cref="T:System.NotSupportedException">
		/// The <see cref="T:System.Collections.Generic.IDictionary`2"/> is read-only.
		/// </exception>
		public virtual bool Remove(T1 key)
		{
			return _dict.Remove(key);
		}

		/// <summary>
		/// Gets the value associated with the specified key.
		/// </summary>
		/// <param name="key">The key whose value to get.</param>
		/// <param name="value">When this method returns, the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
		/// <returns>
		/// true if the object that implements <see cref="T:System.Collections.Generic.IDictionary`2"/> contains an element with the specified key; otherwise, false.
		/// </returns>
		/// <exception cref="T:System.ArgumentNullException">
		/// 	<paramref name="key"/> is null.
		/// </exception>
		public virtual bool TryGetValue(T1 key, out T2 value)
		{
			return _dict.TryGetValue(key, out value);
		}

		/// <summary>
		/// Gets an <see cref="T:System.Collections.Generic.ICollection`1"/> containing the values in the <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// An <see cref="T:System.Collections.Generic.ICollection`1"/> containing the values in the object that implements <see cref="T:System.Collections.Generic.IDictionary`2"/>.
		/// </returns>
		public virtual ICollection<T2> Values
		{
			get { return _dict.Values; }
		}

		/// <summary>
		/// Adds an item to the <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </summary>
		/// <param name="item">The object to add to the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
		/// <exception cref="T:System.NotSupportedException">
		/// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
		/// </exception>
		public virtual void Add(KeyValuePair<T1, T2> item)
		{
			(_dict as ICollection<KeyValuePair<T1, T2>>).Add(item);
		}

		/// <summary>
		/// Removes all items from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </summary>
		/// <exception cref="T:System.NotSupportedException">
		/// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
		/// </exception>
		public virtual void Clear()
		{
			_dict.Clear();
		}

		/// <summary>
		/// Determines whether the <see cref="T:System.Collections.Generic.ICollection`1"/> contains a specific value.
		/// </summary>
		/// <param name="item">The object to locate in the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
		/// <returns>
		/// true if <paramref name="item"/> is found in the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false.
		/// </returns>
		public virtual bool Contains(KeyValuePair<T1, T2> item)
		{
			return (_dict as ICollection<KeyValuePair<T1, T2>>).Contains(item);
		}

		/// <summary>
		/// Copies the elements of the <see cref="T:System.Collections.Generic.ICollection`1"/> to an <see cref="T:System.Array"/>, starting at a particular <see cref="T:System.Array"/> index.
		/// </summary>
		/// <param name="array">The one-dimensional <see cref="T:System.Array"/> that is the destination of the elements copied from <see cref="T:System.Collections.Generic.ICollection`1"/>. The <see cref="T:System.Array"/> must have zero-based indexing.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array"/> at which copying begins.</param>
		/// <exception cref="T:System.ArgumentNullException">
		/// 	<paramref name="array"/> is null.
		/// </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		/// 	<paramref name="arrayIndex"/> is less than 0.
		/// </exception>
		/// <exception cref="T:System.ArgumentException">
		/// 	<paramref name="array"/> is multidimensional.
		/// -or-
		/// <paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.
		/// -or-
		/// The number of elements in the source <see cref="T:System.Collections.Generic.ICollection`1"/> is greater than the available space from <paramref name="arrayIndex"/> to the end of the destination <paramref name="array"/>.
		/// -or-
		/// Type <paramref name="T"/> cannot be cast automatically to the type of the destination <paramref name="array"/>.
		/// </exception>
		public virtual void CopyTo(KeyValuePair<T1, T2>[] array, int arrayIndex)
		{
			(_dict as ICollection<KeyValuePair<T1, T2>>).CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Gets the number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </summary>
		/// <value></value>
		/// <returns>
		/// The number of elements contained in the <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </returns>
		public virtual int Count
		{
			get { return _dict.Count; }
		}

		/// <summary>
		/// Gets a value indicating whether the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
		/// </summary>
		/// <value></value>
		/// <returns>true if the <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only; otherwise, false.
		/// </returns>
		public virtual bool IsReadOnly
		{
			get { return (_dict as ICollection<KeyValuePair<T1, T2>>).IsReadOnly; }
		}

		/// <summary>
		/// Removes the first occurrence of a specific object from the <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </summary>
		/// <param name="item">The object to remove from the <see cref="T:System.Collections.Generic.ICollection`1"/>.</param>
		/// <returns>
		/// true if <paramref name="item"/> was successfully removed from the <see cref="T:System.Collections.Generic.ICollection`1"/>; otherwise, false. This method also returns false if <paramref name="item"/> is not found in the original <see cref="T:System.Collections.Generic.ICollection`1"/>.
		/// </returns>
		/// <exception cref="T:System.NotSupportedException">
		/// The <see cref="T:System.Collections.Generic.ICollection`1"/> is read-only.
		/// </exception>
		public virtual bool Remove(KeyValuePair<T1, T2> item)
		{
			return (_dict as ICollection<KeyValuePair<T1, T2>>).Remove(item);
		}


		/// <summary>
		/// Returns an enumerator that iterates through the collection.
		/// </summary>
		/// <returns>
		/// A <see cref="T:System.Collections.Generic.IEnumerator`1"/> that can be used to iterate through the collection.
		/// </returns>
		public virtual IEnumerator<KeyValuePair<T1, T2>> GetEnumerator()
		{
			return _dict.GetEnumerator();
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
		/// </returns>
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return _dict.GetEnumerator();
		}
	}

	[Serializable]
	public class Cube<T1, T2> : DictionaryImpl<T1, T2>
	{
		private bool _initialized = false;
		private T2 _nullValue;

		public virtual IEnumerable<T1> GetKeyEnumerator()
		{
			foreach (T1 key in _dict.Keys)
			{
				yield return key;
			}

			if (_initialized)
				yield return default(T1);
		}

		public override bool ContainsKey(T1 key)
		{
			if (key == null)
				return _initialized;
			return base.ContainsKey(key);
		}

		public override T2 this[T1 key]
		{
			get
			{
				if (key == null)
				{
					if (_initialized == false)
					{
						return _dict[key];
					}
					return _nullValue;
				}
				else
				{
					return _dict[key];
				}
			}

			set
			{
				if (key == null)
				{
					_nullValue = value;
					_initialized = true;
				}
				else
				{
					_dict[key] = value;
				}
			}
		}
	}

	[Serializable]
	public class CubeXD<T1, T2> : Cube<T1, T2> where T2 : new()
	{
		public override T2 this[T1 key]
		{
			get
			{
				if (this.ContainsKey(key) == false) base[key] = new T2();
				return base[key];
			}
		}
	}

	[Serializable]
	public class Cube<T1, T2, T3> : CubeXD<T1, Cube<T2, T3>> { }

	[Serializable]
	public class Cube<T1, T2, T3, T4> : CubeXD<T1, CubeXD<T2, Cube<T3, T4>>> { }

	[Serializable]
	public class Cube<T1, T2, T3, T4, T5> : CubeXD<T1, CubeXD<T2, CubeXD<T3, Cube<T4, T5>>>> { }

	[Serializable]
	public class Cube<T1, T2, T3, T4, T5, T6> : CubeXD<T1, CubeXD<T2, CubeXD<T3, CubeXD<T4, Cube<T5, T6>>>>> { }

	/// <typeparam name="T7"></typeparam>
	[Serializable]
	public class Cube<T1, T2, T3, T4, T5, T6, T7> : CubeXD<T1, CubeXD<T2, CubeXD<T3, CubeXD<T4, CubeXD<T5, Cube<T6, T7>>>>>> { }

	[Serializable]
	public class MultiCube<T1, T2> : Cube<T1, List<T2>>
	{
		public override List<T2> this[T1 key]
		{
			get
			{
				if (!base.ContainsKey(key))
					base[key] = new List<T2>();
				return base[key];
			}
			set
			{
				base[key] = value;
			}
		}
	}

	[Serializable]
	public class MultiCube<T1, T2, T3> : CubeXD<T1, MultiCube<T2, T3>> { }

	[Serializable]
	public class MultiCube<T1, T2, T3, T4> : CubeXD<T1, CubeXD<T2, MultiCube<T3, T4>>> { }

	[Serializable]
	public class MultiCube<T1, T2, T3, T4, T5> : CubeXD<T1, CubeXD<T2, CubeXD<T3, MultiCube<T4, T5>>>> { }


	[Serializable]
	public class MultiCube<T1, T2, T3, T4, T5, T6> : CubeXD<T1, CubeXD<T2, CubeXD<T3, CubeXD<T4, MultiCube<T5, T6>>>>> { }

	[Serializable]
	public class MultiCube<T1, T2, T3, T4, T5, T6, T7> : CubeXD<T1, CubeXD<T2, CubeXD<T3, CubeXD<T4, CubeXD<T5, MultiCube<T6, T7>>>>>> { }


	[Serializable]
	public class DefaultCube<W1, V> : Cube<W1, V>
	{
		public override V this[W1 key]
		{
			get
			{
				if (base.ContainsKey(key)) return base[key];
				else return default(V);
			}
			set
			{
				base[key] = value;
			}
		}
	}
	[Serializable]
	public class DefaultCube<W2, W1, V> : CubeXD<W2, DefaultCube<W1, V>> { }

	[Serializable]
	public class DefaultCube<W3, W2, W1, V> : CubeXD<W3, CubeXD<W2, DefaultCube<W1, V>>> { }

	[Serializable]
	public class DefaultCube<W4, W3, W2, W1, V> : CubeXD<W4, CubeXD<W3, CubeXD<W2, DefaultCube<W1, V>>>> { }

	[Serializable]
	public class LogicCube<T1> : Cube<T1, bool>
	{
		public override bool this[T1 key]
		{
			get
			{
				if (base.ContainsKey(key)) return base[key];
				else return false;
			}
			set
			{
				base[key] = value;
			}
		}
	}

	[Serializable]
	public class LogicCube<T1, T2> : CubeXD<T1, LogicCube<T2>> { };


	[Serializable]
	public class LogicCube<T1, T2, T3> : CubeXD<T1, CubeXD<T2, LogicCube<T3>>> { };


	[Serializable]
	public class LogicCube<T1, T2, T3, T4> : CubeXD<T1, CubeXD<T2, CubeXD<T3, LogicCube<T4>>>> { };


	[Serializable]
	public class LookupTable<K, T> : MultiCube<K, T>, IEnumerable<T>, ICloneable
	{
	
		public LookupTable() { }

		private List<T> _orginalList;
	
		public List<T> OrginalList
		{
			get { return _orginalList; }
			set { _orginalList = value; }
		}

		public LookupTable(List<T> list, Converter<T, K> dictinctIDSelector)
		{
			FromList(list, dictinctIDSelector);
		}

		public void FromList(List<T> list, Converter<T, K> dictinctIDSelector)
		{
			foreach (T item in list)
			{
				this[dictinctIDSelector(item)].Add(item);
			}

			_orginalList = list;
		}

		public new IEnumerator<T> GetEnumerator()
		{
			if (_orginalList != null)
			{
				foreach (T value in _orginalList) yield return value;
			}
			else
			{
				foreach (K key in this.Keys)
				{
					foreach (T value in this[key])
					{
						yield return value;
					}
				}
			}
		}


		#region ICloneable Members

		/// <summary>	Creates a new object that is a copy of the current instance. </summary>
		/// <returns>	A new object that is a copy of this instance. </returns>
		public object Clone()
		{
			LookupTable<K, T> clone = new LookupTable<K, T>();
			foreach (K key in this.Keys)
			{
				foreach (T value in this[key])
					clone[key].Add(value);
			}
			return clone;
		}

		#endregion
	}

}
