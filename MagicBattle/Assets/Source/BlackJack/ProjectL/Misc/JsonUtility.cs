using System;
using BlackJack.ProjectL.Common;
using SimpleJson;
using SLua;

namespace BlackJack.ProjectL.Misc
{
	// Token: 0x02000877 RID: 2167
	[CustomLuaClass]
	public class JsonUtility
	{
		// Token: 0x06006B6F RID: 27503 RVA: 0x001E2388 File Offset: 0x001E0588
		public static string Serialize(object j)
		{
			if (j == null)
			{
				return string.Empty;
			}
			return SimpleJson.SerializeObject(j);
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x001E239C File Offset: 0x001E059C
		public static object Deserialize(string txt)
		{
			if (string.IsNullOrEmpty(txt))
			{
				return null;
			}
			object result;
			try
			{
				result = SimpleJson.DeserializeObject(txt);
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x001E23DC File Offset: 0x001E05DC
		public static T Deserialize<T>(string txt) where T : class
		{
			if (string.IsNullOrEmpty(txt))
			{
				return (T)((object)null);
			}
			T result;
			try
			{
				result = SimpleJson.DeserializeObject<T>(txt);
			}
			catch (Exception ex)
			{
				Debug.LogError(string.Format("SimpleJson.DeserializeObject from {0} failed, error: {1}", txt, ex.Message));
				result = (T)((object)null);
			}
			return result;
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x001E243C File Offset: 0x001E063C
		public static string SerializeObject(JsonObject j)
		{
			if (j == null)
			{
				return string.Empty;
			}
			return SimpleJson.SerializeObject(j);
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x001E2450 File Offset: 0x001E0650
		public static string SerializeArray(JsonArray j)
		{
			if (j == null)
			{
				return string.Empty;
			}
			return SimpleJson.SerializeObject(j);
		}

		// Token: 0x06006B74 RID: 27508 RVA: 0x001E2464 File Offset: 0x001E0664
		public static JsonObject DeserializeObject(string txt)
		{
			return JsonUtility.Deserialize(txt) as JsonObject;
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x001E2474 File Offset: 0x001E0674
		public static JsonArray DeserializeArray(string txt)
		{
			return JsonUtility.Deserialize(txt) as JsonArray;
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x001E2484 File Offset: 0x001E0684
		public static JsonArray AddArray(JsonObject j, string key)
		{
			JsonArray jsonArray = new JsonArray();
			j[key] = jsonArray;
			return jsonArray;
		}

		// Token: 0x06006B77 RID: 27511 RVA: 0x001E24A0 File Offset: 0x001E06A0
		public static JsonObject AddObject(JsonObject j, string key)
		{
			JsonObject jsonObject = new JsonObject();
			j[key] = jsonObject;
			return jsonObject;
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x001E24BC File Offset: 0x001E06BC
		public static JsonObject AddObject(JsonArray a)
		{
			JsonObject jsonObject = new JsonObject();
			a.Add(jsonObject);
			return jsonObject;
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x001E24D8 File Offset: 0x001E06D8
		public static JsonObject GetObject(JsonObject j, string key)
		{
			return JsonUtility.GetObj(j, key) as JsonObject;
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x001E24E8 File Offset: 0x001E06E8
		public static JsonArray GetArray(JsonObject j, string key)
		{
			return JsonUtility.GetObj(j, key) as JsonArray;
		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x001E24F8 File Offset: 0x001E06F8
		private static object GetObj(JsonObject j, string key)
		{
			if (j == null)
			{
				return false;
			}
			if (string.IsNullOrEmpty(key))
			{
				return false;
			}
			object result;
			if (!j.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x001E2538 File Offset: 0x001E0738
		public static void Set(JsonObject j, string key, long value)
		{
			j[key] = value;
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x001E2548 File Offset: 0x001E0748
		public static bool Get(JsonObject j, string key, ref long value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (long)obj;
			return true;
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x001E2588 File Offset: 0x001E0788
		public static void Set(JsonObject j, string key, int value)
		{
			j[key] = value;
		}

		// Token: 0x06006B7F RID: 27519 RVA: 0x001E2598 File Offset: 0x001E0798
		public static bool Get(JsonObject j, string key, ref int value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (int)((long)obj);
			return true;
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x001E25D8 File Offset: 0x001E07D8
		public static void Set(JsonObject j, string key, uint value)
		{
			j[key] = value;
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x001E25E8 File Offset: 0x001E07E8
		public static bool Get(JsonObject j, string key, ref uint value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (uint)((long)obj);
			return true;
		}

		// Token: 0x06006B82 RID: 27522 RVA: 0x001E2628 File Offset: 0x001E0828
		public static void Set(JsonObject j, string key, short value)
		{
			j[key] = value;
		}

		// Token: 0x06006B83 RID: 27523 RVA: 0x001E2638 File Offset: 0x001E0838
		public static bool Get(JsonObject j, string key, ref short value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (short)((long)obj);
			return true;
		}

		// Token: 0x06006B84 RID: 27524 RVA: 0x001E2678 File Offset: 0x001E0878
		public static void Set(JsonObject j, string key, ushort value)
		{
			j[key] = value;
		}

		// Token: 0x06006B85 RID: 27525 RVA: 0x001E2688 File Offset: 0x001E0888
		public static bool Get(JsonObject j, string key, ref ushort value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (ushort)((long)obj);
			return true;
		}

		// Token: 0x06006B86 RID: 27526 RVA: 0x001E26C8 File Offset: 0x001E08C8
		public static void Set(JsonObject j, string key, sbyte value)
		{
			j[key] = value;
		}

		// Token: 0x06006B87 RID: 27527 RVA: 0x001E26D8 File Offset: 0x001E08D8
		public static bool Get(JsonObject j, string key, ref sbyte value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (sbyte)((long)obj);
			return true;
		}

		// Token: 0x06006B88 RID: 27528 RVA: 0x001E2718 File Offset: 0x001E0918
		public static void Set(JsonObject j, string key, byte value)
		{
			j[key] = value;
		}

		// Token: 0x06006B89 RID: 27529 RVA: 0x001E2728 File Offset: 0x001E0928
		public static bool Get(JsonObject j, string key, ref byte value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (byte)((long)obj);
			return true;
		}

		// Token: 0x06006B8A RID: 27530 RVA: 0x001E2768 File Offset: 0x001E0968
		public static void Set(JsonObject j, string key, double value)
		{
			j[key] = value;
		}

		// Token: 0x06006B8B RID: 27531 RVA: 0x001E2778 File Offset: 0x001E0978
		public static bool Get(JsonObject j, string key, ref double value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(double))
			{
				return false;
			}
			value = (double)obj;
			return true;
		}

		// Token: 0x06006B8C RID: 27532 RVA: 0x001E27B8 File Offset: 0x001E09B8
		public static void Set(JsonObject j, string key, float value)
		{
			j[key] = value;
		}

		// Token: 0x06006B8D RID: 27533 RVA: 0x001E27C8 File Offset: 0x001E09C8
		public static bool Get(JsonObject j, string key, ref float value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(double))
			{
				return false;
			}
			value = (float)((double)obj);
			return true;
		}

		// Token: 0x06006B8E RID: 27534 RVA: 0x001E2808 File Offset: 0x001E0A08
		public static void Set(JsonObject j, string key, bool value)
		{
			j[key] = value;
		}

		// Token: 0x06006B8F RID: 27535 RVA: 0x001E2818 File Offset: 0x001E0A18
		public static bool Get(JsonObject j, string key, ref bool value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(bool))
			{
				return false;
			}
			value = (bool)obj;
			return true;
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x001E2858 File Offset: 0x001E0A58
		public static void Set(JsonObject j, string key, string value)
		{
			j[key] = value;
		}

		// Token: 0x06006B91 RID: 27537 RVA: 0x001E2864 File Offset: 0x001E0A64
		public static bool Get(JsonObject j, string key, ref string value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(string))
			{
				return false;
			}
			value = (string)obj;
			return true;
		}

		// Token: 0x06006B92 RID: 27538 RVA: 0x001E28A4 File Offset: 0x001E0AA4
		public static void Set(JsonObject j, string key, DateTime value)
		{
			j[key] = value.ToBinary();
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x001E28BC File Offset: 0x001E0ABC
		public static bool Get(JsonObject j, string key, ref DateTime value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = DateTime.FromBinary((long)obj);
			return true;
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x001E2904 File Offset: 0x001E0B04
		public static bool Get(JsonObject j, string key, ref PLong value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (long)obj;
			return true;
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x001E294C File Offset: 0x001E0B4C
		public static bool Get(JsonObject j, string key, ref PInt value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (int)((long)obj);
			return true;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x001E2994 File Offset: 0x001E0B94
		public static bool Get(JsonObject j, string key, ref PUInt value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (uint)((long)obj);
			return true;
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x001E29DC File Offset: 0x001E0BDC
		public static bool Get(JsonObject j, string key, ref PShort value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (short)((long)obj);
			return true;
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x001E2A24 File Offset: 0x001E0C24
		public static bool Get(JsonObject j, string key, ref PUShort value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (ushort)((long)obj);
			return true;
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x001E2A6C File Offset: 0x001E0C6C
		public static bool Get(JsonObject j, string key, ref PSByte value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (sbyte)((long)obj);
			return true;
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x001E2AB4 File Offset: 0x001E0CB4
		public static bool Get(JsonObject j, string key, ref PByte value)
		{
			object obj = JsonUtility.GetObj(j, key);
			if (obj == null)
			{
				return false;
			}
			if (obj.GetType() != typeof(long))
			{
				return false;
			}
			value = (byte)((long)obj);
			return true;
		}
	}
}
