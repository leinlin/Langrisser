using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020001FE RID: 510
	[ProtoContract(Name = "ConfigDataArenaOpponentPointZoneInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataArenaOpponentPointZoneInfo : IExtensible
	{
		// Token: 0x06001D5D RID: 7517 RVA: 0x0009ABAC File Offset: 0x00098DAC
		public ConfigDataArenaOpponentPointZoneInfo()
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0009AC14 File Offset: 0x00098E14
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0009AC1C File Offset: 0x00098E1C
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x0009AC28 File Offset: 0x00098E28
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x0009AC30 File Offset: 0x00098E30
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x0009AC3C File Offset: 0x00098E3C
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x0009AC44 File Offset: 0x00098E44
		[ProtoMember(4, IsRequired = true, Name = "MinPercent", DataFormat = DataFormat.TwosComplement)]
		public int MinPercent
		{
			get
			{
				return this._MinPercent;
			}
			set
			{
				this._MinPercent = value;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0009AC50 File Offset: 0x00098E50
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x0009AC58 File Offset: 0x00098E58
		[ProtoMember(5, IsRequired = true, Name = "MaxPercent", DataFormat = DataFormat.TwosComplement)]
		public int MaxPercent
		{
			get
			{
				return this._MaxPercent;
			}
			set
			{
				this._MaxPercent = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0009AC64 File Offset: 0x00098E64
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x0009AC6C File Offset: 0x00098E6C
		[ProtoMember(6, IsRequired = true, Name = "VictoryPoint", DataFormat = DataFormat.TwosComplement)]
		public int VictoryPoint
		{
			get
			{
				return this._VictoryPoint;
			}
			set
			{
				this._VictoryPoint = value;
			}
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x0009AC78 File Offset: 0x00098E78
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0009AC88 File Offset: 0x00098E88
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

		// Token: 0x06001D6A RID: 7530 RVA: 0x0009AD54 File Offset: 0x00098F54
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaOpponentPointZoneInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400118B RID: 4491
		private int _ID;

		// Token: 0x0400118C RID: 4492
		private string _Name;

		// Token: 0x0400118D RID: 4493
		private int _MinPercent;

		// Token: 0x0400118E RID: 4494
		private int _MaxPercent;

		// Token: 0x0400118F RID: 4495
		private int _VictoryPoint;

		// Token: 0x04001190 RID: 4496
		private IExtension extensionObject;

		// Token: 0x04001191 RID: 4497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001192 RID: 4498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001193 RID: 4499
		private LuaFunction m_ctor_hotfix;
	}
}
