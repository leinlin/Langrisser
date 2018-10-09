using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026F RID: 623
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataRandomDropRewardInfo")]
	[Serializable]
	public class ConfigDataRandomDropRewardInfo : IExtensible
	{
		// Token: 0x060027FD RID: 10237 RVA: 0x000AD024 File Offset: 0x000AB224
		public ConfigDataRandomDropRewardInfo()
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

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000AD098 File Offset: 0x000AB298
		// (set) Token: 0x060027FF RID: 10239 RVA: 0x000AD0A0 File Offset: 0x000AB2A0
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

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000AD0AC File Offset: 0x000AB2AC
		// (set) Token: 0x06002801 RID: 10241 RVA: 0x000AD0B4 File Offset: 0x000AB2B4
		[ProtoMember(3, IsRequired = true, Name = "DropID", DataFormat = DataFormat.TwosComplement)]
		public int DropID
		{
			get
			{
				return this._DropID;
			}
			set
			{
				this._DropID = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
		// (set) Token: 0x06002803 RID: 10243 RVA: 0x000AD0C8 File Offset: 0x000AB2C8
		[ProtoMember(4, IsRequired = true, Name = "GroupIndex", DataFormat = DataFormat.TwosComplement)]
		public int GroupIndex
		{
			get
			{
				return this._GroupIndex;
			}
			set
			{
				this._GroupIndex = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000AD0D4 File Offset: 0x000AB2D4
		// (set) Token: 0x06002805 RID: 10245 RVA: 0x000AD0DC File Offset: 0x000AB2DC
		[ProtoMember(5, IsRequired = true, Name = "DropCount", DataFormat = DataFormat.TwosComplement)]
		public int DropCount
		{
			get
			{
				return this._DropCount;
			}
			set
			{
				this._DropCount = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x000AD0E8 File Offset: 0x000AB2E8
		[ProtoMember(6, Name = "DropRewards", DataFormat = DataFormat.Default)]
		public List<WeightGoods> DropRewards
		{
			get
			{
				return this._DropRewards;
			}
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000AD0F0 File Offset: 0x000AB2F0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x000AD100 File Offset: 0x000AB300
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

		// Token: 0x06002809 RID: 10249 RVA: 0x000AD1CC File Offset: 0x000AB3CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataRandomDropRewardInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001889 RID: 6281
		private int _ID;

		// Token: 0x0400188A RID: 6282
		private int _DropID;

		// Token: 0x0400188B RID: 6283
		private int _GroupIndex;

		// Token: 0x0400188C RID: 6284
		private int _DropCount;

		// Token: 0x0400188D RID: 6285
		private readonly List<WeightGoods> _DropRewards = new List<WeightGoods>();

		// Token: 0x0400188E RID: 6286
		private IExtension extensionObject;

		// Token: 0x0400188F RID: 6287
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001890 RID: 6288
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001891 RID: 6289
		private LuaFunction m_ctor_hotfix;
	}
}
