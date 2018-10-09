using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using ProtoBuf;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000065 RID: 101
	public class LuaProtoBufExtensionHandler : IProtobufExensionHandler
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x000146E0 File Offset: 0x000128E0
		protected LuaProtoBufExtensionHandler()
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00014700 File Offset: 0x00012900
		protected bool Init()
		{
			if (LuaManager.Instance == null)
			{
				return false;
			}
			this.m_protocolLuaDefineModule = LuaManager.Instance.RequireModule("ProtoBuf.ProtocolLuaDefine");
			this.m_configDataLuaDefineModule = LuaManager.Instance.RequireModule("ProtoBuf.ConfigDataLuaDefine");
			if (this.m_protocolLuaDefineModule == null)
			{
				Debug.LogError("RequireModule(ProtocolLuaDefineModuleName) fail");
				return false;
			}
			if (this.m_configDataLuaDefineModule == null)
			{
				Debug.LogError("RequireModule(ConfigDataLuaDefineModuleName) fail");
				return false;
			}
			this.m_protocolLuaDefine = (this.m_protocolLuaDefineModule.RawGet("TypeDefine") as LuaTable);
			if (this.m_protocolLuaDefine == null)
			{
				Debug.LogError("m_protocolLuaDefineModule.RawGet('TypeDefine') fail");
				return false;
			}
			this.m_protocolMsgIdDict = (this.m_protocolLuaDefineModule.RawGet("MsgIdDict") as LuaTable);
			this.m_configDataLuaDefine = (this.m_configDataLuaDefineModule.RawGet("TypeDefine") as LuaTable);
			if (this.m_configDataLuaDefine == null)
			{
				Debug.LogError("m_configDataLuaDefine.RawGet('TypeDefine') fail");
				return false;
			}
			return true;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001480C File Offset: 0x00012A0C
		public static LuaProtoBufExtensionHandler Create()
		{
			LuaProtoBufExtensionHandler luaProtoBufExtensionHandler = new LuaProtoBufExtensionHandler();
			if (!luaProtoBufExtensionHandler.Init())
			{
				return null;
			}
			ProtobufExensionHelper.SetHandler(luaProtoBufExtensionHandler);
			return luaProtoBufExtensionHandler;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00014838 File Offset: 0x00012A38
		public static bool IsSystemType(string typeName)
		{
			if (typeName != null)
			{
				if (LuaProtoBufExtensionHandler.<>f__switch$map0 == null)
				{
					LuaProtoBufExtensionHandler.<>f__switch$map0 = new Dictionary<string, int>(15)
					{
						{
							"System.Boolean",
							0
						},
						{
							"System.Char",
							0
						},
						{
							"System.SByte",
							0
						},
						{
							"System.Byte",
							0
						},
						{
							"System.Int16",
							0
						},
						{
							"System.UInt16",
							0
						},
						{
							"System.Int32",
							0
						},
						{
							"System.UInt32",
							0
						},
						{
							"System.Int64",
							0
						},
						{
							"System.UInt64",
							0
						},
						{
							"System.Single",
							0
						},
						{
							"System.Double",
							0
						},
						{
							"System.Decimal",
							0
						},
						{
							"System.DateTime",
							0
						},
						{
							"System.String",
							0
						}
					};
				}
				int num;
				if (LuaProtoBufExtensionHandler.<>f__switch$map0.TryGetValue(typeName, out num))
				{
					if (num == 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00014938 File Offset: 0x00012B38
		public IProtobufExtensionTypeInfo GetExtTypeInfo(string typeName)
		{
			LuaProtobufExtensionTypeInfo luaProtobufExtensionTypeInfo;
			if (this.m_typeInfoDict.TryGetValue(typeName, out luaProtobufExtensionTypeInfo))
			{
				return luaProtobufExtensionTypeInfo;
			}
			if (LuaProtoBufExtensionHandler.IsSystemType(typeName))
			{
				luaProtobufExtensionTypeInfo = new LuaProtobufExtensionTypeInfo(typeName, null, this);
			}
			else
			{
				LuaTable luaTypeDefine = this.GetLuaTypeDefine(typeName);
				if (luaTypeDefine == null)
				{
					return null;
				}
				luaProtobufExtensionTypeInfo = new LuaProtobufExtensionTypeInfo(typeName, luaTypeDefine, this);
			}
			this.m_typeInfoDict.Add(typeName, luaProtobufExtensionTypeInfo);
			return luaProtobufExtensionTypeInfo;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000149A0 File Offset: 0x00012BA0
		public IProtobufExtensionTypeInfo GetExtTypeInfo(int msgId)
		{
			LuaProtobufExtensionTypeInfo luaProtobufExtensionTypeInfo;
			if (this.m_typeInfoDictById.TryGetValue(msgId, out luaProtobufExtensionTypeInfo))
			{
				return luaProtobufExtensionTypeInfo;
			}
			LuaTable luaTypeDefineByMsgId = this.GetLuaTypeDefineByMsgId(msgId);
			if (luaTypeDefineByMsgId == null)
			{
				return null;
			}
			luaProtobufExtensionTypeInfo = new LuaProtobufExtensionTypeInfo(luaTypeDefineByMsgId.RawGet<string>("TypeName"), luaTypeDefineByMsgId, this);
			this.m_typeInfoDictById.Add(msgId, luaProtobufExtensionTypeInfo);
			return luaProtobufExtensionTypeInfo;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000149FC File Offset: 0x00012BFC
		public List<IProtobufExtensionTypeInfo> GetExtTypeInfoList()
		{
			List<IProtobufExtensionTypeInfo> list = new List<IProtobufExtensionTypeInfo>();
			foreach (LuaTable.TablePair tablePair in this.m_configDataLuaDefine)
			{
				LuaTable typeDef = tablePair.value as LuaTable;
				string typeName = tablePair.key as string;
				IProtobufExtensionTypeInfo item = new LuaProtobufExtensionTypeInfo(typeName, typeDef, this);
				list.Add(item);
			}
			foreach (LuaTable.TablePair tablePair2 in this.m_protocolLuaDefine)
			{
				LuaTable typeDef2 = tablePair2.value as LuaTable;
				string typeName2 = tablePair2.key as string;
				IProtobufExtensionTypeInfo item2 = new LuaProtobufExtensionTypeInfo(typeName2, typeDef2, this);
				list.Add(item2);
			}
			return list;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00014AFC File Offset: 0x00012CFC
		public object GetExtensionMember(object extObj, string extMemberName)
		{
			if (string.IsNullOrEmpty(extMemberName))
			{
				Debug.LogError("GetExtensionMember extMemberName is empty");
				return null;
			}
			LuaTable hotfixLuaObj = this.GetHotfixLuaObj(extObj);
			if (hotfixLuaObj == null)
			{
				Debug.LogError("GetExtensionMember can't get hotfixLuaObj");
				return null;
			}
			return hotfixLuaObj.RawGet(extMemberName);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00014B48 File Offset: 0x00012D48
		public void SetExtensionMember(object extObj, object memberValue, string extMemberName)
		{
			if (string.IsNullOrEmpty(extMemberName))
			{
				Debug.LogError("SetExtensionMember extMemberName is empty");
				return;
			}
			LuaTable hotfixLuaObj = this.GetHotfixLuaObj(extObj);
			if (hotfixLuaObj == null)
			{
				Debug.LogError("SetExtensionMember can't get hotfixLuaObj");
				return;
			}
			hotfixLuaObj.RawSet(extMemberName, memberValue);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00014B94 File Offset: 0x00012D94
		public IEnumerable GetExtensionMemberListIEnumerable(object list)
		{
			return list as LuaTable;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00014B9C File Offset: 0x00012D9C
		public void AddExtensionMemberListItem(object list, object item)
		{
			LuaTable luaTable = list as LuaTable;
			if (luaTable == null)
			{
				return;
			}
			luaTable[luaTable.length() + 1] = item;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00014BCC File Offset: 0x00012DCC
		public object CreateExtensionList()
		{
			return new LuaTable(LuaManager.Instance.GetLuaState());
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00014BE0 File Offset: 0x00012DE0
		public Type ResolveTypeByName(string typeName)
		{
			switch (typeName)
			{
			case "System.Boolean":
				return typeof(bool);
			case "System.Char":
				return typeof(char);
			case "System.SByte":
				return typeof(sbyte);
			case "System.Byte":
				return typeof(byte);
			case "System.Int16":
				return typeof(short);
			case "System.UInt16":
				return typeof(ushort);
			case "System.Int32":
				return typeof(int);
			case "System.UInt32":
				return typeof(uint);
			case "System.Int64":
				return typeof(long);
			case "System.UInt64":
				return typeof(ulong);
			case "System.Single":
				return typeof(float);
			case "System.Double":
				return typeof(double);
			case "System.Decimal":
				return typeof(decimal);
			case "System.DateTime":
				return typeof(DateTime);
			case "System.String":
				return typeof(string);
			}
			Type type = Assembly.GetExecutingAssembly().GetType(typeName);
			if (type != null)
			{
				return type;
			}
			return (!this.GetExtTypeInfo(typeName).IsEnum()) ? typeof(DummyType) : typeof(DummyEnumType);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00014E08 File Offset: 0x00013008
		private LuaTable GetHotfixLuaObj(object extObj)
		{
			if (extObj == null)
			{
				Debug.LogError("GetHotfixLuaObj extObj is null");
				return null;
			}
			FieldInfo field = extObj.GetType().GetField("m_luaObjHelper", BindingFlags.Instance | BindingFlags.NonPublic);
			if (field == null)
			{
				Debug.LogError("GetHotfixLuaObj can't get field: m_luaObjHelper");
				return null;
			}
			BJLuaObjHelper bjluaObjHelper = field.GetValue(extObj) as BJLuaObjHelper;
			if (bjluaObjHelper == null)
			{
				Debug.LogError("GetHotfixLuaObj can't get value from field");
				return null;
			}
			return bjluaObjHelper.GetLuaObj();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00014E74 File Offset: 0x00013074
		private LuaTable GetLuaTypeDefine(string typeName)
		{
			int num = typeName.LastIndexOf('.');
			if (num != -1)
			{
				num++;
				typeName = typeName.Substring(num, typeName.Length - num);
			}
			LuaTable luaTable = this.m_protocolLuaDefine.RawGet(typeName) as LuaTable;
			if (luaTable == null)
			{
				luaTable = (this.m_configDataLuaDefine.RawGet(typeName) as LuaTable);
			}
			return luaTable;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00014ED8 File Offset: 0x000130D8
		private LuaTable GetLuaTypeDefineByMsgId(int msgId)
		{
			return this.m_protocolMsgIdDict[msgId] as LuaTable;
		}

		// Token: 0x04000215 RID: 533
		protected LuaTable m_protocolLuaDefineModule;

		// Token: 0x04000216 RID: 534
		protected LuaTable m_configDataLuaDefineModule;

		// Token: 0x04000217 RID: 535
		protected LuaTable m_protocolLuaDefine;

		// Token: 0x04000218 RID: 536
		protected LuaTable m_protocolMsgIdDict;

		// Token: 0x04000219 RID: 537
		protected LuaTable m_configDataLuaDefine;

		// Token: 0x0400021A RID: 538
		protected Dictionary<string, LuaProtobufExtensionTypeInfo> m_typeInfoDict = new Dictionary<string, LuaProtobufExtensionTypeInfo>();

		// Token: 0x0400021B RID: 539
		protected Dictionary<int, LuaProtobufExtensionTypeInfo> m_typeInfoDictById = new Dictionary<int, LuaProtobufExtensionTypeInfo>();

		// Token: 0x0400021C RID: 540
		private const string ProtocolLuaDefineModuleName = "ProtoBuf.ProtocolLuaDefine";

		// Token: 0x0400021D RID: 541
		private const string ConfigDataLuaDefineModuleName = "ProtoBuf.ConfigDataLuaDefine";
	}
}
