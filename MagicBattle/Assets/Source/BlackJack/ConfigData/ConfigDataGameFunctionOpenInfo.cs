using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000235 RID: 565
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataGameFunctionOpenInfo")]
	[Serializable]
	public class ConfigDataGameFunctionOpenInfo : IExtensible
	{
		// Token: 0x0600229A RID: 8858 RVA: 0x000A3D24 File Offset: 0x000A1F24
		public ConfigDataGameFunctionOpenInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x000A3D8C File Offset: 0x000A1F8C
		// (set) Token: 0x0600229C RID: 8860 RVA: 0x000A3D94 File Offset: 0x000A1F94
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600229D RID: 8861 RVA: 0x000A3DA0 File Offset: 0x000A1FA0
		// (set) Token: 0x0600229E RID: 8862 RVA: 0x000A3DA8 File Offset: 0x000A1FA8
		[ProtoMember(3, IsRequired = true, Name = "GameFunctionType", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionType GameFunctionType
		{
			get
			{
				return this._GameFunctionType;
			}
			set
			{
				this._GameFunctionType = value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x000A3DB4 File Offset: 0x000A1FB4
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x000A3DBC File Offset: 0x000A1FBC
		[ProtoMember(4, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000A3DC8 File Offset: 0x000A1FC8
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x000A3DD0 File Offset: 0x000A1FD0
		[ProtoMember(5, IsRequired = true, Name = "OpenCondition", DataFormat = DataFormat.TwosComplement)]
		public GameFunctionOpenConditionType OpenCondition
		{
			get
			{
				return this._OpenCondition;
			}
			set
			{
				this._OpenCondition = value;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x000A3DDC File Offset: 0x000A1FDC
		// (set) Token: 0x060022A4 RID: 8868 RVA: 0x000A3DE4 File Offset: 0x000A1FE4
		[ProtoMember(6, IsRequired = true, Name = "OpenConditionParam1", DataFormat = DataFormat.TwosComplement)]
		public int OpenConditionParam1
		{
			get
			{
				return this._OpenConditionParam1;
			}
			set
			{
				this._OpenConditionParam1 = value;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x000A3DF0 File Offset: 0x000A1FF0
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x000A3DF8 File Offset: 0x000A1FF8
		[ProtoMember(7, IsRequired = true, Name = "Message", DataFormat = DataFormat.Default)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				this._Message = value;
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x000A3E04 File Offset: 0x000A2004
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x000A3E14 File Offset: 0x000A2014
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x000A3EE0 File Offset: 0x000A20E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataGameFunctionOpenInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040014F2 RID: 5362
		private int _ID;

		// Token: 0x040014F3 RID: 5363
		private GameFunctionType _GameFunctionType;

		// Token: 0x040014F4 RID: 5364
		private string _Name;

		// Token: 0x040014F5 RID: 5365
		private GameFunctionOpenConditionType _OpenCondition;

		// Token: 0x040014F6 RID: 5366
		private int _OpenConditionParam1;

		// Token: 0x040014F7 RID: 5367
		private string _Message;

		// Token: 0x040014F8 RID: 5368
		private IExtension extensionObject;

		// Token: 0x040014F9 RID: 5369
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040014FA RID: 5370
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040014FB RID: 5371
		private LuaFunction m_ctor_hotfix;
	}
}
