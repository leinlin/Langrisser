using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000260 RID: 608
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataMissionExtNoviceInfo")]
	[Serializable]
	public class ConfigDataMissionExtNoviceInfo : IExtensible
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x000AAE14 File Offset: 0x000A9014
		public ConfigDataMissionExtNoviceInfo()
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

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x000AAE7C File Offset: 0x000A907C
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x000AAE84 File Offset: 0x000A9084
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

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x000AAE90 File Offset: 0x000A9090
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x000AAE98 File Offset: 0x000A9098
		[ProtoMember(3, IsRequired = true, Name = "NovicePoints", DataFormat = DataFormat.TwosComplement)]
		public int NovicePoints
		{
			get
			{
				return this._NovicePoints;
			}
			set
			{
				this._NovicePoints = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x000AAEA4 File Offset: 0x000A90A4
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x000AAEAC File Offset: 0x000A90AC
		[ProtoMember(4, IsRequired = true, Name = "ActivateTime", DataFormat = DataFormat.TwosComplement)]
		public int ActivateTime
		{
			get
			{
				return this._ActivateTime;
			}
			set
			{
				this._ActivateTime = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x000AAEB8 File Offset: 0x000A90B8
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x000AAEC0 File Offset: 0x000A90C0
		[ProtoMember(5, IsRequired = true, Name = "DeactivateTime", DataFormat = DataFormat.TwosComplement)]
		public int DeactivateTime
		{
			get
			{
				return this._DeactivateTime;
			}
			set
			{
				this._DeactivateTime = value;
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000AAECC File Offset: 0x000A90CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000AAEDC File Offset: 0x000A90DC
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

		// Token: 0x060026F7 RID: 9975 RVA: 0x000AAFA8 File Offset: 0x000A91A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataMissionExtNoviceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040017D1 RID: 6097
		private int _ID;

		// Token: 0x040017D2 RID: 6098
		private int _NovicePoints;

		// Token: 0x040017D3 RID: 6099
		private int _ActivateTime;

		// Token: 0x040017D4 RID: 6100
		private int _DeactivateTime;

		// Token: 0x040017D5 RID: 6101
		private IExtension extensionObject;

		// Token: 0x040017D6 RID: 6102
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040017D7 RID: 6103
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040017D8 RID: 6104
		private LuaFunction m_ctor_hotfix;
	}
}
