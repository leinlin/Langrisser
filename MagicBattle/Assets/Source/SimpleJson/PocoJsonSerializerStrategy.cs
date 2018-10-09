using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using SimpleJson.Reflection;

namespace SimpleJson
{
	// Token: 0x020010C5 RID: 4293
	[GeneratedCode("simple-json", "1.0.0")]
	public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
	{
		// Token: 0x06015916 RID: 88342 RVA: 0x0057E9B4 File Offset: 0x0057CBB4
		public PocoJsonSerializerStrategy()
		{
			this.ConstructorCache = new ReflectionUtils.ThreadSafeDictionary<Type, ReflectionUtils.ConstructorDelegate>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, ReflectionUtils.ConstructorDelegate>(this.ContructorDelegateFactory));
			this.GetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, ReflectionUtils.GetDelegate>>(this.GetterValueFactory));
			this.SetCache = new ReflectionUtils.ThreadSafeDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(new ReflectionUtils.ThreadSafeDictionaryValueFactory<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>>(this.SetterValueFactory));
		}

		// Token: 0x06015917 RID: 88343 RVA: 0x0057EA10 File Offset: 0x0057CC10
		protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
		{
			return clrPropertyName;
		}

		// Token: 0x06015918 RID: 88344 RVA: 0x0057EA14 File Offset: 0x0057CC14
		internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
		{
			return ReflectionUtils.GetContructor(key, (!key.IsArray) ? PocoJsonSerializerStrategy.EmptyTypes : PocoJsonSerializerStrategy.ArrayConstructorParameterTypes);
		}

		// Token: 0x06015919 RID: 88345 RVA: 0x0057EA38 File Offset: 0x0057CC38
		internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
		{
			IDictionary<string, ReflectionUtils.GetDelegate> dictionary = new Dictionary<string, ReflectionUtils.GetDelegate>();
			foreach (PropertyInfo propertyInfo in ReflectionUtils.GetProperties(type))
			{
				if (propertyInfo.CanRead)
				{
					MethodInfo getterMethodInfo = ReflectionUtils.GetGetterMethodInfo(propertyInfo);
					if (!getterMethodInfo.IsStatic && getterMethodInfo.IsPublic)
					{
						dictionary[this.MapClrMemberNameToJsonFieldName(propertyInfo.Name)] = ReflectionUtils.GetGetMethod(propertyInfo);
					}
				}
			}
			foreach (FieldInfo fieldInfo in ReflectionUtils.GetFields(type))
			{
				if (!fieldInfo.IsStatic && fieldInfo.IsPublic)
				{
					dictionary[this.MapClrMemberNameToJsonFieldName(fieldInfo.Name)] = ReflectionUtils.GetGetMethod(fieldInfo);
				}
			}
			return dictionary;
		}

		// Token: 0x0601591A RID: 88346 RVA: 0x0057EB54 File Offset: 0x0057CD54
		internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
		{
			IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> dictionary = new Dictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>();
			foreach (PropertyInfo propertyInfo in ReflectionUtils.GetProperties(type))
			{
				if (propertyInfo.CanWrite)
				{
					MethodInfo setterMethodInfo = ReflectionUtils.GetSetterMethodInfo(propertyInfo);
					if (!setterMethodInfo.IsStatic && setterMethodInfo.IsPublic)
					{
						dictionary[this.MapClrMemberNameToJsonFieldName(propertyInfo.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(propertyInfo.PropertyType, ReflectionUtils.GetSetMethod(propertyInfo));
					}
				}
			}
			foreach (FieldInfo fieldInfo in ReflectionUtils.GetFields(type))
			{
				if (!fieldInfo.IsInitOnly && !fieldInfo.IsStatic && fieldInfo.IsPublic)
				{
					dictionary[this.MapClrMemberNameToJsonFieldName(fieldInfo.Name)] = new KeyValuePair<Type, ReflectionUtils.SetDelegate>(fieldInfo.FieldType, ReflectionUtils.GetSetMethod(fieldInfo));
				}
			}
			return dictionary;
		}

		// Token: 0x0601591B RID: 88347 RVA: 0x0057EC94 File Offset: 0x0057CE94
		public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
		{
			return this.TrySerializeKnownTypes(input, out output) || this.TrySerializeUnknownTypes(input, out output);
		}

		// Token: 0x0601591C RID: 88348 RVA: 0x0057ECB0 File Offset: 0x0057CEB0
		public virtual object DeserializeObject(object value, Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			string text = value as string;
			if (type == typeof(Guid) && string.IsNullOrEmpty(text))
			{
				return default(Guid);
			}
			if (value == null)
			{
				return null;
			}
			object obj = null;
			if (text != null)
			{
				if (text.Length != 0)
				{
					if (type == typeof(DateTime) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTime)))
					{
						return DateTime.ParseExact(text, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(DateTimeOffset) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(DateTimeOffset)))
					{
						return DateTimeOffset.ParseExact(text, PocoJsonSerializerStrategy.Iso8601Format, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
					}
					if (type == typeof(Guid) || (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid)))
					{
						return new Guid(text);
					}
					if (type == typeof(Uri))
					{
						bool flag = Uri.IsWellFormedUriString(text, UriKind.RelativeOrAbsolute);
						Uri result;
						if (flag && Uri.TryCreate(text, UriKind.RelativeOrAbsolute, out result))
						{
							return result;
						}
						return null;
					}
					else
					{
						if (type == typeof(string))
						{
							return text;
						}
						return Convert.ChangeType(text, type, CultureInfo.InvariantCulture);
					}
				}
				else
				{
					if (type == typeof(Guid))
					{
						obj = default(Guid);
					}
					else if (ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
					{
						obj = null;
					}
					else
					{
						obj = text;
					}
					if (!ReflectionUtils.IsNullableType(type) && Nullable.GetUnderlyingType(type) == typeof(Guid))
					{
						return text;
					}
				}
			}
			else if (value is bool)
			{
				return value;
			}
			bool flag2 = value is long;
			bool flag3 = value is double;
			if ((flag2 && type == typeof(long)) || (flag3 && type == typeof(double)))
			{
				return value;
			}
			if ((!flag3 || type == typeof(double)) && (!flag2 || type == typeof(long)))
			{
				IDictionary<string, object> dictionary = value as IDictionary<string, object>;
				if (dictionary != null)
				{
					IDictionary<string, object> dictionary2 = dictionary;
					if (ReflectionUtils.IsTypeDictionary(type))
					{
						Type[] genericTypeArguments = ReflectionUtils.GetGenericTypeArguments(type);
						Type type2 = genericTypeArguments[0];
						Type type3 = genericTypeArguments[1];
						Type key = typeof(Dictionary<, >).MakeGenericType(new Type[]
						{
							type2,
							type3
						});
						IDictionary dictionary3 = (IDictionary)this.ConstructorCache[key](new object[0]);
						foreach (KeyValuePair<string, object> keyValuePair in dictionary2)
						{
							dictionary3.Add(keyValuePair.Key, this.DeserializeObject(keyValuePair.Value, type3));
						}
						obj = dictionary3;
					}
					else if (type == typeof(object))
					{
						obj = value;
					}
					else
					{
						obj = this.ConstructorCache[type](new object[0]);
						foreach (KeyValuePair<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> keyValuePair2 in this.SetCache[type])
						{
							object value2;
							if (dictionary2.TryGetValue(keyValuePair2.Key, out value2))
							{
								value2 = this.DeserializeObject(value2, keyValuePair2.Value.Key);
								keyValuePair2.Value.Value(obj, value2);
							}
						}
					}
				}
				else
				{
					IList<object> list = value as IList<object>;
					if (list != null)
					{
						IList<object> list2 = list;
						IList list3 = null;
						if (type.IsArray)
						{
							list3 = (IList)this.ConstructorCache[type](new object[]
							{
								list2.Count
							});
							int num = 0;
							foreach (object value3 in list2)
							{
								list3[num++] = this.DeserializeObject(value3, type.GetElementType());
							}
						}
						else if (ReflectionUtils.IsTypeGenericeCollectionInterface(type) || ReflectionUtils.IsAssignableFrom(typeof(IList), type))
						{
							Type genericListElementType = ReflectionUtils.GetGenericListElementType(type);
							ReflectionUtils.ConstructorDelegate constructorDelegate;
							if ((constructorDelegate = this.ConstructorCache[type]) == null)
							{
								constructorDelegate = this.ConstructorCache[typeof(List<>).MakeGenericType(new Type[]
								{
									genericListElementType
								})];
							}
							list3 = (IList)constructorDelegate(new object[]
							{
								list2.Count
							});
							foreach (object value4 in list2)
							{
								list3.Add(this.DeserializeObject(value4, genericListElementType));
							}
						}
						obj = list3;
					}
				}
				return obj;
			}
			obj = ((type != typeof(int) && type != typeof(long) && type != typeof(double) && type != typeof(float) && type != typeof(bool) && type != typeof(decimal) && type != typeof(byte) && type != typeof(short)) ? value : Convert.ChangeType(value, type, CultureInfo.InvariantCulture));
			if (ReflectionUtils.IsNullableType(type))
			{
				return ReflectionUtils.ToNullableType(obj, type);
			}
			return obj;
		}

		// Token: 0x0601591D RID: 88349 RVA: 0x0057F310 File Offset: 0x0057D510
		protected virtual object SerializeEnum(Enum p)
		{
			return Convert.ToDouble(p, CultureInfo.InvariantCulture);
		}

		// Token: 0x0601591E RID: 88350 RVA: 0x0057F324 File Offset: 0x0057D524
		protected virtual bool TrySerializeKnownTypes(object input, out object output)
		{
			bool result = true;
			if (input is DateTime)
			{
				output = ((DateTime)input).ToUniversalTime().ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is DateTimeOffset)
			{
				output = ((DateTimeOffset)input).ToUniversalTime().ToString(PocoJsonSerializerStrategy.Iso8601Format[0], CultureInfo.InvariantCulture);
			}
			else if (input is Guid)
			{
				output = ((Guid)input).ToString("D");
			}
			else if (input is Uri)
			{
				output = input.ToString();
			}
			else
			{
				Enum @enum = input as Enum;
				if (@enum != null)
				{
					output = this.SerializeEnum(@enum);
				}
				else
				{
					result = false;
					output = null;
				}
			}
			return result;
		}

		// Token: 0x0601591F RID: 88351 RVA: 0x0057F400 File Offset: 0x0057D600
		protected virtual bool TrySerializeUnknownTypes(object input, out object output)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			output = null;
			Type type = input.GetType();
			if (type.FullName == null)
			{
				return false;
			}
			IDictionary<string, object> dictionary = new JsonObject();
			IDictionary<string, ReflectionUtils.GetDelegate> dictionary2 = this.GetCache[type];
			foreach (KeyValuePair<string, ReflectionUtils.GetDelegate> keyValuePair in dictionary2)
			{
				if (keyValuePair.Value != null)
				{
					dictionary.Add(this.MapClrMemberNameToJsonFieldName(keyValuePair.Key), keyValuePair.Value(input));
				}
			}
			output = dictionary;
			return true;
		}

		// Token: 0x0400BC99 RID: 48281
		internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

		// Token: 0x0400BC9A RID: 48282
		internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

		// Token: 0x0400BC9B RID: 48283
		internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

		// Token: 0x0400BC9C RID: 48284
		internal static readonly Type[] EmptyTypes = new Type[0];

		// Token: 0x0400BC9D RID: 48285
		internal static readonly Type[] ArrayConstructorParameterTypes = new Type[]
		{
			typeof(int)
		};

		// Token: 0x0400BC9E RID: 48286
		private static readonly string[] Iso8601Format = new string[]
		{
			"yyyy-MM-dd\\THH:mm:ss.FFFFFFF\\Z",
			"yyyy-MM-dd\\THH:mm:ss\\Z",
			"yyyy-MM-dd\\THH:mm:ssK"
		};
	}
}
