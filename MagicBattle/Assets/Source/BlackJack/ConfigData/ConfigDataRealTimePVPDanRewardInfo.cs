using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000279 RID: 633
	[ProtoContract(Name = "ConfigDataRealTimePVPDanRewardInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataRealTimePVPDanRewardInfo : IExtensible
	{
		// Token: 0x060028B0 RID: 10416 RVA: 0x000AE6D0 File Offset: 0x000AC8D0
		public ConfigDataRealTimePVPDanRewardInfo()
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

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000AE738 File Offset: 0x000AC938
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x000AE740 File Offset: 0x000AC940
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

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000AE74C File Offset: 0x000AC94C
		// (set) Token: 0x060028B4 RID: 10420 RVA: 0x000AE754 File Offset: 0x000AC954
		[ProtoMember(3, IsRequired = true, Name = "Dan", DataFormat = DataFormat.TwosComplement)]
		public int Dan
		{
			get
			{
				return this._Dan;
			}
			set
			{
				this._Dan = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x000AE760 File Offset: 0x000AC960
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x000AE768 File Offset: 0x000AC968
		[ProtoMember(4, IsRequired = true, Name = "DanRewardMailTemplateId", DataFormat = DataFormat.TwosComplement)]
		public int DanRewardMailTemplateId
		{
			get
			{
				return this._DanRewardMailTemplateId;
			}
			set
			{
				this._DanRewardMailTemplateId = value;
			}
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x000AE774 File Offset: 0x000AC974
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x000AE784 File Offset: 0x000AC984
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

		// Token: 0x060028B9 RID: 10425 RVA: 0x000AE850 File Offset: 0x000ACA50
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRealTimePVPDanRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001902 RID: 6402
		private int _ID;

		// Token: 0x04001903 RID: 6403
		private int _Dan;

		// Token: 0x04001904 RID: 6404
		private int _DanRewardMailTemplateId;

		// Token: 0x04001905 RID: 6405
		private IExtension extensionObject;

		// Token: 0x04001906 RID: 6406
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001907 RID: 6407
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001908 RID: 6408
		private LuaFunction m_ctor_hotfix;
	}
}
