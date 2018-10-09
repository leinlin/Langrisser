using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067E RID: 1662
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBusinessCardInfoSet")]
	[Serializable]
	public class ProBusinessCardInfoSet : IExtensible
	{
		// Token: 0x06005A8D RID: 23181 RVA: 0x001A06BC File Offset: 0x0019E8BC
		public ProBusinessCardInfoSet()
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

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x001A0730 File Offset: 0x0019E930
		// (set) Token: 0x06005A8F RID: 23183 RVA: 0x001A0738 File Offset: 0x0019E938
		[ProtoMember(1, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
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

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06005A90 RID: 23184 RVA: 0x001A0744 File Offset: 0x0019E944
		[ProtoMember(2, Name = "Heroes", DataFormat = DataFormat.Default)]
		public List<ProBusinessCardHeroSet> Heroes
		{
			get
			{
				return this._Heroes;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06005A91 RID: 23185 RVA: 0x001A074C File Offset: 0x0019E94C
		// (set) Token: 0x06005A92 RID: 23186 RVA: 0x001A0754 File Offset: 0x0019E954
		[ProtoMember(3, IsRequired = true, Name = "IsActionRandom", DataFormat = DataFormat.Default)]
		public bool IsActionRandom
		{
			get
			{
				return this._IsActionRandom;
			}
			set
			{
				this._IsActionRandom = value;
			}
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x001A0760 File Offset: 0x0019E960
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x001A0770 File Offset: 0x0019E970
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

		// Token: 0x06005A95 RID: 23189 RVA: 0x001A083C File Offset: 0x0019EA3C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBusinessCardInfoSet));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043D3 RID: 17363
		private string _Desc;

		// Token: 0x040043D4 RID: 17364
		private readonly List<ProBusinessCardHeroSet> _Heroes = new List<ProBusinessCardHeroSet>();

		// Token: 0x040043D5 RID: 17365
		private bool _IsActionRandom;

		// Token: 0x040043D6 RID: 17366
		private IExtension extensionObject;

		// Token: 0x040043D7 RID: 17367
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043D8 RID: 17368
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043D9 RID: 17369
		private LuaFunction m_ctor_hotfix;
	}
}
