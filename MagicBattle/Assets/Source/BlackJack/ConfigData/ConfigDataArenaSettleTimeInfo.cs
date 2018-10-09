using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000201 RID: 513
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArenaSettleTimeInfo")]
	[Serializable]
	public class ConfigDataArenaSettleTimeInfo : IExtensible
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x0009B18C File Offset: 0x0009938C
		public ConfigDataArenaSettleTimeInfo()
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0009B1F4 File Offset: 0x000993F4
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0009B1FC File Offset: 0x000993FC
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x0009B208 File Offset: 0x00099408
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x0009B210 File Offset: 0x00099410
		[ProtoMember(3, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x0009B21C File Offset: 0x0009941C
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x0009B224 File Offset: 0x00099424
		[ProtoMember(4, IsRequired = true, Name = "SettleStartTime", DataFormat = DataFormat.TwosComplement)]
		public int SettleStartTime
		{
			get
			{
				return this._SettleStartTime;
			}
			set
			{
				this._SettleStartTime = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x0009B230 File Offset: 0x00099430
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0009B238 File Offset: 0x00099438
		[ProtoMember(5, IsRequired = true, Name = "SettleEndTime", DataFormat = DataFormat.TwosComplement)]
		public int SettleEndTime
		{
			get
			{
				return this._SettleEndTime;
			}
			set
			{
				this._SettleEndTime = value;
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0009B244 File Offset: 0x00099444
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x0009B254 File Offset: 0x00099454
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

		// Token: 0x06001D8A RID: 7562 RVA: 0x0009B320 File Offset: 0x00099520
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaSettleTimeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011A2 RID: 4514
		private int _ID;

		// Token: 0x040011A3 RID: 4515
		private string _Desc;

		// Token: 0x040011A4 RID: 4516
		private int _SettleStartTime;

		// Token: 0x040011A5 RID: 4517
		private int _SettleEndTime;

		// Token: 0x040011A6 RID: 4518
		private IExtension extensionObject;

		// Token: 0x040011A7 RID: 4519
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011A8 RID: 4520
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011A9 RID: 4521
		private LuaFunction m_ctor_hotfix;
	}
}
