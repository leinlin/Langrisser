using System;
using System.Collections.Generic;
using ProtoBuf;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000066 RID: 102
	public class LuaProtobufExtensionTypeInfo : IProtobufExtensionTypeInfo
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x00014EEC File Offset: 0x000130EC
		public LuaProtobufExtensionTypeInfo(string typeName, LuaTable typeDef, LuaProtoBufExtensionHandler handler)
		{
			this.m_typeName = typeName;
			this.m_typeDef = typeDef;
			this.m_handler = handler;
			this.m_typeCode = LuaProtobufExtensionTypeInfo.GetTypeCode(typeName);
			if (LuaProtobufExtensionTypeInfo.IsSystemType(this.m_typeCode))
			{
				return;
			}
			this.m_isExtension = typeDef.RawGet<bool>("IsExtension");
			this.m_isEnum = typeDef.RawGet<bool>("IsEnum");
			this.m_hasExtension = typeDef.RawGet<bool>("HasExtension");
			this.m_hasExtensionInHierarchy = typeDef.RawGet<bool>("HasExtensionInHierarchy");
			LuaTable luaTable = typeDef.RawGet("MemberList") as LuaTable;
			if (luaTable == null)
			{
				throw new ApplicationException("LuaProtobufExtensionTypeInfo() MemberList miss " + typeName);
			}
			foreach (LuaTable.TablePair tablePair in luaTable)
			{
				string text = tablePair.key as string;
				LuaTable memberDefine = tablePair.value as LuaTable;
				LuaProtobufExtensionTypeMemberInfo value = new LuaProtobufExtensionTypeMemberInfo(text, memberDefine, handler);
				this.m_memberDict.Add(text, value);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00015024 File Offset: 0x00013224
		public string GetTypeName()
		{
			return this.m_typeName;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001502C File Offset: 0x0001322C
		public TypeCode GetTypeCode()
		{
			return this.m_typeCode;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00015034 File Offset: 0x00013234
		public IEnumerable<IProtobufExtensionTypeMemberInfo> GetMembers()
		{
			foreach (KeyValuePair<string, LuaProtobufExtensionTypeMemberInfo> item in this.m_memberDict)
			{
				yield return item.Value;
			}
			yield break;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00015058 File Offset: 0x00013258
		public IProtobufExtensionTypeMemberInfo GetMember(string name)
		{
			LuaProtobufExtensionTypeMemberInfo result;
			if (this.m_memberDict.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0001507C File Offset: 0x0001327C
		public bool HasExtension()
		{
			return this.m_hasExtension;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00015084 File Offset: 0x00013284
		public bool HasExtensionInHierarchy()
		{
			return this.m_hasExtensionInHierarchy;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0001508C File Offset: 0x0001328C
		public bool IsEnum()
		{
			return this.m_isEnum;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00015094 File Offset: 0x00013294
		public static bool IsSystemType(TypeCode typeCode)
		{
			return typeCode != TypeCode.Object;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000150A0 File Offset: 0x000132A0
		public static TypeCode GetTypeCode(string typeName)
		{
			switch (typeName)
			{
			case "System.Boolean":
				return TypeCode.Boolean;
			case "System.Char":
				return TypeCode.Char;
			case "System.SByte":
				return TypeCode.SByte;
			case "System.Byte":
				return TypeCode.Byte;
			case "System.Int16":
				return TypeCode.Int16;
			case "System.UInt16":
				return TypeCode.UInt16;
			case "System.Int32":
				return TypeCode.Int32;
			case "System.UInt32":
				return TypeCode.UInt32;
			case "System.Int64":
				return TypeCode.Int64;
			case "System.UInt64":
				return TypeCode.UInt64;
			case "System.Single":
				return TypeCode.Single;
			case "System.Double":
				return TypeCode.Double;
			case "System.Decimal":
				return TypeCode.Decimal;
			case "System.DateTime":
				return TypeCode.DateTime;
			case "System.String":
				return TypeCode.String;
			}
			return TypeCode.Object;
		}

		// Token: 0x04000220 RID: 544
		protected LuaProtoBufExtensionHandler m_handler;

		// Token: 0x04000221 RID: 545
		protected string m_typeName;

		// Token: 0x04000222 RID: 546
		protected TypeCode m_typeCode;

		// Token: 0x04000223 RID: 547
		protected LuaTable m_typeDef;

		// Token: 0x04000224 RID: 548
		protected bool m_isExtension;

		// Token: 0x04000225 RID: 549
		protected bool m_hasExtension;

		// Token: 0x04000226 RID: 550
		protected bool m_hasExtensionInHierarchy;

		// Token: 0x04000227 RID: 551
		private bool m_isEnum;

		// Token: 0x04000228 RID: 552
		protected Dictionary<string, LuaProtobufExtensionTypeMemberInfo> m_memberDict = new Dictionary<string, LuaProtobufExtensionTypeMemberInfo>();
	}
}
