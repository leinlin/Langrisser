using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace SimpleJson.Reflection
{
	// Token: 0x020010C6 RID: 4294
	[GeneratedCode("reflection-utils", "1.0.0")]
	internal class ReflectionUtils
	{
		// Token: 0x06015922 RID: 88354 RVA: 0x0057F51C File Offset: 0x0057D71C
		public static Type GetTypeInfo(Type type)
		{
			return type;
		}

		// Token: 0x06015923 RID: 88355 RVA: 0x0057F520 File Offset: 0x0057D720
		public static Attribute GetAttribute(MemberInfo info, Type type)
		{
			if (info == null || type == null || !Attribute.IsDefined(info, type))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(info, type);
		}

		// Token: 0x06015924 RID: 88356 RVA: 0x0057F544 File Offset: 0x0057D744
		public static Type GetGenericListElementType(Type type)
		{
			IEnumerable<Type> interfaces = type.GetInterfaces();
			foreach (Type type2 in interfaces)
			{
				if (ReflectionUtils.IsTypeGeneric(type2) && type2.GetGenericTypeDefinition() == typeof(IList<>))
				{
					return ReflectionUtils.GetGenericTypeArguments(type2)[0];
				}
			}
			return ReflectionUtils.GetGenericTypeArguments(type)[0];
		}

		// Token: 0x06015925 RID: 88357 RVA: 0x0057F5D0 File Offset: 0x0057D7D0
		public static Attribute GetAttribute(Type objectType, Type attributeType)
		{
			if (objectType == null || attributeType == null || !Attribute.IsDefined(objectType, attributeType))
			{
				return null;
			}
			return Attribute.GetCustomAttribute(objectType, attributeType);
		}

		// Token: 0x06015926 RID: 88358 RVA: 0x0057F5F4 File Offset: 0x0057D7F4
		public static Type[] GetGenericTypeArguments(Type type)
		{
			return type.GetGenericArguments();
		}

		// Token: 0x06015927 RID: 88359 RVA: 0x0057F5FC File Offset: 0x0057D7FC
		public static bool IsTypeGeneric(Type type)
		{
			return ReflectionUtils.GetTypeInfo(type).IsGenericType;
		}

		// Token: 0x06015928 RID: 88360 RVA: 0x0057F60C File Offset: 0x0057D80C
		public static bool IsTypeGenericeCollectionInterface(Type type)
		{
			if (!ReflectionUtils.IsTypeGeneric(type))
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(IList<>) || genericTypeDefinition == typeof(ICollection<>) || genericTypeDefinition == typeof(IEnumerable<>);
		}

		// Token: 0x06015929 RID: 88361 RVA: 0x0057F660 File Offset: 0x0057D860
		public static bool IsAssignableFrom(Type type1, Type type2)
		{
			return ReflectionUtils.GetTypeInfo(type1).IsAssignableFrom(ReflectionUtils.GetTypeInfo(type2));
		}

		// Token: 0x0601592A RID: 88362 RVA: 0x0057F674 File Offset: 0x0057D874
		public static bool IsTypeDictionary(Type type)
		{
			if (typeof(IDictionary).IsAssignableFrom(type))
			{
				return true;
			}
			if (!ReflectionUtils.GetTypeInfo(type).IsGenericType)
			{
				return false;
			}
			Type genericTypeDefinition = type.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(IDictionary<, >);
		}

		// Token: 0x0601592B RID: 88363 RVA: 0x0057F6C0 File Offset: 0x0057D8C0
		public static bool IsNullableType(Type type)
		{
			return ReflectionUtils.GetTypeInfo(type).IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}

		// Token: 0x0601592C RID: 88364 RVA: 0x0057F6E8 File Offset: 0x0057D8E8
		public static object ToNullableType(object obj, Type nullableType)
		{
			return (obj != null) ? Convert.ChangeType(obj, Nullable.GetUnderlyingType(nullableType), CultureInfo.InvariantCulture) : null;
		}

		// Token: 0x0601592D RID: 88365 RVA: 0x0057F708 File Offset: 0x0057D908
		public static bool IsValueType(Type type)
		{
			return ReflectionUtils.GetTypeInfo(type).IsValueType;
		}

		// Token: 0x0601592E RID: 88366 RVA: 0x0057F718 File Offset: 0x0057D918
		public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
		{
			return type.GetConstructors();
		}

		// Token: 0x0601592F RID: 88367 RVA: 0x0057F720 File Offset: 0x0057D920
		public static ConstructorInfo GetConstructorInfo(Type type, params Type[] argsType)
		{
			IEnumerable<ConstructorInfo> constructors = ReflectionUtils.GetConstructors(type);
			foreach (ConstructorInfo constructorInfo in constructors)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (argsType.Length == parameters.Length)
				{
					int num = 0;
					bool flag = true;
					foreach (ParameterInfo parameterInfo in constructorInfo.GetParameters())
					{
						if (parameterInfo.ParameterType != argsType[num])
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						return constructorInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x0057F7E8 File Offset: 0x0057D9E8
		public static IEnumerable<PropertyInfo> GetProperties(Type type)
		{
			return type.GetProperties(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06015931 RID: 88369 RVA: 0x0057F7F4 File Offset: 0x0057D9F4
		public static IEnumerable<FieldInfo> GetFields(Type type)
		{
			return type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}

		// Token: 0x06015932 RID: 88370 RVA: 0x0057F800 File Offset: 0x0057DA00
		public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetGetMethod(true);
		}

		// Token: 0x06015933 RID: 88371 RVA: 0x0057F80C File Offset: 0x0057DA0C
		public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
		{
			return propertyInfo.GetSetMethod(true);
		}

		// Token: 0x06015934 RID: 88372 RVA: 0x0057F818 File Offset: 0x0057DA18
		public static ReflectionUtils.ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
		{
			return ReflectionUtils.GetConstructorByReflection(constructorInfo);
		}

		// Token: 0x06015935 RID: 88373 RVA: 0x0057F820 File Offset: 0x0057DA20
		public static ReflectionUtils.ConstructorDelegate GetContructor(Type type, params Type[] argsType)
		{
			return ReflectionUtils.GetConstructorByReflection(type, argsType);
		}

		// Token: 0x06015936 RID: 88374 RVA: 0x0057F82C File Offset: 0x0057DA2C
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
		{
			return (object[] args) => constructorInfo.Invoke(args);
		}

		// Token: 0x06015937 RID: 88375 RVA: 0x0057F854 File Offset: 0x0057DA54
		public static ReflectionUtils.ConstructorDelegate GetConstructorByReflection(Type type, params Type[] argsType)
		{
			ConstructorInfo constructorInfo = ReflectionUtils.GetConstructorInfo(type, argsType);
			return (constructorInfo != null) ? ReflectionUtils.GetConstructorByReflection(constructorInfo) : null;
		}

		// Token: 0x06015938 RID: 88376 RVA: 0x0057F87C File Offset: 0x0057DA7C
		public static ReflectionUtils.GetDelegate GetGetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(propertyInfo);
		}

		// Token: 0x06015939 RID: 88377 RVA: 0x0057F884 File Offset: 0x0057DA84
		public static ReflectionUtils.GetDelegate GetGetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetGetMethodByReflection(fieldInfo);
		}

		// Token: 0x0601593A RID: 88378 RVA: 0x0057F88C File Offset: 0x0057DA8C
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
			return (object source) => methodInfo.Invoke(source, ReflectionUtils.EmptyObjects);
		}

		// Token: 0x0601593B RID: 88379 RVA: 0x0057F8B8 File Offset: 0x0057DAB8
		public static ReflectionUtils.GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
		{
			return (object source) => fieldInfo.GetValue(source);
		}

		// Token: 0x0601593C RID: 88380 RVA: 0x0057F8E0 File Offset: 0x0057DAE0
		public static ReflectionUtils.SetDelegate GetSetMethod(PropertyInfo propertyInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(propertyInfo);
		}

		// Token: 0x0601593D RID: 88381 RVA: 0x0057F8E8 File Offset: 0x0057DAE8
		public static ReflectionUtils.SetDelegate GetSetMethod(FieldInfo fieldInfo)
		{
			return ReflectionUtils.GetSetMethodByReflection(fieldInfo);
		}

		// Token: 0x0601593E RID: 88382 RVA: 0x0057F8F0 File Offset: 0x0057DAF0
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
		{
			MethodInfo methodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
			return delegate(object source, object value)
			{
				methodInfo.Invoke(source, new object[]
				{
					value
				});
			};
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x0057F91C File Offset: 0x0057DB1C
		public static ReflectionUtils.SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
		{
			return delegate(object source, object value)
			{
				fieldInfo.SetValue(source, value);
			};
		}

		// Token: 0x0400BC9F RID: 48287
		private static readonly object[] EmptyObjects = new object[0];

		// Token: 0x020010C7 RID: 4295
		// (Invoke) Token: 0x06015942 RID: 88386
		public delegate object GetDelegate(object source);

		// Token: 0x020010C8 RID: 4296
		// (Invoke) Token: 0x06015946 RID: 88390
		public delegate void SetDelegate(object source, object value);

		// Token: 0x020010C9 RID: 4297
		// (Invoke) Token: 0x0601594A RID: 88394
		public delegate object ConstructorDelegate(params object[] args);

		// Token: 0x020010CA RID: 4298
		// (Invoke) Token: 0x0601594E RID: 88398
		public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

		// Token: 0x020010CB RID: 4299
		public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
		{
			// Token: 0x06015951 RID: 88401 RVA: 0x0057F954 File Offset: 0x0057DB54
			public ThreadSafeDictionary(ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
			{
				this._valueFactory = valueFactory;
			}

			// Token: 0x06015952 RID: 88402 RVA: 0x0057F970 File Offset: 0x0057DB70
			private TValue Get(TKey key)
			{
				if (this._dictionary == null)
				{
					return this.AddValue(key);
				}
				TValue result;
				if (!this._dictionary.TryGetValue(key, out result))
				{
					return this.AddValue(key);
				}
				return result;
			}

			// Token: 0x06015953 RID: 88403 RVA: 0x0057F9AC File Offset: 0x0057DBAC
			private TValue AddValue(TKey key)
			{
				TValue tvalue = this._valueFactory(key);
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._dictionary == null)
					{
						this._dictionary = new Dictionary<TKey, TValue>();
						this._dictionary[key] = tvalue;
					}
					else
					{
						TValue result;
						if (this._dictionary.TryGetValue(key, out result))
						{
							return result;
						}
						Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>(this._dictionary);
						dictionary[key] = tvalue;
						this._dictionary = dictionary;
					}
				}
				return tvalue;
			}

			// Token: 0x06015954 RID: 88404 RVA: 0x0057FA54 File Offset: 0x0057DC54
			public void Add(TKey key, TValue value)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06015955 RID: 88405 RVA: 0x0057FA5C File Offset: 0x0057DC5C
			public bool ContainsKey(TKey key)
			{
				return this._dictionary.ContainsKey(key);
			}

			// Token: 0x17003EE7 RID: 16103
			// (get) Token: 0x06015956 RID: 88406 RVA: 0x0057FA6C File Offset: 0x0057DC6C
			public ICollection<TKey> Keys
			{
				get
				{
					return this._dictionary.Keys;
				}
			}

			// Token: 0x06015957 RID: 88407 RVA: 0x0057FA7C File Offset: 0x0057DC7C
			public bool Remove(TKey key)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06015958 RID: 88408 RVA: 0x0057FA84 File Offset: 0x0057DC84
			public bool TryGetValue(TKey key, out TValue value)
			{
				value = this[key];
				return true;
			}

			// Token: 0x17003EE8 RID: 16104
			// (get) Token: 0x06015959 RID: 88409 RVA: 0x0057FA94 File Offset: 0x0057DC94
			public ICollection<TValue> Values
			{
				get
				{
					return this._dictionary.Values;
				}
			}

			// Token: 0x17003EE9 RID: 16105
			public TValue this[TKey key]
			{
				get
				{
					return this.Get(key);
				}
				set
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x0601595C RID: 88412 RVA: 0x0057FAB8 File Offset: 0x0057DCB8
			public void Add(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x0601595D RID: 88413 RVA: 0x0057FAC0 File Offset: 0x0057DCC0
			public void Clear()
			{
				throw new NotImplementedException();
			}

			// Token: 0x0601595E RID: 88414 RVA: 0x0057FAC8 File Offset: 0x0057DCC8
			public bool Contains(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x0601595F RID: 88415 RVA: 0x0057FAD0 File Offset: 0x0057DCD0
			public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
			{
				throw new NotImplementedException();
			}

			// Token: 0x17003EEA RID: 16106
			// (get) Token: 0x06015960 RID: 88416 RVA: 0x0057FAD8 File Offset: 0x0057DCD8
			public int Count
			{
				get
				{
					return this._dictionary.Count;
				}
			}

			// Token: 0x17003EEB RID: 16107
			// (get) Token: 0x06015961 RID: 88417 RVA: 0x0057FAE8 File Offset: 0x0057DCE8
			public bool IsReadOnly
			{
				get
				{
					throw new NotImplementedException();
				}
			}

			// Token: 0x06015962 RID: 88418 RVA: 0x0057FAF0 File Offset: 0x0057DCF0
			public bool Remove(KeyValuePair<TKey, TValue> item)
			{
				throw new NotImplementedException();
			}

			// Token: 0x06015963 RID: 88419 RVA: 0x0057FAF8 File Offset: 0x0057DCF8
			public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x06015964 RID: 88420 RVA: 0x0057FB0C File Offset: 0x0057DD0C
			IEnumerator IEnumerable.GetEnumerator()
			{
				return this._dictionary.GetEnumerator();
			}

			// Token: 0x0400BCA0 RID: 48288
			private readonly object _lock = new object();

			// Token: 0x0400BCA1 RID: 48289
			private readonly ReflectionUtils.ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

			// Token: 0x0400BCA2 RID: 48290
			private Dictionary<TKey, TValue> _dictionary;
		}
	}
}
